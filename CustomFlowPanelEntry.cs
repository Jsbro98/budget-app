using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    internal class CustomFlowPanelEntries : FlowLayoutPanel
    {
        public CustomFlowPanelEntries() => Entries = new Dictionary<string, CustomLayoutEntry>();

        public Dictionary<string, CustomLayoutEntry> Entries { get; }
    }
}
