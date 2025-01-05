namespace POS_System.UserControls
{
    partial class UserControl1UserM
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Utype = new System.Windows.Forms.TextBox();
            this.Uemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Upassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 89);
            this.label3.TabIndex = 18;
            this.label3.Text = "ADD USER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(709, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 729);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select a row to Update or Delete a User.";
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(56, 97);
            this.dataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 62;
            this.dataView.RowTemplate.Height = 28;
            this.dataView.Size = new System.Drawing.Size(911, 577);
            this.dataView.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "All User\'s Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.Utype);
            this.panel1.Controls.Add(this.Uemail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Upassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Uname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(80, 187);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 576);
            this.panel1.TabIndex = 16;
            // 
            // Utype
            // 
            this.Utype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Utype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utype.Location = new System.Drawing.Point(35, 322);
            this.Utype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Utype.Name = "Utype";
            this.Utype.Size = new System.Drawing.Size(462, 34);
            this.Utype.TabIndex = 15;
            // 
            // Uemail
            // 
            this.Uemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uemail.Location = new System.Drawing.Point(35, 236);
            this.Uemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Uemail.Name = "Uemail";
            this.Uemail.Size = new System.Drawing.Size(462, 34);
            this.Uemail.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(31, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "UserEmail";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(313, 479);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 52);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.Location = new System.Drawing.Point(65, 479);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(156, 52);
            this.remove.TabIndex = 10;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(313, 411);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 52);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(65, 411);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(156, 52);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label7.Location = new System.Drawing.Point(31, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "UserType";
            // 
            // Upassword
            // 
            this.Upassword.AcceptsReturn = true;
            this.Upassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Upassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upassword.Location = new System.Drawing.Point(35, 164);
            this.Upassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Upassword.Name = "Upassword";
            this.Upassword.Size = new System.Drawing.Size(462, 34);
            this.Upassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(31, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // Uname
            // 
            this.Uname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.Location = new System.Drawing.Point(35, 85);
            this.Uname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(462, 34);
            this.Uname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Location = new System.Drawing.Point(31, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "UserName";
            // 
            // UserControl1UserM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl1UserM";
            this.Size = new System.Drawing.Size(1787, 788);
            this.Load += new System.EventHandler(this.UserControl1UserM_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Utype;
        private System.Windows.Forms.TextBox Uemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Upassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
