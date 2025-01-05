namespace POS_System.UserControls
{
    partial class UserControl1CustomerM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnClearCus = new System.Windows.Forms.Button();
            this.btnSaveCus = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactInf = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmailCus = new System.Windows.Forms.Label();
            this.lblContactInf = new System.Windows.Forms.Label();
            this.lblNamCus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(722, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 373);
            this.dataGridView1.TabIndex = 69;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(874, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 47);
            this.txtSearch.TabIndex = 68;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCus.Location = new System.Drawing.Point(1197, 133);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(150, 57);
            this.btnSearchCus.TabIndex = 67;
            this.btnSearchCus.Text = "Search";
            this.btnSearchCus.UseVisualStyleBackColor = false;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnDeleteCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.Location = new System.Drawing.Point(934, 664);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(133, 55);
            this.btnDeleteCus.TabIndex = 66;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.UseVisualStyleBackColor = false;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnEditCus
            // 
            this.btnEditCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnEditCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCus.Location = new System.Drawing.Point(1105, 664);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(121, 55);
            this.btnEditCus.TabIndex = 65;
            this.btnEditCus.Text = "Edit";
            this.btnEditCus.UseVisualStyleBackColor = false;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // btnClearCus
            // 
            this.btnClearCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnClearCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCus.Location = new System.Drawing.Point(419, 532);
            this.btnClearCus.Name = "btnClearCus";
            this.btnClearCus.Size = new System.Drawing.Size(128, 56);
            this.btnClearCus.TabIndex = 64;
            this.btnClearCus.Text = "Clear";
            this.btnClearCus.UseVisualStyleBackColor = false;
            this.btnClearCus.Click += new System.EventHandler(this.btnClearCus_Click);
            // 
            // btnSaveCus
            // 
            this.btnSaveCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.btnSaveCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCus.Location = new System.Drawing.Point(212, 532);
            this.btnSaveCus.Name = "btnSaveCus";
            this.btnSaveCus.Size = new System.Drawing.Size(128, 56);
            this.btnSaveCus.TabIndex = 63;
            this.btnSaveCus.Text = "Save";
            this.btnSaveCus.UseVisualStyleBackColor = false;
            this.btnSaveCus.Click += new System.EventHandler(this.btnSaveCus_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(400, 405);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 47);
            this.txtEmail.TabIndex = 62;
            // 
            // txtContactInf
            // 
            this.txtContactInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactInf.Location = new System.Drawing.Point(400, 329);
            this.txtContactInf.Name = "txtContactInf";
            this.txtContactInf.Size = new System.Drawing.Size(228, 47);
            this.txtContactInf.TabIndex = 61;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(400, 241);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 47);
            this.txtName.TabIndex = 60;
            // 
            // lblEmailCus
            // 
            this.lblEmailCus.AutoSize = true;
            this.lblEmailCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblEmailCus.Location = new System.Drawing.Point(102, 405);
            this.lblEmailCus.Name = "lblEmailCus";
            this.lblEmailCus.Size = new System.Drawing.Size(130, 42);
            this.lblEmailCus.TabIndex = 59;
            this.lblEmailCus.Text = "Email :";
            // 
            // lblContactInf
            // 
            this.lblContactInf.AutoSize = true;
            this.lblContactInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblContactInf.Location = new System.Drawing.Point(102, 329);
            this.lblContactInf.Name = "lblContactInf";
            this.lblContactInf.Size = new System.Drawing.Size(238, 42);
            this.lblContactInf.TabIndex = 58;
            this.lblContactInf.Text = "Contact Info :";
            // 
            // lblNamCus
            // 
            this.lblNamCus.AutoSize = true;
            this.lblNamCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblNamCus.Location = new System.Drawing.Point(102, 241);
            this.lblNamCus.Name = "lblNamCus";
            this.lblNamCus.Size = new System.Drawing.Size(207, 42);
            this.lblNamCus.TabIndex = 57;
            this.lblNamCus.Text = "Full Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Location = new System.Drawing.Point(601, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 63);
            this.label1.TabIndex = 56;
            this.label1.Text = "Customer Managment ";
            // 
            // UserControl1CustomerM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchCus);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.btnClearCus);
            this.Controls.Add(this.btnSaveCus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactInf);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmailCus);
            this.Controls.Add(this.lblContactInf);
            this.Controls.Add(this.lblNamCus);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1CustomerM";
            this.Size = new System.Drawing.Size(1787, 788);
            this.Load += new System.EventHandler(this.UserControl1CustomerM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnClearCus;
        private System.Windows.Forms.Button btnSaveCus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactInf;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmailCus;
        private System.Windows.Forms.Label lblContactInf;
        private System.Windows.Forms.Label lblNamCus;
        private System.Windows.Forms.Label label1;
    }
}
