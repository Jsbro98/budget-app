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
        private int _categoryCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EntrySubmit_Click(object sender, EventArgs e)
        {
            int categorycount = CategorySelector.Categories.Count;

            if (categorycount == 0) { return; }

            if (categorycount == 1)
            {
                CategorySelector.SelectedItem = CategorySelector.Categories.First().Key;
            }

            string categoryName = CategorySelector.SelectedItem.ToString();
            int amountDeducted = int.Parse(Entry.Text);
            Control amount = CategoryFlowLayout.Entries[categoryName].AddedControls["Amount"];


            CategorySelector.Categories[categoryName] -= amountDeducted;

            amount.Text = CategorySelector.Categories[categoryName].ToString();

            UserHistory.Items.Add(Entry.Text);
        }

        private void CategorySubmit_Click(object sender, EventArgs e)
        {
            var category = new CustomLayoutEntry
            {
                FlowDirection = FlowDirection.TopDown,
                Size = new Size(65, 60),
            };

            var label = new Label
            {
                Text = CategoryName.Text,
            };

            var amountLabel = new Label
            {
                Text = BudgetLimit.Text,
            };

            category.Controls.Add(label);
            category.Controls.Add(amountLabel);
            category.AddedControls.Add(label.Text, label);
            category.AddedControls.Add("Amount", amountLabel);

            AddCategory(label.Text, int.Parse(amountLabel.Text));

            CategoryFlowLayout.Controls.Add(category);
            CategoryFlowLayout.Entries.Add(label.Text, category);
        }



        private void AddCategory(string name, int value)
        {
            CategorySelector.Items.Add(name);
            CategorySelector.Categories.Add(name, value);
        }

        private void BudgetLimit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
