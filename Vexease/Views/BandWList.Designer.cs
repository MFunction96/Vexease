namespace Vexease.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandWList));
            this.BandWList_lbl_whitelist = new System.Windows.Forms.Label();
            this.BandWList_lbl_add = new System.Windows.Forms.Label();
            this.BandWList_txtbox = new System.Windows.Forms.TextBox();
            this.BandWList_btn_browse = new System.Windows.Forms.Button();
            this.BandWList_btn_reset = new System.Windows.Forms.Button();
            this.BandWList_btn_OK = new System.Windows.Forms.Button();
            this.BandWList_btn_cancel = new System.Windows.Forms.Button();
            this.BandWList_btn_add = new System.Windows.Forms.Button();
            this.pushPanelItem2 = new CCWin.SkinControl.PushPanelItem();
            this.BandWList_btn_cnl = new System.Windows.Forms.Button();
            this.BandWList_ltbox = new CCWin.SkinControl.SkinListBox();
            this.SuspendLayout();
            // 
            // BandWList_lbl_whitelist
            // 
            this.BandWList_lbl_whitelist.AutoSize = true;
            this.BandWList_lbl_whitelist.Location = new System.Drawing.Point(49, 50);
            this.BandWList_lbl_whitelist.Name = "BandWList_lbl_whitelist";
            this.BandWList_lbl_whitelist.Size = new System.Drawing.Size(202, 15);
            this.BandWList_lbl_whitelist.TabIndex = 1;
            this.BandWList_lbl_whitelist.Text = "白表（可拖动文件入框中）：";
            this.BandWList_lbl_whitelist.Click += new System.EventHandler(this.BandWList_lbl_whitelist_Click);
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
            // BandWList_txtbox
            // 
            this.BandWList_txtbox.Location = new System.Drawing.Point(122, 453);
            this.BandWList_txtbox.Name = "BandWList_txtbox";
            this.BandWList_txtbox.Size = new System.Drawing.Size(698, 25);
            this.BandWList_txtbox.TabIndex = 3;
            // 
            // BandWList_btn_browse
            // 
            this.BandWList_btn_browse.Location = new System.Drawing.Point(826, 455);
            this.BandWList_btn_browse.Name = "BandWList_btn_browse";
            this.BandWList_btn_browse.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_browse.TabIndex = 4;
            this.BandWList_btn_browse.Text = "浏览";
            this.BandWList_btn_browse.UseVisualStyleBackColor = true;
            // 
            // BandWList_btn_reset
            // 
            this.BandWList_btn_reset.Location = new System.Drawing.Point(835, 312);
            this.BandWList_btn_reset.Name = "BandWList_btn_reset";
            this.BandWList_btn_reset.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_reset.TabIndex = 5;
            this.BandWList_btn_reset.Text = "重置";
            this.BandWList_btn_reset.UseVisualStyleBackColor = true;
            // 
            // BandWList_btn_OK
            // 
            this.BandWList_btn_OK.Location = new System.Drawing.Point(191, 497);
            this.BandWList_btn_OK.Name = "BandWList_btn_OK";
            this.BandWList_btn_OK.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_OK.TabIndex = 6;
            this.BandWList_btn_OK.Text = "确定";
            this.BandWList_btn_OK.UseVisualStyleBackColor = true;
            this.BandWList_btn_OK.Click += new System.EventHandler(this.BandWList_btn_OK_Click);
            // 
            // BandWList_btn_cancel
            // 
            this.BandWList_btn_cancel.Location = new System.Drawing.Point(617, 497);
            this.BandWList_btn_cancel.Name = "BandWList_btn_cancel";
            this.BandWList_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_cancel.TabIndex = 7;
            this.BandWList_btn_cancel.Text = "取消";
            this.BandWList_btn_cancel.UseVisualStyleBackColor = true;
            this.BandWList_btn_cancel.Click += new System.EventHandler(this.BandWList_btn_cancel_Click);
            // 
            // BandWList_btn_add
            // 
            this.BandWList_btn_add.Location = new System.Drawing.Point(835, 108);
            this.BandWList_btn_add.Name = "BandWList_btn_add";
            this.BandWList_btn_add.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_add.TabIndex = 9;
            this.BandWList_btn_add.Text = "添加";
            this.BandWList_btn_add.UseVisualStyleBackColor = true;
            // 
            // pushPanelItem2
            // 
            this.pushPanelItem2.Border = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackNormal = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackPressed = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pushPanelItem2.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem2.Name = "pushPanelItem2";
            this.pushPanelItem2.Text = "程序员请注意睡眠和饮食0.0";
            // 
            // BandWList_btn_cnl
            // 
            this.BandWList_btn_cnl.Location = new System.Drawing.Point(834, 213);
            this.BandWList_btn_cnl.Name = "BandWList_btn_cnl";
            this.BandWList_btn_cnl.Size = new System.Drawing.Size(75, 23);
            this.BandWList_btn_cnl.TabIndex = 10;
            this.BandWList_btn_cnl.Text = "删除";
            this.BandWList_btn_cnl.UseVisualStyleBackColor = true;
            // 
            // BandWList_ltbox
            // 
            this.BandWList_ltbox.AllowDrop = true;
            this.BandWList_ltbox.Back = null;
            this.BandWList_ltbox.ColumnWidth = 12;
            this.BandWList_ltbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BandWList_ltbox.FormattingEnabled = true;
            this.BandWList_ltbox.HorizontalScrollbar = true;
            this.BandWList_ltbox.ItemHeight = 20;
            this.BandWList_ltbox.ItemRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BandWList_ltbox.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("BandWList_ltbox.Items"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("BandWList_ltbox.Items1")))});
            this.BandWList_ltbox.Location = new System.Drawing.Point(52, 87);
            this.BandWList_ltbox.Name = "BandWList_ltbox";
            this.BandWList_ltbox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BandWList_ltbox.Size = new System.Drawing.Size(751, 344);
            this.BandWList_ltbox.TabIndex = 11;
            // 
            // BandWList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BandWList_ltbox);
            this.Controls.Add(this.BandWList_btn_cnl);
            this.Controls.Add(this.BandWList_btn_add);
            this.Controls.Add(this.BandWList_btn_cancel);
            this.Controls.Add(this.BandWList_btn_OK);
            this.Controls.Add(this.BandWList_btn_reset);
            this.Controls.Add(this.BandWList_btn_browse);
            this.Controls.Add(this.BandWList_txtbox);
            this.Controls.Add(this.BandWList_lbl_add);
            this.Controls.Add(this.BandWList_lbl_whitelist);
            this.Name = "BandWList";
            this.Text = "BandWList";
            this.Load += new System.EventHandler(this.BandWList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BandWList_lbl_whitelist;
        private System.Windows.Forms.Label BandWList_lbl_add;
        private System.Windows.Forms.TextBox BandWList_txtbox;
        private System.Windows.Forms.Button BandWList_btn_browse;
        private System.Windows.Forms.Button BandWList_btn_reset;
        private System.Windows.Forms.Button BandWList_btn_OK;
        private System.Windows.Forms.Button BandWList_btn_cancel;
        private System.Windows.Forms.Button BandWList_btn_add;
        private CCWin.SkinControl.PushPanelItem pushPanelItem2;
        private System.Windows.Forms.Button BandWList_btn_cnl;
        private CCWin.SkinControl.SkinListBox BandWList_ltbox;
    }
}