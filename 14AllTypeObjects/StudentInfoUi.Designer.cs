namespace AllTypeObjects
{
    partial class StudentInfoUi
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeptComboBox = new System.Windows.Forms.ComboBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassRollTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.SemesterComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ClassRollTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CourseTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DeptComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RegistrationNoTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FullNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Directory System";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(41, 507);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(173, 58);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(335, 507);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(173, 58);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(151, 35);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(370, 30);
            this.FullNameTextBox.TabIndex = 1;
            // 
            // RegistrationNoTextBox
            // 
            this.RegistrationNoTextBox.Location = new System.Drawing.Point(151, 224);
            this.RegistrationNoTextBox.Name = "RegistrationNoTextBox";
            this.RegistrationNoTextBox.Size = new System.Drawing.Size(370, 30);
            this.RegistrationNoTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department:";
            // 
            // DeptComboBox
            // 
            this.DeptComboBox.FormattingEnabled = true;
            this.DeptComboBox.Items.AddRange(new object[] {
            "CSE",
            "ECE",
            "BBA",
            "DIPLOMA"});
            this.DeptComboBox.Location = new System.Drawing.Point(151, 93);
            this.DeptComboBox.Name = "DeptComboBox";
            this.DeptComboBox.Size = new System.Drawing.Size(370, 33);
            this.DeptComboBox.TabIndex = 5;
            this.DeptComboBox.SelectedValueChanged += new System.EventHandler(this.DeptComboBox_SelectedValueChanged);
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(151, 158);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(370, 30);
            this.CourseTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Course:";
            // 
            // ClassRollTextBox
            // 
            this.ClassRollTextBox.Location = new System.Drawing.Point(311, 337);
            this.ClassRollTextBox.Name = "ClassRollTextBox";
            this.ClassRollTextBox.Size = new System.Drawing.Size(196, 30);
            this.ClassRollTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class Roll:";
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Items.AddRange(new object[] {
            "CSE",
            "ECE",
            "BBA",
            "DIPLOMA"});
            this.SemesterComboBox.Location = new System.Drawing.Point(52, 338);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(207, 33);
            this.SemesterComboBox.TabIndex = 11;
            this.SemesterComboBox.SelectedValueChanged += new System.EventHandler(this.SemesterComboBox_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Semester:";
            // 
            // StudentInfoUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 590);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentInfoUi";
            this.Text = "Student Validation Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegistrationNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeptComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClassRollTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.Label label7;
    }
}

