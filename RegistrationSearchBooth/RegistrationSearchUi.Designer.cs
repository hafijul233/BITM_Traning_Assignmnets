﻿namespace _12RegistrationSearchBooth
{
    partial class RegistrationSearchUi
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClassRollTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrationNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentInfoListView = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchValueTextBox = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.AddressTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ClassRollTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RegistrationNoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FullNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 699);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration Form";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.IndianRed;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(229, 610);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(175, 54);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Location = new System.Drawing.Point(29, 610);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 54);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save Info";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(29, 441);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(375, 127);
            this.AddressTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // ClassRollTextBox
            // 
            this.ClassRollTextBox.Location = new System.Drawing.Point(29, 325);
            this.ClassRollTextBox.Name = "ClassRollTextBox";
            this.ClassRollTextBox.Size = new System.Drawing.Size(375, 30);
            this.ClassRollTextBox.TabIndex = 5;
            this.ClassRollTextBox.TextChanged += new System.EventHandler(this.ClassRollTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Class Roll:";
            // 
            // RegistrationNoTextBox
            // 
            this.RegistrationNoTextBox.Location = new System.Drawing.Point(29, 202);
            this.RegistrationNoTextBox.Name = "RegistrationNoTextBox";
            this.RegistrationNoTextBox.Size = new System.Drawing.Size(375, 30);
            this.RegistrationNoTextBox.TabIndex = 3;
            this.RegistrationNoTextBox.TextChanged += new System.EventHandler(this.RegistrationNoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registration Number:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(29, 92);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(375, 30);
            this.FullNameTextBox.TabIndex = 1;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Fullname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentInfoListView);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.SearchValueTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(465, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 699);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Registration Query Box";
            // 
            // StudentInfoListView
            // 
            this.StudentInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.StudentInfoListView.FullRowSelect = true;
            this.StudentInfoListView.GridLines = true;
            this.StudentInfoListView.Location = new System.Drawing.Point(18, 134);
            this.StudentInfoListView.Name = "StudentInfoListView";
            this.StudentInfoListView.Size = new System.Drawing.Size(810, 548);
            this.StudentInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.StudentInfoListView.TabIndex = 4;
            this.StudentInfoListView.UseCompatibleStateImageBehavior = false;
            this.StudentInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search Result:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Info;
            this.SearchButton.Location = new System.Drawing.Point(606, 37);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(193, 46);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchValueTextBox
            // 
            this.SearchValueTextBox.Location = new System.Drawing.Point(31, 45);
            this.SearchValueTextBox.Name = "SearchValueTextBox";
            this.SearchValueTextBox.Size = new System.Drawing.Size(539, 30);
            this.SearchValueTextBox.TabIndex = 0;
            this.SearchValueTextBox.TextChanged += new System.EventHandler(this.SearchValueTextBox_TextChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Registration No.";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Roll";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 180;
            // 
            // RegistrationSearchUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationSearchUi";
            this.Text = "Student Registration Booth";
            this.Load += new System.EventHandler(this.RegistrationSearchUi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClassRollTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegistrationNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchValueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView StudentInfoListView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

