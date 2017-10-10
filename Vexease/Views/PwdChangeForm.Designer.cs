namespace Vexease.Views
{
    partial class PwdChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PwdChangeForm));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtRe = new System.Windows.Forms.MaskedTextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtNewPwd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(91, 250);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(300, 30);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Mistral", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(141, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(188, 83);
            this.LblTitle.TabIndex = 14;
            this.LblTitle.Text = "Vexease";
            // 
            // TxtRe
            // 
            this.TxtRe.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtRe.Location = new System.Drawing.Point(91, 169);
            this.TxtRe.Name = "TxtRe";
            this.TxtRe.Size = new System.Drawing.Size(300, 28);
            this.TxtRe.TabIndex = 12;
            this.TxtRe.Enter += new System.EventHandler(this.TxtRe_Enter);
            this.TxtRe.Leave += new System.EventHandler(this.TxtRe_Leave);
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOk.Location = new System.Drawing.Point(91, 214);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(300, 30);
            this.BtnOk.TabIndex = 13;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "确认";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtNewPwd
            // 
            this.TxtNewPwd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNewPwd.Location = new System.Drawing.Point(91, 135);
            this.TxtNewPwd.Name = "TxtNewPwd";
            this.TxtNewPwd.Size = new System.Drawing.Size(300, 28);
            this.TxtNewPwd.TabIndex = 16;
            this.TxtNewPwd.Enter += new System.EventHandler(this.TxtNewPwd_Enter);
            this.TxtNewPwd.Leave += new System.EventHandler(this.TxtNewPwd_Leave);
            // 
            // PwdChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.TxtNewPwd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtRe);
            this.Controls.Add(this.BtnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PwdChangeForm";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.PwdChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.MaskedTextBox TxtRe;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.MaskedTextBox TxtNewPwd;
    }
}