using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class MainWindow : Form
    {
        // TODO create LogManager class to handle all logging to UserHistory
        // TODO add functionality to delete, deposit, and expense buttons
        //  - possibly create undo class to handle this ^^
        // TODO create functionality to save categories
        /* TODO on window close, upload all transaction history
         * for the session into a .txt file
         */
        

        private readonly Dictionary<string, int> Categories = new Dictionary<string, int>();
        public MainWindow()
        {
            InitializeComponent();
            AddAllTabEvents();
        }

        private void ExpenseSubmit_Click(object sender, EventArgs e)
        {
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

            string categoryName = GetListBoxCategory(CategoryListBox);

            if (categoryName is null || categoryName.Count() > 20)
            {
                return;
            }

            Control amount = CategoryFlowLayout.Entries[categoryName].AddedControls["Amount"];


            Categories[categoryName] -= amountDeducted;

            amount.Text = Categories[categoryName].ToString();

            LogExpense(categoryName);
        }

        private void CategorySubmit_Click(object sender, EventArgs e)
        {
            if (Categories.Count == 30) return;

            CustomLayoutEntry category = CreateCategory();

            string labelText = CategoryName.Text;
            string amount = BudgetLimit.Text;

            try
            {
                AddCategory(labelText, int.Parse(amount));
                CategoryFlowLayout.Entries.Add(labelText, category);
                CategoryFlowLayout.Controls.Add(category);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            UserHistory.Items.Add($"{labelText} Added With\t{amount}");
            UserHistory.Items.Add("");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string key = GetListBoxCategory(DeleteListBox);

            if (key is null) return;

            Control category = CategoryFlowLayout.Entries[key];

            RemoveCategory(key);
            CategoryFlowLayout.Controls.Remove(category);
            CategoryFlowLayout.Entries.Remove(key);

            UserHistory.Items.Add($"{key}\tDeleted");
            UserHistory.Items.Add("");
        }

        private void DepositSubmit_Click(object sender, EventArgs e)
        {
            int amountDeducted;

            try
            {
                amountDeducted = int.Parse(DepositEntry.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string categoryName = GetListBoxCategory(DepositListBox);

            if (categoryName is null) return;

            Control amount = CategoryFlowLayout.Entries[categoryName].AddedControls["Amount"];

            Categories[categoryName] += amountDeducted;

            amount.Text = Categories[categoryName].ToString();

            // check if description is entered, if so, add it to UserHistory
            if (!string.IsNullOrEmpty(DepositDescription.Text))
            {
                UserHistory.Items.Add($"{categoryName}\t+{DepositEntry.Text}");
                UserHistory.Items.Add($"Description: {DepositDescription.Text}\n");
                UserHistory.Items.Add("");
            }
            else
            {
                UserHistory.Items.Add($"{categoryName}\t+{DepositEntry.Text}\n");
                UserHistory.Items.Add("");
            }
        }

        private void ExpenseUndo_Click(object sender, EventArgs e)
        {

        }

        private void CategoryUndo_Click(object sender, EventArgs e)
        {
            UndoCategory(CategoryListBox);
        }



        // -----------private methods for helping events-----------

        private void LogExpense(string categoryName)
        {
            // check if description is entered, if so, add it to UserHistory
            if (!string.IsNullOrEmpty(ExpenseDescription.Text))
            {
                UserHistory.Items.Add($"{categoryName}\t-{ExpenseEntry.Text}");
                UserHistory.Items.Add($"Description: {ExpenseDescription.Text}");
                UserHistory.Items.Add("");
            }
            else
            {
                UserHistory.Items.Add($"{categoryName}\t-{ExpenseEntry.Text}");
                UserHistory.Items.Add("");
            }
        }

        private CustomLayoutEntry CreateCategory()
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

            return category;
        }

        private void UndoCategory(ListBox lb)
        {
            try
            {
                lb.SelectedItem = lb.Items[lb.Items.Count - 1];
                Console.WriteLine($"Selected Item: {lb.SelectedItem}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string key = lb.SelectedItem.ToString();
            int index = UserHistory.Items.Count - 1;

            CustomLayoutEntry category = CategoryFlowLayout.Entries[key];

            RemoveCategory(key);
            CategoryFlowLayout.Controls.Remove(category);
            CategoryFlowLayout.Entries.Remove(key);

            // remove the transaction and the whitespace
            UserHistory.Items.RemoveAt(index);
            UserHistory.Items.RemoveAt(index - 1);
        }

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

        private string GetListBoxCategory(ListBox lb)
        {
            if (lb.SelectedItem is null)
            {
                switch (lb)
                {
                    // using "case var value when value" hack to allow switching
                    case var value when value == CategoryListBox:
                        ExpenseToolTip.Show("Please click on a category to allow expense", CategoryListBox, 4500);
                        break;

                    case var value when value == DeleteListBox:
                        DeleteToolTip.Show("Please click on a category to allow deletion", DeleteListBox, 4500);
                        break;

                    case var value when value == DepositListBox:
                        DepositToolTip.Show("Please click on a category to allow deposit", DepositListBox, 4500);
                        break;
                }

                return null;
            }
            else
            {
                return lb.SelectedItem.ToString();
            }
        }

        private void AddEnterTabEvent(Control component)
        {
            void keyPressEvent(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r')
                {
                    Console.WriteLine(SelectNextControl((Control)sender, true, true, true, true));
                }
            }

            component.KeyPress += new KeyPressEventHandler((Action<object, KeyPressEventArgs>)keyPressEvent);
        }

        private void AddAllTabEvents()
        {
            Control[] controls = new Control[] {
                CategoryName,
                BudgetLimit,
                ExpenseEntry,
                ExpenseDescription,
                DepositEntry,
                DepositDescription,
            };

            foreach (Control control in controls)
            {
                AddEnterTabEvent(control);
            }
        }

    }
}