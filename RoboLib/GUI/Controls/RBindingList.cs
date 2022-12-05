using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboLib.Models;

namespace RoboLib.GUI.Controls
{
    public class RBindingList<T> : BindingList<T>, IRBindingList
    {
        public RaiseListChangedInvokeMethods ListChangedInvokeMethod { get; set; }

        public RBindingList()
        {
            ListChangedInvokeMethod = RaiseListChangedInvokeMethods.GUIAsync;
        }

        #region Implementation for IBindingList interface
        /// <summary>
        /// Raise before item is removed
        /// </summary>
        public event Action<ObjBase, int> ItemRemoving;

        /// <summary>
        /// Suspends the list change events
        /// </summary>
        public void SuspendListChange()
        {

            RaiseListChangedEvents = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resetBindings"></param>
        public void ResumeListChange(bool resetBindings)
        {
            RaiseListChangedEvents = true;
            if (resetBindings)
            {
                ResetBindings();
            }
        }
        #endregion


        #region Implementation for BindingList<T> class
        /// <summary>
        /// Run when Raise the List changed event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (RaiseListChangedEvents)
            {
                switch (ListChangedInvokeMethod)
                {
                    case RaiseListChangedInvokeMethods.GUISync:
                        RUtils.Control.InvokeAction(() => base.OnListChanged(e), true);
                        break;
                    case RaiseListChangedInvokeMethods.GUIAsync:
                        RUtils.Control.InvokeAction(() => base.OnListChanged(e));
                        break;
                    case RaiseListChangedInvokeMethods.None:
                    default:
                        base.OnListChanged(e);
                        break;
                }
            }
        }

        /// <summary>
        /// This event is raised before item is removed
        /// </summary>
        /// <param name="index"></param>
        protected override void RemoveItem(int index)
        {
            ObjBase item = this.Items[index] as ObjBase;
            if (ItemRemoving != null && RaiseListChangedEvents)
            {
                switch (ListChangedInvokeMethod)
                {
                    case RaiseListChangedInvokeMethods.GUISync:
                        RUtils.Control.InvokeAction(() => ItemRemoving(item, index), true);
                        break;
                    case RaiseListChangedInvokeMethods.GUIAsync:
                        RUtils.Control.InvokeAction(() => ItemRemoving(item, index));
                        break;
                    case RaiseListChangedInvokeMethods.None:
                    default:
                        ItemRemoving(item, index);
                        break;
                }
            }
            base.RemoveItem(index);
        }
        #endregion
    }
}
