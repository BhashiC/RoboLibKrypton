using RoboLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboLib.GUI.Controls
{
    public interface IControlBindingList
    {
        BindingSource DataSource { get; set; }

        event Action<ObjBase> UserAddedItem;

        event Action<ObjBase> UserRemovedItem;

        event Action<ObjBase, string> UserEditedItem;

        event Action UserResetList;

        void OnItemAdded(ObjBase item);

        void OnItemRemoving(ObjBase item, int index);

        void OnItemEdited(ObjBase item, string propertyName);

        void OnListReset();

        void OnItemMoved(int oldIndex, int newIndex);

        void DrawingEnable(bool enable);
    }
}
