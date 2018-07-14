namespace GPAResultCalculator
{
    partial class ResulCalculator
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
            this.PhysicsResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChemistryResultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MathResultTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AverageResultTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MathResultTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ChemistryResultTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PhysicsResultTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Physics";
            // 
            // PhysicsResultTextBox
            // 
            this.PhysicsResultTextBox.Location = new System.Drawing.Point(153, 40);
            this.PhysicsResultTextBox.Name = "PhysicsResultTextBox";
            this.PhysicsResultTextBox.Size = new System.Drawing.Size(245, 30);
            this.PhysicsResultTextBox.TabIndex = 1;
            this.PhysicsResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PhysicsResultTextBox.TextChanged += new System.EventHandler(this.PhysicsResultTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "out of 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "out of 100";
            // 
            // ChemistryResultTextBox
            // 
            this.ChemistryResultTextBox.Location = new System.Drawing.Point(153, 101);
            this.ChemistryResultTextBox.Name = "ChemistryResultTextBox";
            this.ChemistryResultTextBox.Size = new System.Drawing.Size(245, 30);
            this.ChemistryResultTextBox.TabIndex = 4;
            this.ChemistryResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChemistryResultTextBox.TextChanged += new System.EventHandler(this.ChemistryResultTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chemistry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "out of 100";
            // 
            // MathResultTextBox
            // 
            this.MathResultTextBox.Location = new System.Drawing.Point(153, 162);
            this.MathResultTextBox.Name = "MathResultTextBox";
            this.MathResultTextBox.Size = new System.Drawing.Size(245, 30);
            this.MathResultTextBox.TabIndex = 7;
            this.MathResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MathResultTextBox.TextChanged += new System.EventHandler(this.MathResultTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Math";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeTextBox.Location = new System.Drawing.Point(161, 352);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.ReadOnly = true;
            this.GradeTextBox.Size = new System.Drawing.Size(159, 35);
            this.GradeTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "GPA Grade";
            // 
            // AverageResultTextBox
            // 
            this.AverageResultTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AverageResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageResultTextBox.Location = new System.Drawing.Point(161, 291);
            this.AverageResultTextBox.Name = "AverageResultTextBox";
            this.AverageResultTextBox.ReadOnly = true;
            this.AverageResultTextBox.Size = new System.Drawing.Size(159, 35);
            this.AverageResultTextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Average";
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(377, 305);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(158, 64);
            this.ShowButton.TabIndex = 13;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ResulCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 458);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.GradeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AverageResultTextBox);
            this.Name = "ResulCalculator";
            this.Text = "GPA Result Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MathResultTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChemistryResultTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhysicsResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AverageResultTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ShowButton;
    }
}

