namespace Vexease.Views
{
    partial class SetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForm));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblProc = new System.Windows.Forms.Label();
            this.TxtBoxProc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Location = new System.Drawing.Point(195, 99);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 40);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(423, 99);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 40);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblProc
            // 
            this.LblProc.AutoSize = true;
            this.LblProc.Location = new System.Drawing.Point(40, 50);
            this.LblProc.Name = "LblProc";
            this.LblProc.Size = new System.Drawing.Size(82, 15);
            this.LblProc.TabIndex = 2;
            this.LblProc.Text = "进程名称：";
            // 
            // TxtBoxProc
            // 
            this.TxtBoxProc.BackColor = System.Drawing.Color.White;
            this.TxtBoxProc.Location = new System.Drawing.Point(128, 47);
            this.TxtBoxProc.Name = "TxtBoxProc";
            this.TxtBoxProc.Size = new System.Drawing.Size(482, 25);
            this.TxtBoxProc.TabIndex = 3;
            // 
            // Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 151);
            this.Controls.Add(this.TxtBoxProc);
            this.Controls.Add(this.LblProc);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Set";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.Set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblProc;
        private System.Windows.Forms.TextBox TxtBoxProc;
    }
}