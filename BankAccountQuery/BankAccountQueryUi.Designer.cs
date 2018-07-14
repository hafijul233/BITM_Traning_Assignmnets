namespace _01BankAccountQuery
{
    partial class BankAccountQueryUi
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
            this.AccountNoTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateButton);
            this.groupBox1.Controls.Add(this.CustomerNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AccountNoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // AccountNoTextBox
            // 
            this.AccountNoTextBox.Location = new System.Drawing.Point(205, 60);
            this.AccountNoTextBox.Name = "AccountNoTextBox";
            this.AccountNoTextBox.Size = new System.Drawing.Size(358, 30);
            this.AccountNoTextBox.TabIndex = 1;
            this.AccountNoTextBox.TextChanged += new System.EventHandler(this.AccountNoTextBox_TextChanged);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(205, 119);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(358, 30);
            this.CustomerNameTextBox.TabIndex = 3;
            this.CustomerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(399, 169);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(164, 54);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WithdrawButton);
            this.groupBox2.Controls.Add(this.DepositButton);
            this.groupBox2.Controls.Add(this.AmountTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Form";
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(127, 112);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(164, 54);
            this.DepositButton.TabIndex = 4;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(166, 47);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(316, 30);
            this.AmountTextBox.TabIndex = 1;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(333, 112);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(164, 54);
            this.WithdrawButton.TabIndex = 5;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(140, 497);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(370, 54);
            this.ReportButton.TabIndex = 6;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // BankAccountQueryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 572);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankAccountQueryUi";
            this.Text = "Bank Account Operation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AccountNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReportButton;
    }
}

