namespace POS_System.UserControls
{
    partial class UserControl1Report
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSel = new System.Windows.Forms.Panel();
            this.btnSMR = new System.Windows.Forms.Button();
            this.btnCAR = new System.Windows.Forms.Button();
            this.btnSR = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(5, 130);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1787, 788);
            this.pnlMain.TabIndex = 188;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.pnlSel);
            this.panel3.Controls.Add(this.btnSMR);
            this.panel3.Controls.Add(this.btnCAR);
            this.panel3.Controls.Add(this.btnSR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1818, 86);
            this.panel3.TabIndex = 187;
            // 
            // pnlSel
            // 
            this.pnlSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.pnlSel.Location = new System.Drawing.Point(-3, 79);
            this.pnlSel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSel.Name = "pnlSel";
            this.pnlSel.Size = new System.Drawing.Size(600, 6);
            this.pnlSel.TabIndex = 61;
            // 
            // btnSMR
            // 
            this.btnSMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.btnSMR.FlatAppearance.BorderSize = 0;
            this.btnSMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMR.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMR.Location = new System.Drawing.Point(1196, 0);
            this.btnSMR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSMR.Name = "btnSMR";
            this.btnSMR.Size = new System.Drawing.Size(600, 86);
            this.btnSMR.TabIndex = 2;
            this.btnSMR.Text = "INVENTORY REPORT";
            this.btnSMR.UseVisualStyleBackColor = false;
            this.btnSMR.Click += new System.EventHandler(this.btnSMR_Click);
            // 
            // btnCAR
            // 
            this.btnCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.btnCAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAR.FlatAppearance.BorderSize = 0;
            this.btnCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAR.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAR.Location = new System.Drawing.Point(599, 0);
            this.btnCAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCAR.Name = "btnCAR";
            this.btnCAR.Size = new System.Drawing.Size(600, 86);
            this.btnCAR.TabIndex = 1;
            this.btnCAR.Text = "CUSTOMER ACTIVITY";
            this.btnCAR.UseVisualStyleBackColor = false;
            this.btnCAR.Click += new System.EventHandler(this.btnCAR_Click);
            // 
            // btnSR
            // 
            this.btnSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.btnSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSR.FlatAppearance.BorderSize = 0;
            this.btnSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSR.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSR.Location = new System.Drawing.Point(1, 0);
            this.btnSR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(600, 86);
            this.btnSR.TabIndex = 0;
            this.btnSR.Text = "SALES REPORT";
            this.btnSR.UseVisualStyleBackColor = false;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // UserControl1Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel3);
            this.Name = "UserControl1Report";
            this.Size = new System.Drawing.Size(1818, 944);
            this.Load += new System.EventHandler(this.UserControl1Report_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSel;
        private System.Windows.Forms.Button btnSMR;
        private System.Windows.Forms.Button btnCAR;
        private System.Windows.Forms.Button btnSR;
    }
}
