namespace HafizIslamiBank
{
    partial class IndexPageUi
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
            this.SaveCustomerinfolinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.SearchCustomerInfolinkLabel = new System.Windows.Forms.LinkLabel();
            this.TransactionlinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveCustomerinfolinkLabel
            // 
            this.SaveCustomerinfolinkLabel.AutoSize = true;
            this.SaveCustomerinfolinkLabel.Location = new System.Drawing.Point(88, 39);
            this.SaveCustomerinfolinkLabel.Name = "SaveCustomerinfolinkLabel";
            this.SaveCustomerinfolinkLabel.Size = new System.Drawing.Size(244, 20);
            this.SaveCustomerinfolinkLabel.TabIndex = 0;
            this.SaveCustomerinfolinkLabel.TabStop = true;
            this.SaveCustomerinfolinkLabel.Text = "Save Customer & Account Info";
            this.SaveCustomerinfolinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveCustomerinfolinkLabel_LinkClicked);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.SearchCustomerInfolinkLabel);
            this.groupbox1.Controls.Add(this.TransactionlinkLabel);
            this.groupbox1.Controls.Add(this.SaveCustomerinfolinkLabel);
            this.groupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(91, 91);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(409, 237);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Bank Query Operation Menu";
            // 
            // SearchCustomerInfolinkLabel
            // 
            this.SearchCustomerInfolinkLabel.AutoSize = true;
            this.SearchCustomerInfolinkLabel.Location = new System.Drawing.Point(88, 169);
            this.SearchCustomerInfolinkLabel.Name = "SearchCustomerInfolinkLabel";
            this.SearchCustomerInfolinkLabel.Size = new System.Drawing.Size(256, 20);
            this.SearchCustomerInfolinkLabel.TabIndex = 2;
            this.SearchCustomerInfolinkLabel.TabStop = true;
            this.SearchCustomerInfolinkLabel.Text = "Search Customer Account Info";
            this.SearchCustomerInfolinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchCustomerInfolinkLabel_LinkClicked);
            // 
            // TransactionlinkLabel
            // 
            this.TransactionlinkLabel.AutoSize = true;
            this.TransactionlinkLabel.Location = new System.Drawing.Point(153, 98);
            this.TransactionlinkLabel.Name = "TransactionlinkLabel";
            this.TransactionlinkLabel.Size = new System.Drawing.Size(103, 20);
            this.TransactionlinkLabel.TabIndex = 1;
            this.TransactionlinkLabel.TabStop = true;
            this.TransactionlinkLabel.Text = "Transaction";
            this.TransactionlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TransactionlinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hafiz Islami Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IndexPageUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupbox1);
            this.Name = "IndexPageUi";
            this.Text = "Hafiz Islami Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IndexPageUi_FormClosing);
            this.Load += new System.EventHandler(this.IndexPageUi_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel SaveCustomerinfolinkLabel;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel SearchCustomerInfolinkLabel;
        private System.Windows.Forms.LinkLabel TransactionlinkLabel;
    }
}

