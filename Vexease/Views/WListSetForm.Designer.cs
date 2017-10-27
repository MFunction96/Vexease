namespace Vexease.Views
{
    partial class WListSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WListSetForm));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.GBWListByName = new System.Windows.Forms.GroupBox();
            this.BtnEditWItem = new System.Windows.Forms.Button();
            this.BtnDeleteWItem = new System.Windows.Forms.Button();
            this.BtnNewWItem = new System.Windows.Forms.Button();
            this.LvWListByName = new System.Windows.Forms.ListView();
            this.ColBListByName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GBWListByName.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(642, 286);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 40);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Location = new System.Drawing.Point(531, 286);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 40);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.TabStop = false;
            this.BtnOk.Text = "确定";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // GBWListByName
            // 
            this.GBWListByName.Controls.Add(this.BtnEditWItem);
            this.GBWListByName.Controls.Add(this.BtnDeleteWItem);
            this.GBWListByName.Controls.Add(this.BtnNewWItem);
            this.GBWListByName.Controls.Add(this.LvWListByName);
            this.GBWListByName.Location = new System.Drawing.Point(31, 26);
            this.GBWListByName.Name = "GBWListByName";
            this.GBWListByName.Size = new System.Drawing.Size(720, 250);
            this.GBWListByName.TabIndex = 6;
            this.GBWListByName.TabStop = false;
            this.GBWListByName.Text = "白名单（名称）";
            // 
            // BtnEditWItem
            // 
            this.BtnEditWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditWItem.Location = new System.Drawing.Point(624, 169);
            this.BtnEditWItem.Name = "BtnEditWItem";
            this.BtnEditWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnEditWItem.TabIndex = 4;
            this.BtnEditWItem.TabStop = false;
            this.BtnEditWItem.Text = "编辑";
            this.BtnEditWItem.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteWItem
            // 
            this.BtnDeleteWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteWItem.Location = new System.Drawing.Point(624, 205);
            this.BtnDeleteWItem.Name = "BtnDeleteWItem";
            this.BtnDeleteWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnDeleteWItem.TabIndex = 3;
            this.BtnDeleteWItem.TabStop = false;
            this.BtnDeleteWItem.Text = "删除";
            this.BtnDeleteWItem.UseVisualStyleBackColor = true;
            // 
            // BtnNewWItem
            // 
            this.BtnNewWItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewWItem.Location = new System.Drawing.Point(624, 133);
            this.BtnNewWItem.Name = "BtnNewWItem";
            this.BtnNewWItem.Size = new System.Drawing.Size(90, 30);
            this.BtnNewWItem.TabIndex = 2;
            this.BtnNewWItem.TabStop = false;
            this.BtnNewWItem.Text = "新建";
            this.BtnNewWItem.UseVisualStyleBackColor = true;
            // 
            // LvWListByName
            // 
            this.LvWListByName.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LvWListByName.AllowDrop = true;
            this.LvWListByName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColBListByName});
            this.LvWListByName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LvWListByName.FullRowSelect = true;
            this.LvWListByName.GridLines = true;
            this.LvWListByName.LabelEdit = true;
            this.LvWListByName.LabelWrap = false;
            this.LvWListByName.Location = new System.Drawing.Point(3, 21);
            this.LvWListByName.MultiSelect = false;
            this.LvWListByName.Name = "LvWListByName";
            this.LvWListByName.Size = new System.Drawing.Size(610, 226);
            this.LvWListByName.TabIndex = 1;
            this.LvWListByName.UseCompatibleStateImageBehavior = false;
            this.LvWListByName.View = System.Windows.Forms.View.Details;
            // 
            // ColBListByName
            // 
            this.ColBListByName.Text = "名称";
            this.ColBListByName.Width = 604;
            // 
            // WListSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GBWListByName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WListSetForm";
            this.Text = "进程白名单（名称）设置";
            this.Load += new System.EventHandler(this.WListSetForm_Load);
            this.GBWListByName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.GroupBox GBWListByName;
        private System.Windows.Forms.Button BtnEditWItem;
        private System.Windows.Forms.Button BtnDeleteWItem;
        private System.Windows.Forms.Button BtnNewWItem;
        private System.Windows.Forms.ListView LvWListByName;
        private System.Windows.Forms.ColumnHeader ColBListByName;
    }
}