using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntrySubmit_Click(object sender, EventArgs e)
        {
            UserHistory.Items.Add(Entry.Text);
        }

        private void CategorySubmit_Click(object sender, EventArgs e)
        {
            var category = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Size = new Size(100, 100),
            };

            var label = new Label
            {
                Text = CategoryName.Text
            };

            var progressBar = new ProgressBar
            {
                Maximum = int.Parse(BudgetLimit.Text),
                Visible = true,
                Size = new Size(60, 25),
            };

            category.Controls.Add(label);
            category.Controls.Add(progressBar);

            CategoryFlowLayout.Controls.Add(category);
        }
    }
}
