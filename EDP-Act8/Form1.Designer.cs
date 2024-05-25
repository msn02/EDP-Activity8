namespace EDP_Act8
{
    partial class main_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dept_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnum_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lname_tbx = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.fname_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.success_msg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.success_msg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dept_tbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email_tbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cnum_tbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lname_tbx);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.fname_tbx);
            this.panel1.Location = new System.Drawing.Point(641, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 622);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Register Employee";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(29, 442);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(112, 37);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department Code";
            // 
            // dept_tbx
            // 
            this.dept_tbx.Location = new System.Drawing.Point(29, 401);
            this.dept_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dept_tbx.Name = "dept_tbx";
            this.dept_tbx.Size = new System.Drawing.Size(256, 22);
            this.dept_tbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // email_tbx
            // 
            this.email_tbx.Location = new System.Drawing.Point(29, 332);
            this.email_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email_tbx.Name = "email_tbx";
            this.email_tbx.Size = new System.Drawing.Size(256, 22);
            this.email_tbx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact Number";
            // 
            // cnum_tbx
            // 
            this.cnum_tbx.Location = new System.Drawing.Point(29, 267);
            this.cnum_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cnum_tbx.Name = "cnum_tbx";
            this.cnum_tbx.Size = new System.Drawing.Size(256, 22);
            this.cnum_tbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lname_tbx
            // 
            this.lname_tbx.Location = new System.Drawing.Point(29, 198);
            this.lname_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lname_tbx.Name = "lname_tbx";
            this.lname_tbx.Size = new System.Drawing.Size(256, 22);
            this.lname_tbx.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 111);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 16);
            this.label.TabIndex = 1;
            this.label.Text = "First Name";
            // 
            // fname_tbx
            // 
            this.fname_tbx.Location = new System.Drawing.Point(29, 134);
            this.fname_tbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fname_tbx.Name = "fname_tbx";
            this.fname_tbx.Size = new System.Drawing.Size(256, 22);
            this.fname_tbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 478);
            this.dataGridView1.TabIndex = 12;
            // 
            // success_msg
            // 
            this.success_msg.AutoSize = true;
            this.success_msg.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_msg.ForeColor = System.Drawing.Color.ForestGreen;
            this.success_msg.Location = new System.Drawing.Point(29, 511);
            this.success_msg.MaximumSize = new System.Drawing.Size(260, 0);
            this.success_msg.Name = "success_msg";
            this.success_msg.Size = new System.Drawing.Size(75, 16);
            this.success_msg.TabIndex = 13;
            this.success_msg.Text = "Registered";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dept_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnum_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lname_tbx;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox fname_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label success_msg;
    }
}