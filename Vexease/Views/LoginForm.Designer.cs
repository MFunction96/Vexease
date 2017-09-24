namespace Vexease.Views
{
    partial class LoginForm
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
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPwd = new System.Windows.Forms.MaskedTextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblForgetPwd = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUserName
            // 
            this.TxtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtUserName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtUserName.Location = new System.Drawing.Point(100, 108);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(300, 28);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            this.TxtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(100, 201);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(300, 30);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "立即登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtPwd
            // 
            this.TxtPwd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwd.Location = new System.Drawing.Point(100, 156);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(300, 28);
            this.TxtPwd.TabIndex = 6;
            this.TxtPwd.Enter += new System.EventHandler(this.TxtPwd_Enter);
            this.TxtPwd.Leave += new System.EventHandler(this.TxtPwd_Leave);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Mistral", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(150, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(188, 83);
            this.LblTitle.TabIndex = 7;
            this.LblTitle.Text = "Vexease";
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblRegister.Location = new System.Drawing.Point(261, 280);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(35, 14);
            this.LblRegister.TabIndex = 8;
            this.LblRegister.Text = "注册";
            this.LblRegister.Click += new System.EventHandler(this.LblRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "|";
            // 
            // LblForgetPwd
            // 
            this.LblForgetPwd.AutoSize = true;
            this.LblForgetPwd.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblForgetPwd.Location = new System.Drawing.Point(323, 280);
            this.LblForgetPwd.Name = "LblForgetPwd";
            this.LblForgetPwd.Size = new System.Drawing.Size(77, 14);
            this.LblForgetPwd.TabIndex = 10;
            this.LblForgetPwd.Text = "忘记密码？";
            this.LblForgetPwd.Click += new System.EventHandler(this.LblForgetPwd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(100, 237);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(300, 30);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblForgetPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtUserName);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.MaskedTextBox TxtPwd;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblForgetPwd;
        private System.Windows.Forms.Button BtnCancel;
    }
}