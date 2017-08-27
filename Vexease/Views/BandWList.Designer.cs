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
            this.ProcessInfo = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.pushPanelItem2 = new CCWin.SkinControl.PushPanelItem();
            this.BtnDel = new System.Windows.Forms.Button();
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
            // ProcessInfo
            // 
            this.ProcessInfo.Location = new System.Drawing.Point(122, 453);
            this.ProcessInfo.Name = "ProcessInfo";
            this.ProcessInfo.Size = new System.Drawing.Size(698, 25);
            this.ProcessInfo.TabIndex = 3;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(826, 455);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "浏览";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(835, 312);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "重置";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(191, 497);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(617, 497);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(835, 108);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(834, 213);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 10;
            this.BtnDel.Text = "删除";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
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
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.ProcessInfo);
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
        private System.Windows.Forms.TextBox ProcessInfo;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private CCWin.SkinControl.PushPanelItem pushPanelItem2;
        private System.Windows.Forms.Button BtnDel;
        private CCWin.SkinControl.SkinListBox BandWList_ltbox;
    }
}