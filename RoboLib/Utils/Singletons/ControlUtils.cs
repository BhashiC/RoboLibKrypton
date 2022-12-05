using RoboLib.Extensions;
using RoboLib.GUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboLib.Utils.Singletons
{
    public class ControlUtils : Singleton<ControlUtils>
    {
        /// <summary>
        /// Invoke an action to the GUI thread
        /// </summary>
        /// <param name="action"></param>
        /// <param name="sync">set true for syn with GUI thread</param> 
        /// <param name="onException">things to do on exception</param> 
        public void InvokeAction(Action action, bool sync = false, Action<Exception> onException = null)
        {
            try
            {
                var c = RefControl.Instance ?? TempControl();
                if (c != null && c.InvokeRequired)
                {
                    if (!sync)
                    {
                        var r = c.BeginInvoke(new MethodInvoker(() =>
                        {
                            try
                            {
                                action(); // default run asynchronously on GUI thread
                            }
                            catch (Exception ex)
                            {
                                onException.Elvis(x => x(ex));
                            }
                        }));
                    }
                    else
                    {
                        c.Invoke(action); // if user set, run synchronously on GUI thread
                    }
                }
                else
                {
                    action(); // default run asynchronously on GUI thread
                }
            }
            catch(Exception ex)
            {
                onException.Elvis(x => x(ex));
                if (onException == null)
                {
                    var rex = new RException("InvokeAction Failed!");
                    rex.Execute(ex.ToString());
                }
            }
        }

        Control TempControl()
        {
            Control c = new Control();
            c.CreateControl();
            return c;
        }
    }
}
