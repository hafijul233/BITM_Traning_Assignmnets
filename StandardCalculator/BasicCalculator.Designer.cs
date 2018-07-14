namespace _10StandardCalculator
{
    partial class BasicCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondNumbertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondNumbertextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstNumbertextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input:";
            // 
            // secondNumbertextBox
            // 
            this.secondNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumbertextBox.Location = new System.Drawing.Point(214, 99);
            this.secondNumbertextBox.Name = "secondNumbertextBox";
            this.secondNumbertextBox.Size = new System.Drawing.Size(401, 35);
            this.secondNumbertextBox.TabIndex = 3;
            this.secondNumbertextBox.TextChanged += new System.EventHandler(this.secondNumbertextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Number: ";
            // 
            // firstNumbertextBox
            // 
            this.firstNumbertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumbertextBox.Location = new System.Drawing.Point(214, 37);
            this.firstNumbertextBox.Name = "firstNumbertextBox";
            this.firstNumbertextBox.Size = new System.Drawing.Size(401, 35);
            this.firstNumbertextBox.TabIndex = 1;
            this.firstNumbertextBox.TextChanged += new System.EventHandler(this.firstNumbertextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basic Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.modButton);
            this.groupBox2.Controls.Add(this.divButton);
            this.groupBox2.Controls.Add(this.mulButton);
            this.groupBox2.Controls.Add(this.subButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 183);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(450, 115);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(196, 40);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear (C)";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // modButton
            // 
            this.modButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.modButton.Location = new System.Drawing.Point(234, 115);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(174, 40);
            this.modButton.TabIndex = 4;
            this.modButton.Text = "Modulus (%)";
            this.modButton.UseVisualStyleBackColor = false;
            this.modButton.Click += new System.EventHandler(this.modButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.divButton.Location = new System.Drawing.Point(24, 115);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(174, 40);
            this.divButton.TabIndex = 3;
            this.divButton.Text = "Division(÷)";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.mulButton.Location = new System.Drawing.Point(450, 45);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(196, 40);
            this.mulButton.TabIndex = 2;
            this.mulButton.Text = "Multiplication (x)";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.subButton.Location = new System.Drawing.Point(234, 45);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(174, 40);
            this.subButton.TabIndex = 1;
            this.subButton.Text = " Subtraction (-)";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addButton.Location = new System.Drawing.Point(24, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Addition (+)";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resulttextBox
            // 
            this.resulttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttextBox.Location = new System.Drawing.Point(226, 310);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(442, 39);
            this.resulttextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result: ";
            // 
            // BasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicCalculator";
            this.Text = "BasicCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicCalculator_FormClosing);
            this.Load += new System.EventHandler(this.BasicCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox secondNumbertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNumbertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.Label label4;
    }
}