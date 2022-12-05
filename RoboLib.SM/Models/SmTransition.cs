using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboLib.SM.Models
{
    public class SmTransition : SmObjBase
    {
        public string StartShapeName { get; set; }
        public string EndShapeName { get; set; }
        public int StartCellColNum { get; set; }
        public int StartCellRowNum { get; set; }
        public int EndCellColNum { get; set; }
        public int EndCellRowNum { get; set; }

        public SmCondition Condition { get; set; }

        public SmTransition()
        {
        }
    }
}
