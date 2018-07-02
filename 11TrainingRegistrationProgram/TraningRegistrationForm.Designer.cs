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
            this.CandidateNametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InstituteNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AvaliableCourseComboBox = new System.Windows.Forms.ComboBox();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.candidateDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.RegistrationTabPage.SuspendLayout();
            this.ShowInfotabPage.SuspendLayout();
            this.RegiatrationFormTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).BeginInit();
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
            this.RegistrationTabPage.Controls.Add(this.label7);
            this.RegistrationTabPage.Controls.Add(this.receiptButton);
            this.RegistrationTabPage.Controls.Add(this.RegisterButton);
            this.RegistrationTabPage.Controls.Add(this.CostLabel);
            this.RegistrationTabPage.Controls.Add(this.label6);
            this.RegistrationTabPage.Controls.Add(this.DurationComboBox);
            this.RegistrationTabPage.Controls.Add(this.label5);
            this.RegistrationTabPage.Controls.Add(this.AvaliableCourseComboBox);
            this.RegistrationTabPage.Controls.Add(this.label4);
            this.RegistrationTabPage.Controls.Add(this.InstituteNamecomboBox);
            this.RegistrationTabPage.Controls.Add(this.label3);
            this.RegistrationTabPage.Controls.Add(this.CandidateNametextBox);
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
            this.ShowInfotabPage.Controls.Add(this.candidateDataGridView);
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
            this.RegiatrationFormTabControl.Click += new System.EventHandler(this.RegiatrationFormTabControl_Click);
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
            // CandidateNametextBox
            // 
            this.CandidateNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateNametextBox.Location = new System.Drawing.Point(239, 15);
            this.CandidateNametextBox.Name = "CandidateNametextBox";
            this.CandidateNametextBox.Size = new System.Drawing.Size(537, 30);
            this.CandidateNametextBox.TabIndex = 1;
            this.CandidateNametextBox.TextChanged += new System.EventHandler(this.candidateNametextBox_TextChanged);
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
            // InstituteNamecomboBox
            // 
            this.InstituteNamecomboBox.FormattingEnabled = true;
            this.InstituteNamecomboBox.Items.AddRange(new object[] {
            "BASIS Institute of Technology & Management",
            "New Horizons",
            "Creative IT Institute",
            "E-Soft IT Training Center",
            "LEADS Training & Consulting Limited"});
            this.InstituteNamecomboBox.Location = new System.Drawing.Point(239, 69);
            this.InstituteNamecomboBox.Name = "InstituteNamecomboBox";
            this.InstituteNamecomboBox.Size = new System.Drawing.Size(537, 33);
            this.InstituteNamecomboBox.TabIndex = 3;
            this.InstituteNamecomboBox.SelectedValueChanged += new System.EventHandler(this.InstituteNamecomboBox_SelectedValueChanged);
            this.InstituteNamecomboBox.TextChanged += new System.EventHandler(this.InstituteNamecomboBox_TextChanged);
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
            // AvaliableCourseComboBox
            // 
            this.AvaliableCourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvaliableCourseComboBox.FormattingEnabled = true;
            this.AvaliableCourseComboBox.Location = new System.Drawing.Point(239, 133);
            this.AvaliableCourseComboBox.Name = "AvaliableCourseComboBox";
            this.AvaliableCourseComboBox.Size = new System.Drawing.Size(537, 33);
            this.AvaliableCourseComboBox.TabIndex = 5;
            this.AvaliableCourseComboBox.SelectedValueChanged += new System.EventHandler(this.AvaliableCourseComboBox_SelectedValueChanged);
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(239, 197);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(537, 33);
            this.DurationComboBox.TabIndex = 7;
            this.DurationComboBox.SelectedIndexChanged += new System.EventHandler(this.DurationComboBox_SelectedIndexChanged);
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
            // CostLabel
            // 
            this.CostLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(234, 263);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(491, 37);
            this.CostLabel.TabIndex = 9;
            this.CostLabel.Text = "0.0";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(65, 352);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(292, 81);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.LightYellow;
            this.receiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(433, 352);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(292, 81);
            this.receiptButton.TabIndex = 11;
            this.receiptButton.Text = "Get Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(731, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tk";
            // 
            // candidateDataGridView
            // 
            this.candidateDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.candidateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.candidateDataGridView.Location = new System.Drawing.Point(3, 3);
            this.candidateDataGridView.Name = "candidateDataGridView";
            this.candidateDataGridView.RowTemplate.Height = 28;
            this.candidateDataGridView.Size = new System.Drawing.Size(800, 534);
            this.candidateDataGridView.TabIndex = 0;
            // 
            // TraningRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TraningRegistrationForm";
            this.Text = "Training Registration Booth ";
            this.Load += new System.EventHandler(this.TraningRegistrationForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.RegistrationTabPage.ResumeLayout(false);
            this.RegistrationTabPage.PerformLayout();
            this.ShowInfotabPage.ResumeLayout(false);
            this.RegiatrationFormTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl RegiatrationFormTabControl;
        private System.Windows.Forms.TabPage RegistrationTabPage;
        private System.Windows.Forms.TabPage ShowInfotabPage;
        private System.Windows.Forms.TabPage ReportTabPage;
        private System.Windows.Forms.TextBox CandidateNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox InstituteNamecomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AvaliableCourseComboBox;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView candidateDataGridView;
    }
}

