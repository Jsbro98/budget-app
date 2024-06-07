using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class MainWindow : Form
    {
        private int _categoryCounter = 0;
        private readonly Dictionary<string, int> Categories = new Dictionary<string, int>();
        public MainWindow()
        {
            InitializeComponent();

            // adding \r KeyPress events
            AddEnterSubmitEvent(BudgetLimit, CategorySubmit_Click);
            AddEnterSubmitEvent(ExpenseEntry, ExpenseSubmit_Click);
        }

        private void ExpenseSubmit_Click(object sender, EventArgs e)
        {
            int categorycount = Categories.Count;

            if (categorycount == 0) { return; }

            if (categorycount == 1)
            {
                CategoryListBox.SelectedItem = Categories.First().Key;
            }

            int amountDeducted;

            try
            {
                amountDeducted = int.Parse(ExpenseEntry.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


            if (amountDeducted <= 0) { return; }

            string categoryName = CategoryListBox.SelectedItem.ToString();

            if (categoryName.Count() > 20)
            {
                return;
            }

            Control amount = CategoryFlowLayout.Entries[categoryName].AddedControls["Amount"];


            Categories[categoryName] -= amountDeducted;

            amount.Text = Categories[categoryName].ToString();

            UserHistory.Items.Add($"{categoryName}   -{ExpenseEntry.Text}");
        }

        private void CategorySubmit_Click(object sender, EventArgs e)
        {
            var category = new CustomLayoutEntry
            {
                FlowDirection = FlowDirection.TopDown,
                Size = new Size(75, 60),
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

            try
            {
                AddCategory(label.Text, int.Parse(amountLabel.Text));
                CategoryFlowLayout.Entries.Add(label.Text, category);
                CategoryFlowLayout.Controls.Add(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteListBox.SelectedItem is null)
            {
                return;
            }

            string key = DeleteListBox.SelectedItem.ToString();
            Control category = CategoryFlowLayout.Entries[key];

            RemoveCategory(key);
            CategoryFlowLayout.Controls.Remove(category);
            CategoryFlowLayout.Entries.Remove(key);
        }

        private void DepositSubmit_Click(object sender, EventArgs e)
        {
            // TODO make a method to simplify DepositSubmit and ExpenseSubmit
            string categoryName;
            int amountDeducted;

            try
            {
                categoryName = DepositListBox.SelectedItem.ToString();
                amountDeducted = int.Parse(DepositEntry.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Control amount = CategoryFlowLayout.Entries[categoryName].AddedControls["Amount"];

            Categories[categoryName] += amountDeducted;

            amount.Text = Categories[categoryName].ToString();

            UserHistory.Items.Add($"{categoryName}   +{DepositEntry.Text}");
        }


        // -----------private methods for helping events-----------

        private void AddCategory(string name, int value)
        {
            if (Categories.ContainsKey(name))
            {
                return;
            }

            Categories.Add(name, value);
            CategoryListBox.Items.Add(name);
            DeleteListBox.Items.Add(name);
            DepositListBox.Items.Add(name);
        }

        private void RemoveCategory(string name)
        {
            Categories.Remove(name);
            CategoryListBox.Items.Remove(name);
            DeleteListBox.Items.Remove(name);
            DepositListBox.Items.Remove(name);
        }

        private void AddEnterSubmitEvent(Control component, Action<object, KeyPressEventArgs> callback)
        {
            void keyPressEvent(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r')
                {
                    callback(sender, e);
                }
            }

            component.KeyPress += new KeyPressEventHandler((Action<object, KeyPressEventArgs>)keyPressEvent);
        }
    }
}
