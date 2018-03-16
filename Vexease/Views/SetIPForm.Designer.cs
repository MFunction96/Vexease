namespace Vexease.Views
{
    partial class SetIpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetIpForm));
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
            this.LblIP.Location = new System.Drawing.Point(149, 71);
            this.LblIP.Name = "LblIP";
            this.LblIP.Size = new System.Drawing.Size(68, 15);
            this.LblIP.TabIndex = 0;
            this.LblIP.Text = "IP地址：";
            // 
            // LblIPNow
            // 
            this.LblIPNow.AutoSize = true;
            this.LblIPNow.Location = new System.Drawing.Point(223, 71);
            this.LblIPNow.Name = "LblIPNow";
            this.LblIPNow.Size = new System.Drawing.Size(119, 15);
            this.LblIPNow.TabIndex = 1;
            this.LblIPNow.Text = "121.194.80.191";
            // 
            // LblIPSet
            // 
            this.LblIPSet.AutoSize = true;
            this.LblIPSet.Location = new System.Drawing.Point(119, 125);
            this.LblIPSet.Name = "LblIPSet";
            this.LblIPSet.Size = new System.Drawing.Size(98, 15);
            this.LblIPSet.TabIndex = 2;
            this.LblIPSet.Text = "设置IP地址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 25);
            this.textBox1.TabIndex = 3;
            // 
            // BtnTest
            // 
            this.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTest.Location = new System.Drawing.Point(226, 198);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 30);
            this.BtnTest.TabIndex = 4;
            this.BtnTest.TabStop = false;
            this.BtnTest.Text = "测试";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(226, 198);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 30);
            this.BtnOk.TabIndex = 5;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Visible = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(419, 198);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 30);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SetIpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 253);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblIPSet);
            this.Controls.Add(this.LblIPNow);
            this.Controls.Add(this.LblIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetIpForm";
            this.Text = "管理终端设置";
            this.Load += new System.EventHandler(this.SetIPForm_Load);
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