using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmStateBase : SmObjBase
    {
        public int ColumnOnGrid { get; set; }
        public int RowOnGrid { get; set; }

        List<SmMethod> Methods { get; set; }

        public SmStateBase()
        {
            Methods = new List<SmMethod>();
        }
    }
}
