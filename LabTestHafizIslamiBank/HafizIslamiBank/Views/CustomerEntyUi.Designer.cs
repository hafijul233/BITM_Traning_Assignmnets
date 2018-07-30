namespace HafizIslamiBank.Views
{
    partial class CustomerEntyUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenigdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenigdateTimePicker);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AccountNumberTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CustomerNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer and  Account Info Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(188, 39);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(300, 26);
            this.CustomerNameTextBox.TabIndex = 1;
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(188, 89);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(300, 26);
            this.EmailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Location = new System.Drawing.Point(188, 138);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(300, 26);
            this.AccountNumberTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opening Date";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(315, 236);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(173, 42);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenigdateTimePicker
            // 
            this.OpenigdateTimePicker.CustomFormat = "yyyy-M-dd";
            this.OpenigdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OpenigdateTimePicker.Location = new System.Drawing.Point(188, 187);
            this.OpenigdateTimePicker.Name = "OpenigdateTimePicker";
            this.OpenigdateTimePicker.Size = new System.Drawing.Size(300, 26);
            this.OpenigdateTimePicker.TabIndex = 9;
            // 
            // CustomerEntyUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerEntyUi";
            this.Text = "Customer Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerEntyUi_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker OpenigdateTimePicker;
    }
}