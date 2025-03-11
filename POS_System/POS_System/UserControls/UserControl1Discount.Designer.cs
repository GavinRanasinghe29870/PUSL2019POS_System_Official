namespace POS_System.UserControls
{
    partial class UserControl1Discount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtDiscountID = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.numDisPercentage = new System.Windows.Forms.NumericUpDown();
            this.cmbDisType = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numDisPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(1071, 151);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(165, 52);
            this.SearchBtn.TabIndex = 72;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // txtDiscountID
            // 
            this.txtDiscountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountID.Location = new System.Drawing.Point(927, 156);
            this.txtDiscountID.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountID.Name = "txtDiscountID";
            this.txtDiscountID.Size = new System.Drawing.Size(128, 47);
            this.txtDiscountID.TabIndex = 71;
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(425, 338);
            this.txtProID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(183, 47);
            this.txtProID.TabIndex = 70;
            // 
            // numDisPercentage
            // 
            this.numDisPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDisPercentage.Location = new System.Drawing.Point(425, 267);
            this.numDisPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.numDisPercentage.Name = "numDisPercentage";
            this.numDisPercentage.Size = new System.Drawing.Size(165, 47);
            this.numDisPercentage.TabIndex = 69;
            // 
            // cmbDisType
            // 
            this.cmbDisType.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisType.FormattingEnabled = true;
            this.cmbDisType.Items.AddRange(new object[] {
            "Percentage",
            "Fixed"});
            this.cmbDisType.Location = new System.Drawing.Point(425, 197);
            this.cmbDisType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisType.Name = "cmbDisType";
            this.cmbDisType.Size = new System.Drawing.Size(218, 47);
            this.cmbDisType.TabIndex = 68;
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.Location = new System.Drawing.Point(722, 255);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.RowHeadersWidth = 82;
            this.dgvDiscounts.RowTemplate.Height = 33;
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(937, 411);
            this.dgvDiscounts.TabIndex = 67;
            this.dgvDiscounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscounts_CellContentClick_1);
            // 
            // productSpecific
            // 
            this.productSpecific.AutoSize = true;
            this.productSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSpecific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productSpecific.Location = new System.Drawing.Point(68, 338);
            this.productSpecific.Name = "productSpecific";
            this.productSpecific.Size = new System.Drawing.Size(308, 42);
            this.productSpecific.TabIndex = 66;
            this.productSpecific.Text = "Product Specific :";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(532, 584);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(174, 50);
            this.DeleteBtn.TabIndex = 65;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(356, 584);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 50);
            this.EditBtn.TabIndex = 64;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(166, 584);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(132, 50);
            this.AddBtn.TabIndex = 63;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(425, 462);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(239, 47);
            this.dtpEndDate.TabIndex = 62;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(425, 399);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(239, 47);
            this.dtpStartDate.TabIndex = 61;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.endDate.Location = new System.Drawing.Point(68, 465);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(194, 42);
            this.endDate.TabIndex = 60;
            this.endDate.Text = "End Date :";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.startDate.Location = new System.Drawing.Point(68, 402);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(205, 42);
            this.startDate.TabIndex = 59;
            this.startDate.Text = "Start Date :";
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.percentage.Location = new System.Drawing.Point(68, 266);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(230, 42);
            this.percentage.TabIndex = 58;
            this.percentage.Text = "Percentage :";
            // 
            // discountType
            // 
            this.discountType.AutoSize = true;
            this.discountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.discountType.Location = new System.Drawing.Point(68, 197);
            this.discountType.Name = "discountType";
            this.discountType.Size = new System.Drawing.Size(278, 42);
            this.discountType.TabIndex = 57;
            this.discountType.Text = "Discount Type :";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblTopic.Location = new System.Drawing.Point(581, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(402, 63);
            this.lblTopic.TabIndex = 56;
            this.lblTopic.Text = "Discount Page";
            // 
            // UserControl1Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.txtDiscountID);
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
            this.Name = "UserControl1Discount";
            this.Size = new System.Drawing.Size(1787, 788);
            this.Load += new System.EventHandler(this.UserControl1Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDisPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtDiscountID;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.NumericUpDown numDisPercentage;
        private System.Windows.Forms.ComboBox cmbDisType;
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
    }
}
