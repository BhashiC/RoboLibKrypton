using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmMethod : SmObjBase
    {
        /// <summary>
        /// The order of excecution in State
        /// </summary>
        public int Order { get; set; }

        public SmMethod()
        {
            Order = 0;
        }

        /// <summary>
        /// Method script for calling
        /// </summary>
        public string MethodScript { get; set; }

        protected override void OnInitializeRecurse()
        {
            base.OnInitializeRecurse();
        }
    }
}
