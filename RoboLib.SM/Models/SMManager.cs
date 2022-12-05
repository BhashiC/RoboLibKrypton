using Newtonsoft.Json;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmManager : ComponentBase
    {
        readonly object _lockSM = new object();

        /// <summary>
        /// Time for waiting before recheck a SM condition
        /// </summary>
        [BindingTools(Unit = Units.msec)]
        public int WaitSMConditionTime { get; set; }

        /// <summary>
        /// List of registered SMs
        /// </summary>
        [JsonIgnore, CrossReference]
        public List<StateMachine> SMs { get; set; }

        /// <summary>
        /// Any running
        /// </summary>
        [JsonIgnore, ViewMode(PropertyViewModes.ReadOnly)]
        public bool AnyRunning { get; private set; }

        /// <summary>
        /// Maximum number of workers for parallel actions (workers shared accross all SMs)
        /// </summary>
        public int MaxWorkersForParallelActions { get; set; }

        public SmManager()
        {
            WaitSMConditionTime = 1;
            MaxWorkersForParallelActions = 3;
            SMs = new List<StateMachine>();
        }

        /// <summary>
        /// Register a state machine
        /// </summary>
        /// <param name="sm"></param>
        public void RegisterStateMachine(StateMachine sm)
        {
            lock (_lockSM)
            {
                if (!SMs.Contains(sm)) SMs.Add(sm);
            }
        }

        /// <summary>
        /// Un register a state machine
        /// </summary>
        /// <param name="sm"></param>
        public void UnRegisterStateMachine(StateMachine sm)
        {
            lock (_lockSM)
            {
                if (SMs.Contains(sm)) SMs.Remove(sm);
            }
        }

        /// <summary>
        /// Run all registerred state machines
        /// </summary>
        public void Run()
        {
            lock (_lockSM)
            {
                //SMs.Where(x => x.Enabled).ForEach(x => x.Run());
            }
        }

        /// <summary>
        /// Stop all registerred state machines
        /// </summary>
        public void Stop()
        {
            lock (_lockSM)
            {
                //SMs.ForEach(x => x.Stop());
            }
        }

        /// <summary>
        /// Step all state machines
        /// </summary>
        public void Step()
        {
            lock (_lockSM)
            {
                //SMs.Where(x => x.Enabled).ForEach(x => { x.Stepping = true; x.Run(); });
            }
            // Make sure we notify the status again. The delay is for eliminating thread racing.
            Thread.Sleep(100);
        }

        /// <summary>
        /// Reset all registerred state machines
        /// </summary>
        public void Reset()
        {
            lock (_lockSM)
            {
               //SMs.ForEach(x => x.Reset());
            }
        }

        /// <summary>
        /// Force Stop (ignore StopPoint).
        /// </summary>
        /// <param name="resetAfterStop"></param>
        public void ForceStop(bool resetAfterStop = false)
        {
            lock (_lockSM)
            {
                //SMs.ForEach(x => x.ForceStop());
                //if (resetAfterStop)
                //{
                //    SMs.ForEach(x => x.Reset());
                //}
            }
        }

        /// <summary>
        /// Update the AnyRunning
        /// </summary>
        internal void UpdateRunningStatus()
        {
            //var anyRunning = SMs.Any(x => x.IsRunning);

            //if (anyRunning != AnyRunning)
            //{
            //    AnyRunning = anyRunning;
            //}
        }
        protected override void OnInitializeRecurse()
        {
            base.OnInitializeRecurse();
            //new MTimer2(200, false, UpdateRunningStatus).SetKey("UpdateSMStatus").Start();
            //RefMachine.evOnAlert += new Action<AlertItem>(RefMachine_evOnAlert);
        }

        protected override void OnDestroyRecurese()
        {
            base.OnDestroyRecurese();
            //RefMachine.evOnAlert -= new Action<AlertItem>(RefMachine_evOnAlert);
        }

        //void RefMachine_evOnAlert(AlertItem a)
        //{
        //    if (a.AlertMethod.ContainFlag(AlertMethods.Stop))
        //    {
        //        Stop();
        //    }
        //}

        protected override void DefinePages(Dictionary<string, Type> pageTypes)
        {
            base.DefinePages(pageTypes);
        }
    }
}
