namespace CommunalComputerManager
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login_btn_login = new System.Windows.Forms.Button();
            this.Login_btn_cancal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 25);
            this.textBox2.TabIndex = 3;
            // 
            // Login_btn_login
            // 
            this.Login_btn_login.Location = new System.Drawing.Point(116, 198);
            this.Login_btn_login.Name = "Login_btn_login";
            this.Login_btn_login.Size = new System.Drawing.Size(75, 23);
            this.Login_btn_login.TabIndex = 4;
            this.Login_btn_login.Text = "登录";
            this.Login_btn_login.UseVisualStyleBackColor = true;
            this.Login_btn_login.Click += new System.EventHandler(this.Login_btn_login_Click);
            // 
            // Login_btn_cancal
            // 
            this.Login_btn_cancal.Location = new System.Drawing.Point(270, 198);
            this.Login_btn_cancal.Name = "Login_btn_cancal";
            this.Login_btn_cancal.Size = new System.Drawing.Size(75, 23);
            this.Login_btn_cancal.TabIndex = 5;
            this.Login_btn_cancal.Text = "取消";
            this.Login_btn_cancal.UseVisualStyleBackColor = true;
            this.Login_btn_cancal.Click += new System.EventHandler(this.Login_btn_cancal_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 253);
            this.Controls.Add(this.Login_btn_cancal);
            this.Controls.Add(this.Login_btn_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Login_btn_login;
        private System.Windows.Forms.Button Login_btn_cancal;
    }
}