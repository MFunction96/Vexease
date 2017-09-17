namespace Vexease.View
{
    partial class SetIPForm
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
            this.LblIP = new System.Windows.Forms.Label();
            this.LblIPNow = new System.Windows.Forms.Label();
            this.LblIPSet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIP
            // 
            this.LblIP.AutoSize = true;
            this.LblIP.Location = new System.Drawing.Point(184, 70);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(68, 15);
            this.LblIP.TabIndex = 0;
            this.LblIP.Text = "IP地址：";
            // 
            // LblIPNow
            // 
            this.LblIPNow.AutoSize = true;
            this.LblIPNow.Location = new System.Drawing.Point(258, 70);
            this.LblIPNow.Name = "LblIPNow";
            this.LblIPNow.Size = new System.Drawing.Size(53, 15);
            this.LblIPNow.TabIndex = 1;
            this.LblIPNow.Text = "暂无IP";
            // 
            // LblIPSet
            // 
            this.LblIPSet.AutoSize = true;
            this.LblIPSet.Location = new System.Drawing.Point(154, 160);
            this.LblIPSet.Name = "LblIPSet";
            this.LblIPSet.Size = new System.Drawing.Size(98, 15);
            this.LblIPSet.TabIndex = 2;
            this.LblIPSet.Text = "设置IP地址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 25);
            this.textBox1.TabIndex = 3;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(187, 268);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 4;
            this.BtnTest.Text = "测试";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(187, 268);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(416, 268);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // SetIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblIPSet);
            this.Controls.Add(this.LblIPNow);
            this.Controls.Add(this.LblIP);
            this.Name = "SetIPForm";
            this.Text = "管理终端设置界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIP;
        private System.Windows.Forms.Label LblIPNow;
        private System.Windows.Forms.Label LblIPSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
    }
}