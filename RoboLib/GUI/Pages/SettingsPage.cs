using ComponentFactory.Krypton.Navigator;
using RoboLib.Extensions;
using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboLib.GUI.Pages
{
    public partial class SettingsPage : ViewPage
    {
        PropertyPageViewModel _item;
        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void DefineBinding(ObjBase objBase)
        {
            base.DefineBinding(objBase);
            treePage.PerformBinding();
            treePage.evAfterSelect += new Action<object>(treePage_evAfterSelect);
        }

        void treePage_evAfterSelect(object obj)
        {
            this.SuspendLayout();
            try
            {
                kNav.Pages.ClearNDisposePages();

                var pages = (obj as ComponentBase).GetPropertyPages();
                foreach (var item in pages)
                {
                    _item = item;
                    if (item.PageType.BaseType != typeof(ViewPage))
                    {
                        throw new RException(string.Format("Auto Property Page supported ViewPage only. Obj [{0}], Page [{1}]", item.Obj.Name, item.PageType));
                    }
                    var view = kNav.Pages.AddPage(((ViewPage)Activator.CreateInstance(_item.PageType)).PerformBinding(_item.Obj), item.PageTitle);
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            treePage.evAfterSelect -= new Action<object>(treePage_evAfterSelect);
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
