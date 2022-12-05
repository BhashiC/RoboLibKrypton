using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmCondition : SmObjBase
    {
        /// <summary>
        /// Condition script for calling
        /// </summary>
        public string ConditionScript { get; set; }

        protected override void OnInitializeRecurse()
        {
            base.OnInitializeRecurse();
        }
    }
}
