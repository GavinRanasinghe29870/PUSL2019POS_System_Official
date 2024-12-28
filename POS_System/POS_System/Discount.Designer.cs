namespace POS_System
{
    partial class Discount
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
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.productSpecific = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.discountType = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbDisType = new System.Windows.Forms.ComboBox();
            this.numDisPercentage = new System.Windows.Forms.NumericUpDown();
            this.txtProID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.Location = new System.Drawing.Point(631, 398);
            this.dgvDiscounts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.RowHeadersWidth = 82;
            this.dgvDiscounts.RowTemplate.Height = 33;
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(1080, 450);
            this.dgvDiscounts.TabIndex = 50;
            this.dgvDiscounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscounts_CellContentClick_1);
            // 
            // productSpecific
            // 
            this.productSpecific.AutoSize = true;
            this.productSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSpecific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productSpecific.Location = new System.Drawing.Point(62, 398);
            this.productSpecific.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productSpecific.Name = "productSpecific";
            this.productSpecific.Size = new System.Drawing.Size(226, 31);
            this.productSpecific.TabIndex = 46;
            this.productSpecific.Text = "Product Specific :";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(434, 701);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(146, 48);
            this.DeleteBtn.TabIndex = 45;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(256, 701);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(116, 48);
            this.EditBtn.TabIndex = 44;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(68, 701);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(116, 48);
            this.AddBtn.TabIndex = 43;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(316, 588);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(248, 31);
            this.dtpEndDate.TabIndex = 42;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(316, 496);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(248, 31);
            this.dtpStartDate.TabIndex = 41;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.endDate.Location = new System.Drawing.Point(62, 594);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(142, 31);
            this.endDate.TabIndex = 38;
            this.endDate.Text = "End Date :";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startDate.Location = new System.Drawing.Point(62, 496);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(152, 31);
            this.startDate.TabIndex = 37;
            this.startDate.Text = "Start Date :";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.percentage.Location = new System.Drawing.Point(62, 302);
            this.percentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(168, 31);
            this.percentage.TabIndex = 36;
            this.percentage.Text = "Percentage :";
            // 
            // discountType
            // 
            this.discountType.AutoSize = true;
            this.discountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.discountType.Location = new System.Drawing.Point(62, 210);
            this.discountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountType.Name = "discountType";
            this.discountType.Size = new System.Drawing.Size(204, 31);
            this.discountType.TabIndex = 35;
            this.discountType.Text = "Discount Type :";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTopic.Location = new System.Drawing.Point(568, 79);
            this.lblTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(275, 42);
            this.lblTopic.TabIndex = 34;
            this.lblTopic.Text = "Discount Page";
            // 
            // cmbDisType
            // 
            this.cmbDisType.FormattingEnabled = true;
            this.cmbDisType.Items.AddRange(new object[] {
            "Percentage",
            "Fixed"});
            this.cmbDisType.Location = new System.Drawing.Point(316, 218);
            this.cmbDisType.Name = "cmbDisType";
            this.cmbDisType.Size = new System.Drawing.Size(248, 33);
            this.cmbDisType.TabIndex = 51;
            // 
            // numDisPercentage
            // 
            this.numDisPercentage.Location = new System.Drawing.Point(316, 302);
            this.numDisPercentage.Name = "numDisPercentage";
            this.numDisPercentage.Size = new System.Drawing.Size(248, 31);
            this.numDisPercentage.TabIndex = 52;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(316, 398);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(248, 31);
            this.txtProID.TabIndex = 53;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 904);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.numDisPercentage);
            this.Controls.Add(this.cmbDisType);
            this.Controls.Add(this.dgvDiscounts);
            this.Controls.Add(this.productSpecific);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.discountType);
            this.Controls.Add(this.lblTopic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Discount";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.Label productSpecific;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.Label discountType;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbDisType;
        private System.Windows.Forms.NumericUpDown numDisPercentage;
        private System.Windows.Forms.TextBox txtProID;
    }
}