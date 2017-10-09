namespace Vexease.Views
{
    partial class ListByPathSetForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "QQScLauncher.exe",
            "‪D:\\cci\\Bin\\QQScLauncher.exe"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "videocutter.exe",
            "D:\\cci\\视频剪切合并器"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListByPathSetForm));
            this.GBBListSetByPath = new System.Windows.Forms.GroupBox();
            this.BtnEditBItem = new System.Windows.Forms.Button();
            this.BtnDeleteBItem = new System.Windows.Forms.Button();
            this.BtnNewBItem = new System.Windows.Forms.Button();
            this.LvBListByPath = new System.Windows.Forms.ListView();
            this.ColBListVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColBListValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GBWListByPath = new System.Windows.Forms.GroupBox();
            this.BtnEditWItem = new System.Windows.Forms.Button();
            this.BtnDeleteWItem = new System.Windows.Forms.Button();
            this.BtnNewWItem = new System.Windows.Forms.Button();
            this.LvWListByPath = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBBListSetByPath.SuspendLayout();
            this.GBWListByPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBBListSetByPath
            // 
            this.GBBListSetByPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBBListSetByPath.Controls.Add(this.BtnEditBItem);
            this.GBBListSetByPath.Controls.Add(this.BtnDeleteBItem);
            this.GBBListSetByPath.Controls.Add(this.BtnNewBItem);
            this.GBBListSetByPath.Controls.Add(this.LvBListByPath);
            this.GBBListSetByPath.Location = new System.Drawing.Point(40, 40);
            this.GBBListSetByPath.Name = "GBBListSetByPath";
            this.GBBListSetByPath.Size = new System.Drawing.Size(720, 300);
            this.GBBListSetByPath.TabIndex = 0;
            this.GBBListSetByPath.TabStop = false;
            this.GBBListSetByPath.Text = "黑名单";
            // 
            // BtnEditBItem
            // 
            this.BtnEditBItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditBItem.Location = new System.Drawing.Point(518, 255);
            this.BtnEditBItem.Name = "BtnEditBItem";
            this.BtnEditBItem.Size = new System.Drawing.Size(90, 30);
            this.BtnEditBItem.TabIndex = 3;
            this.BtnEditBItem.TabStop = false;
            this.BtnEditBItem.Text = "编辑";
            this.BtnEditBItem.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteBItem
            // 
            this.BtnDeleteBItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBItem.Location = new System.Drawing.Point(614, 255);
            this.BtnDeleteBItem.Name = "BtnDeleteBItem";
            this.BtnDeleteBItem.Size = new System.Drawing.Size(90, 30);
            this.BtnDeleteBItem.TabIndex = 2;
            this.BtnDeleteBItem.TabStop = false;
            this.BtnDeleteBItem.Text = "删除";
            this.BtnDeleteBItem.UseVisualStyleBackColor = true;
            // 
            // BtnNewBItem
            // 
            this.BtnNewBItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewBItem.Location = new System.Drawing.Point(422, 255);
            this.BtnNewBItem.Name = "BtnNewBItem";
            this.BtnNewBItem.Size = new System.Drawing.Size(90, 30);
            this.BtnNewBItem.TabIndex = 1;
            this.BtnNewBItem.TabStop = false;
            this.BtnNewBItem.Text = "新建";
            this.BtnNewBItem.UseVisualStyleBackColor = true;
            // 
            // LvBListByPath
            // 
            this.LvBListByPath.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvBListByPath.AllowDrop = true;
            this.LvBListByPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColBListVar,
            this.ColBListValue});
            this.LvBListByPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvBListByPath.FullRowSelect = true;
            this.LvBListByPath.GridLines = true;
            this.LvBListByPath.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LvBListByPath.LabelEdit = true;
            this.LvBListByPath.LabelWrap = false;
            this.LvBListByPath.Location = new System.Drawing.Point(3, 21);
            this.LvBListByPath.MultiSelect = false;
            this.LvBListByPath.Name = "LvBListByPath";
            this.LvBListByPath.Size = new System.Drawing.Size(714, 228);
            this.LvBListByPath.TabIndex = 0;
            this.LvBListByPath.UseCompatibleStateImageBehavior = false;
            this.LvBListByPath.View = System.Windows.Forms.View.Details;
            // 
            // ColBListVar
            // 
            this.ColBListVar.Text = "变量";
            this.ColBListVar.Width = 100;
            // 
            // ColBListValue
            // 
            this.ColBListValue.Text = "值";
            this.ColBListValue.Width = 649;
            // 
            // GBWListByPath
            // 
            this.GBWListByPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBWListByPath.Controls.Add(this.BtnEditWItem);
            this.GBWListByPath.Controls.Add(this.BtnDeleteWItem);
            this.GBWListByPath.Controls.Add(this.BtnNewWItem);
            this.GBWListByPath.Controls.Add(this.LvWListByPath);
            this.GBWListByPath.Location = new System.Drawing.Point(40, 380);
            this.GBWListByPath.Name = "GBWListByPath";
            this.GBWListByPath.Size = new System.Drawing.Size(720, 300);
            this.GBWListByPath.TabIndex = 1;
            this.GBWListByPath.TabStop = false;
            this.GBWListByPath.Text = "白名单";
            // 
            // BtnEditWItem
            // 
            this.BtnEditWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditWItem.Location = new System.Drawing.Point(518, 255);
            this.BtnEditWItem.Name = "BtnEditWItem";
            this.BtnEditWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnEditWItem.TabIndex = 3;
            this.BtnEditWItem.TabStop = false;
            this.BtnEditWItem.Text = "编辑";
            this.BtnEditWItem.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteWItem
            // 
            this.BtnDeleteWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteWItem.Location = new System.Drawing.Point(614, 255);
            this.BtnDeleteWItem.Name = "BtnDeleteWItem";
            this.BtnDeleteWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnDeleteWItem.TabIndex = 2;
            this.BtnDeleteWItem.TabStop = false;
            this.BtnDeleteWItem.Text = "删除";
            this.BtnDeleteWItem.UseVisualStyleBackColor = true;
            // 
            // BtnNewWItem
            // 
            this.BtnNewWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewWItem.Location = new System.Drawing.Point(422, 255);
            this.BtnNewWItem.Name = "BtnNewWItem";
            this.BtnNewWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnNewWItem.TabIndex = 1;
            this.BtnNewWItem.TabStop = false;
            this.BtnNewWItem.Text = "新建";
            this.BtnNewWItem.UseVisualStyleBackColor = true;
            // 
            // LvWListByPath
            // 
            this.LvWListByPath.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvWListByPath.AllowDrop = true;
            this.LvWListByPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LvWListByPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvWListByPath.FullRowSelect = true;
            this.LvWListByPath.GridLines = true;
            this.LvWListByPath.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LvWListByPath.LabelEdit = true;
            this.LvWListByPath.LabelWrap = false;
            this.LvWListByPath.Location = new System.Drawing.Point(3, 21);
            this.LvWListByPath.MultiSelect = false;
            this.LvWListByPath.Name = "LvWListByPath";
            this.LvWListByPath.Size = new System.Drawing.Size(714, 228);
            this.LvWListByPath.TabIndex = 0;
            this.LvWListByPath.UseCompatibleStateImageBehavior = false;
            this.LvWListByPath.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "变量";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "值";
            this.columnHeader2.Width = 649;
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Location = new System.Drawing.Point(558, 711);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 30);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(654, 711);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 30);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ListByPathSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GBWListByPath);
            this.Controls.Add(this.GBBListSetByPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListByPathSetForm";
            this.Text = "进程黑白名单（路径）设置";
            this.Load += new System.EventHandler(this.WListSetForm_Load);
            this.GBBListSetByPath.ResumeLayout(false);
            this.GBWListByPath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBBListSetByPath;
        private System.Windows.Forms.ListView LvBListByPath;
        private System.Windows.Forms.ColumnHeader ColBListVar;
        private System.Windows.Forms.ColumnHeader ColBListValue;
        private System.Windows.Forms.Button BtnEditBItem;
        private System.Windows.Forms.Button BtnDeleteBItem;
        private System.Windows.Forms.Button BtnNewBItem;
        private System.Windows.Forms.GroupBox GBWListByPath;
        private System.Windows.Forms.Button BtnEditWItem;
        private System.Windows.Forms.Button BtnDeleteWItem;
        private System.Windows.Forms.Button BtnNewWItem;
        private System.Windows.Forms.ListView LvWListByPath;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
    }
}