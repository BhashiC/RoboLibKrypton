using RoboLib.Models;
using RoboLib.Utils.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib
{
    public static class RUtils
    {
        /// <summary>
        /// Easy access to Component Map
        /// </summary>
        public static ComponentMap Map
        {
            get
            {
                return ComponentMap.Instance;
            }
        }

        public static PropMeta Prop
        {
            get
            {
                return PropMeta.Instance;
            }
        }

        public static void WriteLog(Severities severity, string procedureName, string text)
        {
            Log.Instance.Write(severity, procedureName, text);
        }


        /// <summary>
        /// Easy Access to Message Component
        /// </summary>
        public static ComponentBase MessageComp
        {
            get { return SystemBuilder.Instance.MessageComp; }
        }

        /// <summary>
        /// Easy Access to ControlUtils
        /// </summary>
        public static ControlUtils Control
        {
            get { return ControlUtils.Instance; }
        }
    }
}
