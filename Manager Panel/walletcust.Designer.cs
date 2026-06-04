namespace Manager_Panel
{
    partial class walletcust
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblCusname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblCusID);
            this.panel1.Controls.Add(this.lblCusname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 96);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltotal.Location = new System.Drawing.Point(835, 36);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(65, 29);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Total";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(639, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 29);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblType.Location = new System.Drawing.Point(459, 36);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 29);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCusID.Location = new System.Drawing.Point(271, 36);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(73, 29);
            this.lblCusID.TabIndex = 1;
            this.lblCusID.Text = "CusID";
            // 
            // lblCusname
            // 
            this.lblCusname.AutoSize = true;
            this.lblCusname.Font = new System.Drawing.Font("Comic Sans MS", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCusname.Location = new System.Drawing.Point(42, 36);
            this.lblCusname.Name = "lblCusname";
            this.lblCusname.Size = new System.Drawing.Size(96, 29);
            this.lblCusname.TabIndex = 0;
            this.lblCusname.Text = "Cusname";
            // 
            // walletcust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "walletcust";
            this.Size = new System.Drawing.Size(948, 95);
            this.Load += new System.EventHandler(this.walletcust_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCusname;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCusID;
    }
}
