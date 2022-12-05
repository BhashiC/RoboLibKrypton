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
    public partial class MKSSettingsPanel : ViewPage
    {
        MKSAxis _axis;

        public MKSSettingsPanel()
        {
            InitializeComponent();
        }

        protected override void DefineBinding(ObjBase objBase)
        {
            base.DefineBinding(objBase);

            _axis = objBase as MKSAxis;

            rcbMicroStep.BindToProperty(_axis, "MicroStep", false).UseDataSource(_axis.MicroSteps);
            rcbHoldCurrent.BindToProperty(_axis, "HoldCurrent", false).UseDataSource(_axis.HoldCurrents);
            rcbMotorCurrent.BindToProperty(_axis, "MotorCurrent", false).UseDataSource(_axis.MotorCurrents);
            rtbGearRation.SetReadOnly(true);
            rtbGearRation.BindToProperty(_axis, "GearRation", false);
            rcbUseGearBox.BindToProperty(_axis, "UseGearBox", false);
        }

        void AlertAndCalibrate() 
        {
            if (MessageBox.Show("Please remove motor from gear box and peess OK to continue",
                "Calibration Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                _axis.Calibrate();
            }
        }

        private void kbtnSetMicroStep_Click(object sender, EventArgs e)
        {
            kbtnSetMicroStep.RunAsync(() => _axis.SetMicroStep(_axis.MicroStep));
        }

        private void kbtnSetHoldCurrent_Click(object sender, EventArgs e)
        {
            kbtnSetHoldCurrent.RunAsync(() => _axis.SetHoldCurrent(_axis.HoldCurrent));
        }

        private void kbtnSetMotorCurrent_Click(object sender, EventArgs e)
        {
            kbtnSetMotorCurrent.RunAsync(() => _axis.SetMotorCurrent(_axis.MotorCurrent));
        }

        private void kbtnCalibrate_Click(object sender, EventArgs e)
        {
            kbtnCalibrate.RunAsync(() => AlertAndCalibrate());
        }
    }
}
