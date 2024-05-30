using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    internal class CustomLayoutEntry : FlowLayoutPanel
    {
        public CustomLayoutEntry() => AddedControls = new Dictionary<string, Control>();

        public Dictionary<string, Control> AddedControls { get; }
    }
}
