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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ExpenseEntry = new System.Windows.Forms.TextBox();
            this.ExpenseSubmit = new System.Windows.Forms.Button();
            this.UserHistory = new System.Windows.Forms.ListBox();
            this.CategoryBox = new System.Windows.Forms.GroupBox();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.BudgetLimit = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategorySubmit = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.ExpenseBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.CategoryDeleteBox = new System.Windows.Forms.GroupBox();
            this.DeleteListBox = new System.Windows.Forms.ListBox();
            this.CategoryDeleteLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DepositBox = new System.Windows.Forms.GroupBox();
            this.DepositListBoxLabel = new System.Windows.Forms.Label();
            this.DepositListBox = new System.Windows.Forms.ListBox();
            this.DepositEntry = new System.Windows.Forms.TextBox();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.DepositSubmit = new System.Windows.Forms.Button();
            this.ExpenseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryInfoPic = new System.Windows.Forms.PictureBox();
            this.DepositInfoPic = new System.Windows.Forms.PictureBox();
            this.DeleteInfoPic = new System.Windows.Forms.PictureBox();
            this.DepositToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryFlowLayout = new BudgetApp.CustomFlowPanelEntries();
            this.CategoryBox.SuspendLayout();
            this.ExpenseBox.SuspendLayout();
            this.CategoryDeleteBox.SuspendLayout();
            this.DepositBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryInfoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositInfoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteInfoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpenseEntry
            // 
            this.ExpenseEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseEntry.Location = new System.Drawing.Point(6, 48);
            this.ExpenseEntry.Name = "ExpenseEntry";
            this.ExpenseEntry.Size = new System.Drawing.Size(171, 22);
            this.ExpenseEntry.TabIndex = 3;
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
            this.ExpenseSubmit.Click += new System.EventHandler(this.ExpenseSubmit_Click);
            // 
            // UserHistory
            // 
            this.UserHistory.FormattingEnabled = true;
            this.UserHistory.ItemHeight = 16;
            this.UserHistory.Location = new System.Drawing.Point(430, 27);
            this.UserHistory.Name = "UserHistory";
            this.UserHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UserHistory.Size = new System.Drawing.Size(138, 356);
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
            this.CategoryBox.Text = "Add a category";
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
            // ExpenseBox
            // 
            this.ExpenseBox.Controls.Add(this.CategoryInfoPic);
            this.ExpenseBox.Controls.Add(this.label2);
            this.ExpenseBox.Controls.Add(this.ExpenseSubmit);
            this.ExpenseBox.Controls.Add(this.label1);
            this.ExpenseBox.Controls.Add(this.CategoryListBox);
            this.ExpenseBox.Controls.Add(this.ExpenseEntry);
            this.ExpenseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseBox.Location = new System.Drawing.Point(12, 226);
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
            // CategoryListBox
            // 
            this.CategoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 16;
            this.CategoryListBox.Location = new System.Drawing.Point(6, 102);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(120, 20);
            this.CategoryListBox.TabIndex = 4;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(430, 8);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(123, 16);
            this.HistoryLabel.TabIndex = 7;
            this.HistoryLabel.Text = "Transaction History";
            // 
            // CategoryDeleteBox
            // 
            this.CategoryDeleteBox.Controls.Add(this.DeleteInfoPic);
            this.CategoryDeleteBox.Controls.Add(this.DeleteListBox);
            this.CategoryDeleteBox.Controls.Add(this.CategoryDeleteLabel);
            this.CategoryDeleteBox.Controls.Add(this.DeleteButton);
            this.CategoryDeleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDeleteBox.Location = new System.Drawing.Point(224, 12);
            this.CategoryDeleteBox.Name = "CategoryDeleteBox";
            this.CategoryDeleteBox.Size = new System.Drawing.Size(200, 170);
            this.CategoryDeleteBox.TabIndex = 8;
            this.CategoryDeleteBox.TabStop = false;
            this.CategoryDeleteBox.Text = "Delete a category";
            // 
            // DeleteListBox
            // 
            this.DeleteListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteListBox.FormattingEnabled = true;
            this.DeleteListBox.ItemHeight = 16;
            this.DeleteListBox.Location = new System.Drawing.Point(6, 56);
            this.DeleteListBox.Name = "DeleteListBox";
            this.DeleteListBox.Size = new System.Drawing.Size(120, 20);
            this.DeleteListBox.TabIndex = 5;
            // 
            // CategoryDeleteLabel
            // 
            this.CategoryDeleteLabel.AutoSize = true;
            this.CategoryDeleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryDeleteLabel.Location = new System.Drawing.Point(6, 35);
            this.CategoryDeleteLabel.Name = "CategoryDeleteLabel";
            this.CategoryDeleteLabel.Size = new System.Drawing.Size(62, 16);
            this.CategoryDeleteLabel.TabIndex = 1;
            this.CategoryDeleteLabel.Text = "Category";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(6, 136);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DepositBox
            // 
            this.DepositBox.Controls.Add(this.DepositInfoPic);
            this.DepositBox.Controls.Add(this.DepositListBoxLabel);
            this.DepositBox.Controls.Add(this.DepositListBox);
            this.DepositBox.Controls.Add(this.DepositEntry);
            this.DepositBox.Controls.Add(this.DepositLabel);
            this.DepositBox.Controls.Add(this.DepositSubmit);
            this.DepositBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBox.Location = new System.Drawing.Point(224, 226);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(200, 157);
            this.DepositBox.TabIndex = 9;
            this.DepositBox.TabStop = false;
            this.DepositBox.Text = "Deposit funds";
            // 
            // DepositListBoxLabel
            // 
            this.DepositListBoxLabel.AutoSize = true;
            this.DepositListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositListBoxLabel.Location = new System.Drawing.Point(6, 83);
            this.DepositListBoxLabel.Name = "DepositListBoxLabel";
            this.DepositListBoxLabel.Size = new System.Drawing.Size(62, 16);
            this.DepositListBoxLabel.TabIndex = 5;
            this.DepositListBoxLabel.Text = "Category";
            // 
            // DepositListBox
            // 
            this.DepositListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositListBox.FormattingEnabled = true;
            this.DepositListBox.ItemHeight = 16;
            this.DepositListBox.Location = new System.Drawing.Point(6, 102);
            this.DepositListBox.Name = "DepositListBox";
            this.DepositListBox.Size = new System.Drawing.Size(120, 20);
            this.DepositListBox.TabIndex = 6;
            // 
            // DepositEntry
            // 
            this.DepositEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositEntry.Location = new System.Drawing.Point(6, 48);
            this.DepositEntry.Name = "DepositEntry";
            this.DepositEntry.Size = new System.Drawing.Size(171, 22);
            this.DepositEntry.TabIndex = 4;
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositLabel.Location = new System.Drawing.Point(6, 29);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(52, 16);
            this.DepositLabel.TabIndex = 1;
            this.DepositLabel.Text = "Amount";
            // 
            // DepositSubmit
            // 
            this.DepositSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositSubmit.Location = new System.Drawing.Point(6, 128);
            this.DepositSubmit.Name = "DepositSubmit";
            this.DepositSubmit.Size = new System.Drawing.Size(75, 23);
            this.DepositSubmit.TabIndex = 0;
            this.DepositSubmit.Text = "Submit";
            this.DepositSubmit.UseVisualStyleBackColor = true;
            this.DepositSubmit.Click += new System.EventHandler(this.DepositSubmit_Click);
            // 
            // ExpenseToolTip
            // 
            this.ExpenseToolTip.ShowAlways = true;
            this.ExpenseToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExpenseToolTip.ToolTipTitle = "Select a category";
            // 
            // CategoryInfoPic
            // 
            this.CategoryInfoPic.Image = ((System.Drawing.Image)(resources.GetObject("CategoryInfoPic.Image")));
            this.CategoryInfoPic.Location = new System.Drawing.Point(133, 102);
            this.CategoryInfoPic.Name = "CategoryInfoPic";
            this.CategoryInfoPic.Size = new System.Drawing.Size(19, 20);
            this.CategoryInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryInfoPic.TabIndex = 6;
            this.CategoryInfoPic.TabStop = false;
            this.ExpenseToolTip.SetToolTip(this.CategoryInfoPic, "Please click on a category to allow expense");
            // 
            // DepositInfoPic
            // 
            this.DepositInfoPic.Image = ((System.Drawing.Image)(resources.GetObject("DepositInfoPic.Image")));
            this.DepositInfoPic.Location = new System.Drawing.Point(132, 102);
            this.DepositInfoPic.Name = "DepositInfoPic";
            this.DepositInfoPic.Size = new System.Drawing.Size(19, 20);
            this.DepositInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DepositInfoPic.TabIndex = 7;
            this.DepositInfoPic.TabStop = false;
            this.DepositToolTip.SetToolTip(this.DepositInfoPic, "Please click on a category to allow deposit");
            // 
            // DeleteInfoPic
            // 
            this.DeleteInfoPic.Image = ((System.Drawing.Image)(resources.GetObject("DeleteInfoPic.Image")));
            this.DeleteInfoPic.Location = new System.Drawing.Point(132, 56);
            this.DeleteInfoPic.Name = "DeleteInfoPic";
            this.DeleteInfoPic.Size = new System.Drawing.Size(19, 20);
            this.DeleteInfoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteInfoPic.TabIndex = 7;
            this.DeleteInfoPic.TabStop = false;
            this.DeleteToolTip.SetToolTip(this.DeleteInfoPic, "Please click a category allow deletion");
            // 
            // DepositToolTip
            // 
            this.DepositToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DepositToolTip.ToolTipTitle = "Select a category";
            // 
            // DeleteToolTip
            // 
            this.DeleteToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DeleteToolTip.ToolTipTitle = "Select a category";
            // 
            // CategoryFlowLayout
            // 
            this.CategoryFlowLayout.Location = new System.Drawing.Point(574, 12);
            this.CategoryFlowLayout.Name = "CategoryFlowLayout";
            this.CategoryFlowLayout.Size = new System.Drawing.Size(666, 372);
            this.CategoryFlowLayout.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 395);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.CategoryDeleteBox);
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
            this.CategoryDeleteBox.ResumeLayout(false);
            this.CategoryDeleteBox.PerformLayout();
            this.DepositBox.ResumeLayout(false);
            this.DepositBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryInfoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositInfoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteInfoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ExpenseEntry;
        private System.Windows.Forms.Button ExpenseSubmit;
        private System.Windows.Forms.ListBox UserHistory;
        private System.Windows.Forms.GroupBox CategoryBox;
        private System.Windows.Forms.Button CategorySubmit;
        private System.Windows.Forms.TextBox CategoryName;
        private CustomFlowPanelEntries CategoryFlowLayout;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.TextBox BudgetLimit;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.GroupBox ExpenseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.GroupBox CategoryDeleteBox;
        private System.Windows.Forms.GroupBox DepositBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DepositSubmit;
        private System.Windows.Forms.ListBox DeleteListBox;
        private System.Windows.Forms.Label CategoryDeleteLabel;
        private System.Windows.Forms.TextBox DepositEntry;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.Label DepositListBoxLabel;
        private System.Windows.Forms.ListBox DepositListBox;
        private System.Windows.Forms.ToolTip ExpenseToolTip;
        private System.Windows.Forms.PictureBox CategoryInfoPic;
        private System.Windows.Forms.PictureBox DeleteInfoPic;
        private System.Windows.Forms.PictureBox DepositInfoPic;
        private System.Windows.Forms.ToolTip DepositToolTip;
        private System.Windows.Forms.ToolTip DeleteToolTip;
    }
}

