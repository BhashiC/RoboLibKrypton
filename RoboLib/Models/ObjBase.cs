using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.Models
{
    public class ObjBase : INotifyPropertyChanged
    {
        /// <summary>
        /// The Name of this object.
        /// </summary>
        [JsonProperty(Order = 0), ViewMode(PropertyViewModes.ReadOnly)]
        public string Name { get; set; }

        [JsonProperty(Order = 0), ViewMode(PropertyViewModes.ReadOnly)]
        public ObjBase Parent { get; set; }

        [JsonProperty(Order = -5), ViewMode(PropertyViewModes.ReadOnly)]
        public string ThisType
        {
            get { return this.GetType().Name; }
        }

        /// <summary>
        /// Parent component of the current component 
        /// </summary>
        [JsonIgnore, ViewMode(PropertyViewModes.ReadOnly)]
        public ObjBase ParentComp
        {
            get { return Parent as ObjBase; }
        }

        #region Implementation of INotifyPropertyChanged

        /// <summary>
        /// Notify name change. (Instead of setting same name to force PropertyChanged, we can use it, mainly use for CellFormatting)
        /// </summary>
        public void NotifyNameChanged()
        {
            NotifyPropertyChanged(() => Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged != null)
            {
                var memberExpression = property.Body as MemberExpression;
                RaisePropertyChanged(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
            }
        }

        protected void RaisePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (PropertyChanged == null)
            {
                return;
            }
            try
            {
                PropertyChanged(sender, e);
            }
            catch (NullReferenceException) { } // To prevent rare case that PropertyChanged become null and pop up 
        }
        #endregion
        
        #region Virtual Methods for Initialize Recurse and Destroy Recurse
        /// <summary>
        /// Override to do thing when initializing
        /// </summary>
        protected virtual void OnInitializeRecurse() { }

        /// <summary>
        /// Override to do thing afer initialize recurse
        /// </summary>
        protected virtual void OnAfterInitializeRecurse() { }

        /// <summary>
        /// verride to do thing when destroy recurse
        /// </summary>
        protected virtual void OnDestroyRecurese() { }

        /// <summary>
        /// Override to do thing before destroy recurse
        /// </summary>
        protected virtual void OnBeforeDestroyRecurse() { }
        #endregion
    }
}
