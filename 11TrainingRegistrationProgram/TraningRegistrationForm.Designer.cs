namespace TrainingRegistrationApp
{
    partial class TraningRegistrationForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationTabPage = new System.Windows.Forms.TabPage();
            this.ShowInfotabPage = new System.Windows.Forms.TabPage();
            this.RegiatrationFormTabControl = new System.Windows.Forms.TabControl();
            this.ReportTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.RegistrationTabPage.SuspendLayout();
            this.RegiatrationFormTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.RegiatrationFormTabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.88525F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training Registration Program";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationTabPage
            // 
            this.RegistrationTabPage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RegistrationTabPage.Controls.Add(this.button2);
            this.RegistrationTabPage.Controls.Add(this.button1);
            this.RegistrationTabPage.Controls.Add(this.label7);
            this.RegistrationTabPage.Controls.Add(this.label6);
            this.RegistrationTabPage.Controls.Add(this.comboBox3);
            this.RegistrationTabPage.Controls.Add(this.label5);
            this.RegistrationTabPage.Controls.Add(this.comboBox2);
            this.RegistrationTabPage.Controls.Add(this.label4);
            this.RegistrationTabPage.Controls.Add(this.comboBox1);
            this.RegistrationTabPage.Controls.Add(this.label3);
            this.RegistrationTabPage.Controls.Add(this.textBox1);
            this.RegistrationTabPage.Controls.Add(this.label2);
            this.RegistrationTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationTabPage.Location = new System.Drawing.Point(4, 34);
            this.RegistrationTabPage.Name = "RegistrationTabPage";
            this.RegistrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationTabPage.Size = new System.Drawing.Size(806, 540);
            this.RegistrationTabPage.TabIndex = 0;
            this.RegistrationTabPage.Text = "Registration Form";
            // 
            // ShowInfotabPage
            // 
            this.ShowInfotabPage.BackColor = System.Drawing.SystemColors.Info;
            this.ShowInfotabPage.Location = new System.Drawing.Point(4, 34);
            this.ShowInfotabPage.Name = "ShowInfotabPage";
            this.ShowInfotabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInfotabPage.Size = new System.Drawing.Size(806, 540);
            this.ShowInfotabPage.TabIndex = 1;
            this.ShowInfotabPage.Text = "Registrated Candidate List";
            // 
            // RegiatrationFormTabControl
            // 
            this.RegiatrationFormTabControl.Controls.Add(this.RegistrationTabPage);
            this.RegiatrationFormTabControl.Controls.Add(this.ShowInfotabPage);
            this.RegiatrationFormTabControl.Controls.Add(this.ReportTabPage);
            this.RegiatrationFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegiatrationFormTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiatrationFormTabControl.Location = new System.Drawing.Point(3, 90);
            this.RegiatrationFormTabControl.Multiline = true;
            this.RegiatrationFormTabControl.Name = "RegiatrationFormTabControl";
            this.RegiatrationFormTabControl.SelectedIndex = 0;
            this.RegiatrationFormTabControl.Size = new System.Drawing.Size(814, 578);
            this.RegiatrationFormTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.RegiatrationFormTabControl.TabIndex = 1;
            // 
            // ReportTabPage
            // 
            this.ReportTabPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReportTabPage.Location = new System.Drawing.Point(4, 34);
            this.ReportTabPage.Name = "ReportTabPage";
            this.ReportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTabPage.Size = new System.Drawing.Size(806, 540);
            this.ReportTabPage.TabIndex = 2;
            this.ReportTabPage.Text = "Status Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Candidate Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(239, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Institute Name: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(537, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Available Courses";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(537, 33);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(239, 197);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(537, 33);
            this.comboBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Courses Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Courses Costing";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(542, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 81);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightYellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(433, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 81);
            this.button2.TabIndex = 11;
            this.button2.Text = "Get Receipt";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TraningRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TraningRegistrationForm";
            this.Text = "Training Registration Booth ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.RegistrationTabPage.ResumeLayout(false);
            this.RegistrationTabPage.PerformLayout();
            this.RegiatrationFormTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl RegiatrationFormTabControl;
        private System.Windows.Forms.TabPage RegistrationTabPage;
        private System.Windows.Forms.TabPage ShowInfotabPage;
        private System.Windows.Forms.TabPage ReportTabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
    }
}

