namespace AppQLST
{
    partial class Form1
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
            this.ldmessenger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ldmessenger);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 208);
            this.panel1.TabIndex = 2;
            // 
            // ldmessenger
            // 
            this.ldmessenger.AutoSize = true;
            this.ldmessenger.Location = new System.Drawing.Point(17, 42);
            this.ldmessenger.Name = "ldmessenger";
            this.ldmessenger.Size = new System.Drawing.Size(66, 13);
            this.ldmessenger.TabIndex = 5;
            this.ldmessenger.Text = "Thông Báo :";
            this.ldmessenger.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng Nhập Hệ Thống ";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(185, 185);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 23);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(77, 185);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(89, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbpassword);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 48);
            this.panel3.TabIndex = 1;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(124, 16);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(195, 20);
            this.txbpassword.TabIndex = 1;
            this.txbpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbusername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 48);
            this.panel2.TabIndex = 0;
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(124, 16);
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(195, 20);
            this.txbusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 235);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ldmessenger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.Label label1;
    }
}

