using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp
{
    internal class CustomFlowPanelEntries : FlowLayoutPanel
    {
        public CustomFlowPanelEntries() => Entries = new Dictionary<string, CustomLayoutEntry>();

        public Dictionary<string, CustomLayoutEntry> Entries { get; }
    }
}
