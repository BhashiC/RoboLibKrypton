using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmAction : SmObjBase
    {
        /// <summary>
        /// The order of excecution in State
        /// </summary>
        public int Order { get; set; }

        public SmAction()
        {
            Order = 0;
        }

        /// <summary>
        /// The script for calling
        /// </summary>
        public string MethodScript { get; set; }

        /// <summary>
        /// List of SM arguments
        /// </summary>
        [JsonIgnore]
        public List<SmArgument> Arguments { get; private set; }

        Action<object, object[]> _action;

        protected override void OnInitializeRecurse()
        {
            base.OnInitializeRecurse();

        }
    }
}
