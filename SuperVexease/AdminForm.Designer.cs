namespace SuperVexease
{
    partial class AdminForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TBSetPwd = new System.Windows.Forms.TextBox();
            this.BtnSetPwd = new System.Windows.Forms.Button();
            this.LblSetPwd = new System.Windows.Forms.Label();
            this.LblCurrentPwdTip = new System.Windows.Forms.Label();
            this.LblCurrentPwd = new System.Windows.Forms.Label();
            this.LblConfirmPwd = new System.Windows.Forms.Label();
            this.TBConfirmPwd = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBSetPwd
            // 
            this.TBSetPwd.Location = new System.Drawing.Point(184, 92);
            this.TBSetPwd.Name = "TBSetPwd";
            this.TBSetPwd.Size = new System.Drawing.Size(248, 25);
            this.TBSetPwd.TabIndex = 0;
            // 
            // BtnSetPwd
            // 
            this.BtnSetPwd.Location = new System.Drawing.Point(73, 185);
            this.BtnSetPwd.Name = "BtnSetPwd";
            this.BtnSetPwd.Size = new System.Drawing.Size(118, 29);
            this.BtnSetPwd.TabIndex = 1;
            this.BtnSetPwd.Text = "设置";
            this.BtnSetPwd.UseVisualStyleBackColor = true;
            this.BtnSetPwd.Click += new System.EventHandler(this.BtnSetPwd_Click);
            // 
            // LblSetPwd
            // 
            this.LblSetPwd.AutoSize = true;
            this.LblSetPwd.Location = new System.Drawing.Point(92, 95);
            this.LblSetPwd.Name = "LblSetPwd";
            this.LblSetPwd.Size = new System.Drawing.Size(67, 15);
            this.LblSetPwd.TabIndex = 2;
            this.LblSetPwd.Text = "设置密码";
            // 
            // LblCurrentPwdTip
            // 
            this.LblCurrentPwdTip.AutoSize = true;
            this.LblCurrentPwdTip.Location = new System.Drawing.Point(92, 56);
            this.LblCurrentPwdTip.Name = "LblCurrentPwdTip";
            this.LblCurrentPwdTip.Size = new System.Drawing.Size(67, 15);
            this.LblCurrentPwdTip.TabIndex = 3;
            this.LblCurrentPwdTip.Text = "当前密码";
            // 
            // LblCurrentPwd
            // 
            this.LblCurrentPwd.AutoSize = true;
            this.LblCurrentPwd.Location = new System.Drawing.Point(184, 55);
            this.LblCurrentPwd.Name = "LblCurrentPwd";
            this.LblCurrentPwd.Size = new System.Drawing.Size(87, 15);
            this.LblCurrentPwd.TabIndex = 4;
            this.LblCurrentPwd.Text = "Loading...";
            // 
            // LblConfirmPwd
            // 
            this.LblConfirmPwd.AutoSize = true;
            this.LblConfirmPwd.Location = new System.Drawing.Point(92, 136);
            this.LblConfirmPwd.Name = "LblConfirmPwd";
            this.LblConfirmPwd.Size = new System.Drawing.Size(67, 15);
            this.LblConfirmPwd.TabIndex = 5;
            this.LblConfirmPwd.Text = "确认密码";
            // 
            // TBConfirmPwd
            // 
            this.TBConfirmPwd.Location = new System.Drawing.Point(184, 133);
            this.TBConfirmPwd.Name = "TBConfirmPwd";
            this.TBConfirmPwd.Size = new System.Drawing.Size(248, 25);
            this.TBConfirmPwd.TabIndex = 6;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(215, 185);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(118, 29);
            this.BtnConfirm.TabIndex = 7;
            this.BtnConfirm.Text = "验证";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(356, 185);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(118, 29);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 250);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TBConfirmPwd);
            this.Controls.Add(this.LblConfirmPwd);
            this.Controls.Add(this.LblCurrentPwd);
            this.Controls.Add(this.LblCurrentPwdTip);
            this.Controls.Add(this.LblSetPwd);
            this.Controls.Add(this.BtnSetPwd);
            this.Controls.Add(this.TBSetPwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超级管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSetPwd;
        private System.Windows.Forms.Button BtnSetPwd;
        private System.Windows.Forms.Label LblSetPwd;
        private System.Windows.Forms.Label LblCurrentPwdTip;
        private System.Windows.Forms.Label LblCurrentPwd;
        private System.Windows.Forms.Label LblConfirmPwd;
        private System.Windows.Forms.TextBox TBConfirmPwd;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnExit;
    }
}

