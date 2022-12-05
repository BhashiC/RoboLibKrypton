using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class Transition : SMObjBase
    {
        public Color TransitionDefaultColor { get; set; } 
        public Color TransitionTextColor { get; set; }

        public Transition()
        {
            TransitionDefaultColor = Color.FromArgb(175, 130, 255);
            TransitionTextColor = Color.FromArgb(255, 255, 255);
        }
    }
}
