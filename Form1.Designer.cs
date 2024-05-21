namespace BudgetApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Entry = new System.Windows.Forms.TextBox();
            this.ExpenseSubmit = new System.Windows.Forms.Button();
            this.UserHistory = new System.Windows.Forms.ListBox();
            this.CategoryBox = new System.Windows.Forms.GroupBox();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.BudgetLimit = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategorySubmit = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CategoryFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CategorySelector = new System.Windows.Forms.ListBox();
            this.ExpenseBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.CategoryBox.SuspendLayout();
            this.ExpenseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Entry
            // 
            this.Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry.Location = new System.Drawing.Point(6, 48);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(171, 22);
            this.Entry.TabIndex = 3;
            // 
            // ExpenseSubmit
            // 
            this.ExpenseSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseSubmit.Location = new System.Drawing.Point(0, 128);
            this.ExpenseSubmit.Name = "ExpenseSubmit";
            this.ExpenseSubmit.Size = new System.Drawing.Size(75, 23);
            this.ExpenseSubmit.TabIndex = 5;
            this.ExpenseSubmit.Text = "Submit";
            this.ExpenseSubmit.UseVisualStyleBackColor = true;
            this.ExpenseSubmit.Click += new System.EventHandler(this.EntrySubmit_Click);
            // 
            // UserHistory
            // 
            this.UserHistory.FormattingEnabled = true;
            this.UserHistory.ItemHeight = 16;
            this.UserHistory.Location = new System.Drawing.Point(232, 34);
            this.UserHistory.Name = "UserHistory";
            this.UserHistory.Size = new System.Drawing.Size(120, 340);
            this.UserHistory.TabIndex = 1;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Controls.Add(this.LimitLabel);
            this.CategoryBox.Controls.Add(this.BudgetLimit);
            this.CategoryBox.Controls.Add(this.NameLabel);
            this.CategoryBox.Controls.Add(this.CategorySubmit);
            this.CategoryBox.Controls.Add(this.CategoryName);
            this.CategoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBox.Location = new System.Drawing.Point(12, 12);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(184, 170);
            this.CategoryBox.TabIndex = 3;
            this.CategoryBox.TabStop = false;
            this.CategoryBox.Text = "Add a category here";
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimitLabel.Location = new System.Drawing.Point(8, 89);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(50, 16);
            this.LimitLabel.TabIndex = 4;
            this.LimitLabel.Text = "Budget";
            // 
            // BudgetLimit
            // 
            this.BudgetLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLimit.Location = new System.Drawing.Point(6, 108);
            this.BudgetLimit.Name = "BudgetLimit";
            this.BudgetLimit.Size = new System.Drawing.Size(169, 22);
            this.BudgetLimit.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(6, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // CategorySubmit
            // 
            this.CategorySubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySubmit.Location = new System.Drawing.Point(6, 136);
            this.CategorySubmit.Name = "CategorySubmit";
            this.CategorySubmit.Size = new System.Drawing.Size(75, 23);
            this.CategorySubmit.TabIndex = 2;
            this.CategorySubmit.Text = "Submit";
            this.CategorySubmit.UseVisualStyleBackColor = true;
            this.CategorySubmit.Click += new System.EventHandler(this.CategorySubmit_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.Location = new System.Drawing.Point(4, 54);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(169, 22);
            this.CategoryName.TabIndex = 0;
            // 
            // CategoryFlowLayout
            // 
            this.CategoryFlowLayout.Location = new System.Drawing.Point(389, 12);
            this.CategoryFlowLayout.Name = "CategoryFlowLayout";
            this.CategoryFlowLayout.Size = new System.Drawing.Size(666, 356);
            this.CategoryFlowLayout.TabIndex = 4;
            // 
            // CategorySelector
            // 
            this.CategorySelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySelector.FormattingEnabled = true;
            this.CategorySelector.ItemHeight = 16;
            this.CategorySelector.Location = new System.Drawing.Point(6, 102);
            this.CategorySelector.Name = "CategorySelector";
            this.CategorySelector.Size = new System.Drawing.Size(120, 20);
            this.CategorySelector.TabIndex = 4;
            // 
            // ExpenseBox
            // 
            this.ExpenseBox.Controls.Add(this.label2);
            this.ExpenseBox.Controls.Add(this.ExpenseSubmit);
            this.ExpenseBox.Controls.Add(this.label1);
            this.ExpenseBox.Controls.Add(this.CategorySelector);
            this.ExpenseBox.Controls.Add(this.Entry);
            this.ExpenseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseBox.Location = new System.Drawing.Point(12, 217);
            this.ExpenseBox.Name = "ExpenseBox";
            this.ExpenseBox.Size = new System.Drawing.Size(184, 157);
            this.ExpenseBox.TabIndex = 6;
            this.ExpenseBox.TabStop = false;
            this.ExpenseBox.Text = "Add an expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(229, 12);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(123, 16);
            this.HistoryLabel.TabIndex = 7;
            this.HistoryLabel.Text = "Transaction History";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 395);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.ExpenseBox);
            this.Controls.Add(this.CategoryFlowLayout);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.UserHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "BudgetApp";
            this.CategoryBox.ResumeLayout(false);
            this.CategoryBox.PerformLayout();
            this.ExpenseBox.ResumeLayout(false);
            this.ExpenseBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.Button ExpenseSubmit;
        private System.Windows.Forms.ListBox UserHistory;
        private System.Windows.Forms.GroupBox CategoryBox;
        private System.Windows.Forms.Button CategorySubmit;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.TextBox BudgetLimit;
        private System.Windows.Forms.ListBox CategorySelector;
        private System.Windows.Forms.GroupBox ExpenseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HistoryLabel;
    }
}

