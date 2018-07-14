namespace Vehicle_Control_Panel
{
    partial class VehicleControllerUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleNameTextBox = new System.Windows.Forms.TextBox();
            this.RegNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvgSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name";
            // 
            // VehicleNameTextBox
            // 
            this.VehicleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleNameTextBox.Location = new System.Drawing.Point(188, 23);
            this.VehicleNameTextBox.Name = "VehicleNameTextBox";
            this.VehicleNameTextBox.Size = new System.Drawing.Size(313, 30);
            this.VehicleNameTextBox.TabIndex = 1;
            // 
            // RegNoTextBox
            // 
            this.RegNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNoTextBox.Location = new System.Drawing.Point(188, 74);
            this.RegNoTextBox.Name = "RegNoTextBox";
            this.RegNoTextBox.Size = new System.Drawing.Size(313, 30);
            this.RegNoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reg No";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(522, 56);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(154, 48);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(522, 153);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(154, 48);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedTextBox.Location = new System.Drawing.Point(185, 162);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(211, 30);
            this.SpeedTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kilo/Hr";
            // 
            // MinSpeedTextBox
            // 
            this.MinSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinSpeedTextBox.Location = new System.Drawing.Point(188, 239);
            this.MinSpeedTextBox.Name = "MinSpeedTextBox";
            this.MinSpeedTextBox.Size = new System.Drawing.Size(313, 30);
            this.MinSpeedTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min Speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(188, 295);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(313, 30);
            this.MaxSpeedTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AvgSpeedTextBox
            // 
            this.AvgSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgSpeedTextBox.Location = new System.Drawing.Point(188, 355);
            this.AvgSpeedTextBox.Name = "AvgSpeedTextBox";
            this.AvgSpeedTextBox.Size = new System.Drawing.Size(313, 30);
            this.AvgSpeedTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Average Speed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(522, 286);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(154, 48);
            this.ShowButton.TabIndex = 15;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // VehicleControllerUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 419);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.AvgSpeedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MinSpeedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.RegNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VehicleNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "VehicleControllerUi";
            this.Text = "Vehicle Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VehicleNameTextBox;
        private System.Windows.Forms.TextBox RegNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinSpeedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AvgSpeedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShowButton;
    }
}

