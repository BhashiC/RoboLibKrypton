using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SMState : SMObjBase
    {
        public Color StateDefaultColor { get; set; } 
        public Color StateTextColor { get; set; }

        public SMState()
        {
            StateDefaultColor = Color.FromArgb(120, 115, 95);
            StateTextColor = Color.FromArgb(255, 255, 255);
        }
    }
}
