namespace CommunalComputerManager.Gui
{
    partial class BandWList
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
            this.BandWList_lbl_whitelist = new System.Windows.Forms.Label();
            this.BandWList_lbl_add = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BandWList_btn_add = new System.Windows.Forms.Button();
            this.BandWList_btn_reset = new System.Windows.Forms.Button();
            this.BandWList_btn_OK = new System.Windows.Forms.Button();
            this.BandWList_btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(64, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 400);
            this.panel1.TabIndex = 0;
            // 
            // BandWList_lbl_whitelist
            // 
            this.BandWList_lbl_whitelist.AutoSize = true;
            this.BandWList_lbl_whitelist.Location = new System.Drawing.Point(64, 13);
            this.BandWList_lbl_whitelist.Name = "BandWList_lbl_whitelist";
            this.BandWList_lbl_whitelist.Size = new System.Drawing.Size(52, 15);
            this.BandWList_lbl_whitelist.TabIndex = 1;
            this.BandWList_lbl_whitelist.Text = "白表：";
            // 
            // BandWList_lbl_add
            // 
            this.BandWList_lbl_add.AutoSize = true;
            this.BandWList_lbl_add.Location = new System.Drawing.Point(49, 456);
            this.BandWList_lbl_add.Name = "BandWList_lbl_add";
            this.BandWList_lbl_add.Size = new System.Drawing.Size(67, 15);
            this.BandWList_lbl_add.TabIndex = 2;
            this.BandWList_lbl_add.Text = "添加项：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(698, 25);
            this.textBox1.TabIndex = 3;
            // 
            // BandWList_btn_add
            // 
            this.BandWList_btn_add.Location = new System.Drawing.Point(826, 455);
            this.BandWList_btn_add.Name = "BandWList_btn_add";
            this.BandWList_btn_add.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_add.TabIndex = 4;
            this.BandWList_btn_add.Text = "添加";
            this.BandWList_btn_add.UseVisualStyleBackColor = true;
            // 
            // BandWList_btn_reset
            // 
            this.BandWList_btn_reset.Location = new System.Drawing.Point(244, 497);
            this.BandWList_btn_reset.Name = "BandWList_btn_reset";
            this.BandWList_btn_reset.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_reset.TabIndex = 5;
            this.BandWList_btn_reset.Text = "重置";
            this.BandWList_btn_reset.UseVisualStyleBackColor = true;
            // 
            // BandWList_btn_OK
            // 
            this.BandWList_btn_OK.Location = new System.Drawing.Point(426, 497);
            this.BandWList_btn_OK.Name = "BandWList_btn_OK";
            this.BandWList_btn_OK.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_OK.TabIndex = 6;
            this.BandWList_btn_OK.Text = "确定";
            this.BandWList_btn_OK.UseVisualStyleBackColor = true;
            this.BandWList_btn_OK.Click += new System.EventHandler(this.BandWList_btn_OK_Click);
            // 
            // BandWList_btn_cancel
            // 
            this.BandWList_btn_cancel.Location = new System.Drawing.Point(598, 497);
            this.BandWList_btn_cancel.Name = "BandWList_btn_cancel";
            this.BandWList_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_cancel.TabIndex = 7;
            this.BandWList_btn_cancel.Text = "取消";
            this.BandWList_btn_cancel.UseVisualStyleBackColor = true;
            this.BandWList_btn_cancel.Click += new System.EventHandler(this.BandWList_btn_cancel_Click);
            // 
            // BandWList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BandWList_btn_cancel);
            this.Controls.Add(this.BandWList_btn_OK);
            this.Controls.Add(this.BandWList_btn_reset);
            this.Controls.Add(this.BandWList_btn_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BandWList_lbl_add);
            this.Controls.Add(this.BandWList_lbl_whitelist);
            this.Controls.Add(this.panel1);
            this.Name = "BandWList";
            this.Text = "BandWList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BandWList_lbl_whitelist;
        private System.Windows.Forms.Label BandWList_lbl_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BandWList_btn_add;
        private System.Windows.Forms.Button BandWList_btn_reset;
        private System.Windows.Forms.Button BandWList_btn_OK;
        private System.Windows.Forms.Button BandWList_btn_cancel;
    }
}