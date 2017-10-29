namespace Vexease.Views
{
    partial class TestForm
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
            this.LblReg = new System.Windows.Forms.Label();
            this.BtnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblReg
            // 
            this.LblReg.AutoSize = true;
            this.LblReg.Location = new System.Drawing.Point(123, 80);
            this.LblReg.Name = "LblReg";
            this.LblReg.Size = new System.Drawing.Size(52, 15);
            this.LblReg.TabIndex = 0;
            this.LblReg.Text = "注册表";
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(231, 71);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(75, 23);
            this.BtnReg.TabIndex = 1;
            this.BtnReg.Text = "button1";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 510);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.LblReg);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblReg;
        private System.Windows.Forms.Button BtnReg;
    }
}