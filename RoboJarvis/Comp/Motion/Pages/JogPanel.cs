using RoboLib;
using RoboLib.Extensions;
using RoboLib.GUI.Pages;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboJarvis.Comp.Motion.Pages
{
    public partial class JogPanel : ViewPage
    {
        Axis _axis;
        public JogPanel()
        {
            InitializeComponent();
        }

        protected override void DefineBinding(ObjBase objBase)
        {
            base.DefineBinding(objBase);
            _axis = objBase as Axis;

            rtbJogDistance.BindToProperty(_axis, "JogDistance");
            rtbJogSpeed.BindToProperty(_axis, "JogSpeed");
        }

        private void kbtnJogPos_Click(object sender, EventArgs e)
        {
            kbtnJogPos.Enabled = false;
            try
            {
                _axis.JogPlus();
            }
            catch (Exception ex)
            {
                throw new RException("Jog Plus Failed", ex);
            }
            finally
            {
                kbtnJogPos.Enabled = true;
            }
        }

        private void kbtnJogNeg_Click(object sender, EventArgs e)
        {
            kbtnJogNeg.Enabled = false;
            try
            {
                _axis.JogMinus();
            }
            catch (Exception ex)
            {
                throw new RException("Jog Minus Failed", ex);
            }
            finally
            {
                kbtnJogNeg.Enabled = true;
            }
        }
    }
}
