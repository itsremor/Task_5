namespace Task_5
{
    partial class Form1
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NeurosurgeonsListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // FullNameTextBox
            //
            this.FullNameTextBox.Location = new System.Drawing.Point(258, 25);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.FullNameTextBox.TabIndex = 7;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            //
            // AddButton
            //
            this.AddButton.Location = new System.Drawing.Point(284, 64);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            //
            // NeurosurgeonsListBox
            //
            this.NeurosurgeonsListBox.FormattingEnabled = true;
            this.NeurosurgeonsListBox.ItemHeight = 16;
            this.NeurosurgeonsListBox.Location = new System.Drawing.Point(71, 103);
            this.NeurosurgeonsListBox.Name = "NeurosurgeonsListBox";
            this.NeurosurgeonsListBox.Size = new System.Drawing.Size(509, 180);
            this.NeurosurgeonsListBox.TabIndex = 11;
            //
            // RemoveButton
            //
            this.RemoveButton.Location = new System.Drawing.Point(284, 318);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            //
            // FullNameLabel
            //
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(179, 28);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(73, 17);
            this.FullNameLabel.TabIndex = 13;
            this.FullNameLabel.Text = "Full name:";
            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(653, 391);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.NeurosurgeonsListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FullNameTextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label FullNameLabel;

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox NeurosurgeonsListBox;

        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Button RemoveButton;

        #endregion
    }
}
