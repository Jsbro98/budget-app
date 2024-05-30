using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    internal class DropDown : ListBox
    {
        public DropDown() => Categories = new Dictionary<string, int>();

        public Dictionary<string, int> Categories { get; }
    }
}
