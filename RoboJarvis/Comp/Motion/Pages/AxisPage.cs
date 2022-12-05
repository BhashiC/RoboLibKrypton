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
    public partial class AxisPage : ViewPage
    {
        Axis _axis;
        public AxisPage()
        {
            InitializeComponent();
        }

        protected override void DefineBinding(ObjBase objBase)
        {
            base.DefineBinding(objBase);
            _axis = objBase as Axis;

            motionHeaderPanel1.PerformBinding(_axis);
            jogPanel1.PerformBinding(_axis);
            softLimitPanel1.PerformBinding(_axis);

            motionStripPanel1.SetPositionName("Position 1");
            motionStripPanel2.SetPositionName("Position 2");
            motionStripPanel3.SetPositionName("Position 3");

            string name = _axis.Name;
            if (name == CompNames.Axis1.ToString())
            {
                motionHeaderPanel1.SetAxisName("Joint 1");
            }
            else if (name == CompNames.Axis2.ToString()) 
            {
                motionHeaderPanel1.SetAxisName("Joint 2");
            }
            else if (name == CompNames.Axis3.ToString())
            {
                motionHeaderPanel1.SetAxisName("Joint 3");
            }
            else if (name == CompNames.Axis4.ToString())
            {
                motionHeaderPanel1.SetAxisName("Joint 4");
            }
            else if (name == CompNames.Axis5.ToString())
            {
                motionHeaderPanel1.SetAxisName("Joint 5");
            }
            else if (name == CompNames.Axis6.ToString())
            {
                motionHeaderPanel1.SetAxisName("Joint 6");
            }
        }
    }
}
