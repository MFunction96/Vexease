namespace Vexease.Views
{
    partial class BandWListSetForm
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
            "第一项变量",
            "C:第一项的值"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("idonotknow");
            this.GBBListByName = new System.Windows.Forms.GroupBox();
            this.BtnEditBitem = new System.Windows.Forms.Button();
            this.BtnCancelBItem = new System.Windows.Forms.Button();
            this.BtnNewBItem = new System.Windows.Forms.Button();
            this.LvBListByName = new System.Windows.Forms.ListView();
            this.ColBListByName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBBListByName.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBBListByName
            // 
            this.GBBListByName.Controls.Add(this.BtnEditBitem);
            this.GBBListByName.Controls.Add(this.BtnCancelBItem);
            this.GBBListByName.Controls.Add(this.BtnNewBItem);
            this.GBBListByName.Controls.Add(this.LvBListByName);
            this.GBBListByName.Location = new System.Drawing.Point(40, 40);
            this.GBBListByName.Name = "GBBListByName";
            this.GBBListByName.Size = new System.Drawing.Size(720, 250);
            this.GBBListByName.TabIndex = 3;
            this.GBBListByName.TabStop = false;
            this.GBBListByName.Text = "黑名单（名称）";
            // 
            // BtnEditBitem
            // 
            this.BtnEditBitem.Location = new System.Drawing.Point(624, 169);
            this.BtnEditBitem.Name = "BtnEditBitem";
            this.BtnEditBitem.Size = new System.Drawing.Size(90, 30);
            this.BtnEditBitem.TabIndex = 4;
            this.BtnEditBitem.Text = "编辑";
            this.BtnEditBitem.UseVisualStyleBackColor = true;
            // 
            // BtnCancelBItem
            // 
            this.BtnCancelBItem.Location = new System.Drawing.Point(624, 205);
            this.BtnCancelBItem.Name = "BtnCancelBItem";
            this.BtnCancelBItem.Size = new System.Drawing.Size(90, 30);
            this.BtnCancelBItem.TabIndex = 3;
            this.BtnCancelBItem.Text = "删除";
            this.BtnCancelBItem.UseVisualStyleBackColor = true;
            // 
            // BtnNewBItem
            // 
            this.BtnNewBItem.Location = new System.Drawing.Point(624, 133);
            this.BtnNewBItem.Name = "BtnNewBItem";
            this.BtnNewBItem.Size = new System.Drawing.Size(90, 30);
            this.BtnNewBItem.TabIndex = 2;
            this.BtnNewBItem.Text = "新建";
            this.BtnNewBItem.UseVisualStyleBackColor = true;
            // 
            // LvBListByName
            // 
            this.LvBListByName.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvBListByName.AllowDrop = true;
            this.LvBListByName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColBListByName});
            this.LvBListByName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LvBListByName.FullRowSelect = true;
            this.LvBListByName.GridLines = true;
            this.LvBListByName.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LvBListByName.LabelEdit = true;
            this.LvBListByName.LabelWrap = false;
            this.LvBListByName.Location = new System.Drawing.Point(3, 21);
            this.LvBListByName.MultiSelect = false;
            this.LvBListByName.Name = "LvBListByName";
            this.LvBListByName.Size = new System.Drawing.Size(610, 226);
            this.LvBListByName.TabIndex = 1;
            this.LvBListByName.UseCompatibleStateImageBehavior = false;
            this.LvBListByName.View = System.Windows.Forms.View.List;
            // 
            // ColBListByName
            // 
            this.ColBListByName.Width = 604;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(540, 300);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 40);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(651, 300);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 40);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BandWListSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GBBListByName);
            this.Name = "BandWListSetForm";
            this.Text = "进程黑名单（名称）设置";
            this.Load += new System.EventHandler(this.BandWListSetForm_Load);
            this.GBBListByName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBBListByName;
        private System.Windows.Forms.ListView LvBListByName;
        private System.Windows.Forms.Button BtnEditBitem;
        private System.Windows.Forms.Button BtnCancelBItem;
        private System.Windows.Forms.Button BtnNewBItem;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ColumnHeader ColBListByName;
    }
}