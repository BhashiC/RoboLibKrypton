using RoboLib.Models;
using RoboLib.SM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class StateMachine : ComponentBase
    {
        public List<SmNormalState> NormalStates { get; set; }

        public List<SmDecisionState> DecisionStates { get; set; }

        protected override void DefinePages(Dictionary<string, Type> pageTypes)
        {
            base.DefinePages(pageTypes);
            pageTypes.Add("SMView", typeof(SMEditPanel));
        }
    }
}
