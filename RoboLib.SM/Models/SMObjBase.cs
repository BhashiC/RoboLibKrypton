using Newtonsoft.Json;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmObjBase : ObjBase
    {
        StateMachine _sm;
        [JsonIgnore, CrossReference]
        public StateMachine SM
        {
            get
            {
                _sm = _sm ?? this.Parent as StateMachine;
                return _sm;
            }
            set
            {
                _sm = value;
            }
        }

        [JsonIgnore, CrossReference]
        public SmManager SMmgr { get; set; }

        protected override void OnInitializeRecurse()
        {
            base.OnInitializeRecurse();

            SMmgr = RUtils.Map.GetComponent<SmManager>("SMMgr");
            _sm = null;
        }
    }
}
