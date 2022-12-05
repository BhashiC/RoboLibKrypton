using Newtonsoft.Json;
using Robo3DWpf;
using RoboLib;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboJarvis
{
    public class JarvisRobot : Robot
    {
        [JsonIgnore]
        public Robo3DUserControl RoboModelWpfControl { get; set; }

        /// <summary>
        /// GUI theme
        /// </summary>
        [ViewMode(PropertyViewModes.ReadOnly)]
        public Themes GUITheme { get; set; }

        public JarvisRobot() { }
    }
}
