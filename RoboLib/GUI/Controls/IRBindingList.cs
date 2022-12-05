using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.GUI.Controls
{
    public interface IRBindingList : IBindingList
    {
        /// <summary>
        /// Raise before item is removed
        /// </summary>
        event Action<ObjBase, int> ItemRemoving;
        
        /// <summary>
        /// Suspend the list changes events
        /// </summary>
        void SuspendListChange();
        
        /// <summary>
        /// Resume list change events and ResetBindings
        /// </summary>
        /// <param name="resetBindings"></param>
        void ResumeListChange(bool resetBindings = false);
    }
}
