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
            this.laptopListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.screenDiagonalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // laptopListBox
            //
            this.laptopListBox.FormattingEnabled = true;
            this.laptopListBox.ItemHeight = 16;
            this.laptopListBox.Location = new System.Drawing.Point(132, 187);
            this.laptopListBox.Name = "laptopListBox";
            this.laptopListBox.Size = new System.Drawing.Size(509, 180);
            this.laptopListBox.TabIndex = 0;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titlle:";
            //
            // titleTextBox
            //
            this.titleTextBox.Location = new System.Drawing.Point(310, 40);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(190, 22);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            //
            // screenDiagonalTextBox
            //
            this.screenDiagonalTextBox.Location = new System.Drawing.Point(310, 91);
            this.screenDiagonalTextBox.Name = "screenDiagonalTextBox";
            this.screenDiagonalTextBox.Size = new System.Drawing.Size(190, 22);
            this.screenDiagonalTextBox.TabIndex = 8;
            this.screenDiagonalTextBox.TextChanged += new System.EventHandler(this.screenDiagonalTextBox_TextChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Screen diagonal:";
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(346, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(333, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.screenDiagonalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laptopListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox titleTextBox;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox screenDiagonalTextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox laptopListBox;

        #endregion
    }
}
