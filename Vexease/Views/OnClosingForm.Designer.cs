namespace Vexease.Views
{
    partial class OnClosingForm
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
            this.SplClose = new System.Windows.Forms.Splitter();
            this.LblOnClosing = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.RdoMin = new System.Windows.Forms.RadioButton();
            this.RdoClose = new System.Windows.Forms.RadioButton();
            this.ChkNoNotify = new System.Windows.Forms.CheckBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplClose
            // 
            this.SplClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplClose.Location = new System.Drawing.Point(0, 0);
            this.SplClose.Name = "SplClose";
            this.SplClose.Size = new System.Drawing.Size(282, 42);
            this.SplClose.TabIndex = 0;
            this.SplClose.TabStop = false;
            // 
            // LblOnClosing
            // 
            this.LblOnClosing.AutoSize = true;
            this.LblOnClosing.Location = new System.Drawing.Point(8, 57);
            this.LblOnClosing.Name = "LblOnClosing";
            this.LblOnClosing.Size = new System.Drawing.Size(262, 15);
            this.LblOnClosing.TabIndex = 1;
            this.LblOnClosing.Text = "当前为管理员模式，点击关闭按钮时：";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.Location = new System.Drawing.Point(6, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(152, 28);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "关闭提示：";
            // 
            // RdoMin
            // 
            this.RdoMin.AutoSize = true;
            this.RdoMin.Location = new System.Drawing.Point(62, 102);
            this.RdoMin.Name = "RdoMin";
            this.RdoMin.Size = new System.Drawing.Size(148, 19);
            this.RdoMin.TabIndex = 3;
            this.RdoMin.TabStop = true;
            this.RdoMin.Text = "最小化到系统托盘";
            this.RdoMin.UseVisualStyleBackColor = true;
            this.RdoMin.CheckedChanged += new System.EventHandler(this.RdoMin_CheckedChanged);
            // 
            // RdoClose
            // 
            this.RdoClose.AutoSize = true;
            this.RdoClose.Location = new System.Drawing.Point(62, 152);
            this.RdoClose.Name = "RdoClose";
            this.RdoClose.Size = new System.Drawing.Size(88, 19);
            this.RdoClose.TabIndex = 4;
            this.RdoClose.TabStop = true;
            this.RdoClose.Text = "关闭程序";
            this.RdoClose.UseVisualStyleBackColor = true;
            // 
            // ChkNoNotify
            // 
            this.ChkNoNotify.AutoSize = true;
            this.ChkNoNotify.Location = new System.Drawing.Point(13, 222);
            this.ChkNoNotify.Name = "ChkNoNotify";
            this.ChkNoNotify.Size = new System.Drawing.Size(89, 19);
            this.ChkNoNotify.TabIndex = 5;
            this.ChkNoNotify.Text = "不再提醒";
            this.ChkNoNotify.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(183, 222);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblTip
            // 
            this.LblTip.AutoSize = true;
            this.LblTip.Location = new System.Drawing.Point(37, 183);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(0, 15);
            this.LblTip.TabIndex = 7;
            // 
            // OnClosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.LblTip);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.ChkNoNotify);
            this.Controls.Add(this.RdoClose);
            this.Controls.Add(this.RdoMin);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblOnClosing);
            this.Controls.Add(this.SplClose);
            this.Name = "OnClosingForm";
            this.Text = "OnClosingForm";
            this.Load += new System.EventHandler(this.OnClosingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter SplClose;
        private System.Windows.Forms.Label LblOnClosing;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.RadioButton RdoMin;
        private System.Windows.Forms.RadioButton RdoClose;
        private System.Windows.Forms.CheckBox ChkNoNotify;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblTip;
    }
}