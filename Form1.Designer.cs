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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.entry = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.userHistory = new System.Windows.Forms.ListBox();
            this.entryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.GroupBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categorySubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.categoryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.entry);
            this.flowLayoutPanel1.Controls.Add(this.submitButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // entry
            // 
            this.entry.AcceptsReturn = true;
            this.entry.Location = new System.Drawing.Point(3, 3);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(171, 22);
            this.entry.TabIndex = 0;
            this.entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entry_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(3, 31);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // userHistory
            // 
            this.userHistory.FormattingEnabled = true;
            this.userHistory.ItemHeight = 16;
            this.userHistory.Location = new System.Drawing.Point(233, 12);
            this.userHistory.Name = "userHistory";
            this.userHistory.Size = new System.Drawing.Size(120, 308);
            this.userHistory.TabIndex = 1;
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.Location = new System.Drawing.Point(9, 12);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(167, 16);
            this.entryLabel.TabIndex = 2;
            this.entryLabel.Text = "Please enter your expense";
            // 
            // categoryBox
            // 
            this.categoryBox.Controls.Add(this.categorySubmit);
            this.categoryBox.Controls.Add(this.categoryTextBox);
            this.categoryBox.Location = new System.Drawing.Point(12, 161);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(184, 100);
            this.categoryBox.TabIndex = 3;
            this.categoryBox.TabStop = false;
            this.categoryBox.Text = "Add a category here";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(4, 32);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(169, 22);
            this.categoryTextBox.TabIndex = 0;
            // 
            // categorySubmit
            // 
            this.categorySubmit.Location = new System.Drawing.Point(6, 71);
            this.categorySubmit.Name = "categorySubmit";
            this.categorySubmit.Size = new System.Drawing.Size(75, 23);
            this.categorySubmit.TabIndex = 1;
            this.categorySubmit.Text = "Submit";
            this.categorySubmit.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.userHistory);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox entry;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox userHistory;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.GroupBox categoryBox;
        private System.Windows.Forms.Button categorySubmit;
        private System.Windows.Forms.TextBox categoryTextBox;
    }
}

