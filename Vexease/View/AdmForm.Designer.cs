using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vexease.View
{
    partial class AdmForm
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
        /// <summary>
        /// 设定控件绘制模式
        /// </summary>
        private void TabSet()
        {
            TabCtrlAdm.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabCtrlAdm.Alignment = TabAlignment.Left;
            TabCtrlAdm.SizeMode = TabSizeMode.Fixed;
            TabCtrlAdm.Multiline = true;
            
        }
        ///<summary>
        /// 重绘控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabCtrlAdm_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("微软雅黑", 10.0f);
            SolidBrush brush = new SolidBrush(Color.Black);
            RectangleF rectangleF = TabCtrlAdm.GetTabRect(e.Index);
            StringFormat sf = new StringFormat();//封装文本布局信息
            sf.LineAlignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Near;
            g.DrawString(this.Controls[e.Index].Text, font, brush, rectangleF, sf);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem MenuFileImport;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("CSDN的手机版的搜索功能有毒啊...");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("对瑜伽这东西再也没法直视了....知乎真是文盲之友啊");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmForm));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("这个世界充满了恶意.......");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("我明明只是一个菜鸡......");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "控制台状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "注册表状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "计划任务状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "控制面板状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "运行工具状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "任务管理器状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "命令指示符状态",
            "--",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "PowerShell状态",
            "--",
            "--"}, -1);
            this.MenuStripAdm = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHlepView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.FlwLytPnlUser = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnUser01 = new System.Windows.Forms.Button();
            this.BtnUser02 = new System.Windows.Forms.Button();
            this.TabCtrlAdm = new System.Windows.Forms.TabControl();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.LblAbout = new System.Windows.Forms.Label();
            this.TabConfigure = new System.Windows.Forms.TabPage();
            this.PnlWList = new System.Windows.Forms.Panel();
            this.LvWList = new System.Windows.Forms.ListView();
            this.TlStrWList = new System.Windows.Forms.ToolStrip();
            this.TlStrBtnWListSet = new System.Windows.Forms.ToolStripButton();
            this.TlStrBtnWList = new System.Windows.Forms.ToolStripButton();
            this.PnlBList = new System.Windows.Forms.Panel();
            this.LvBList = new System.Windows.Forms.ListView();
            this.TlStrBList = new System.Windows.Forms.ToolStrip();
            this.TlStrBtnBListSet = new System.Windows.Forms.ToolStripButton();
            this.TlStrBtnBList = new System.Windows.Forms.ToolStripButton();
            this.LvStatus = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDflt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TlStrStatus = new System.Windows.Forms.ToolStrip();
            this.TlStrBtnStatus = new System.Windows.Forms.ToolStripButton();
            this.TabOptimization = new System.Windows.Forms.TabPage();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            MenuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdm.SuspendLayout();
            this.FlwLytPnlUser.SuspendLayout();
            this.TabCtrlAdm.SuspendLayout();
            this.TabAbout.SuspendLayout();
            this.TabConfigure.SuspendLayout();
            this.PnlWList.SuspendLayout();
            this.TlStrWList.SuspendLayout();
            this.PnlBList.SuspendLayout();
            this.TlStrBList.SuspendLayout();
            this.TlStrStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFileImport
            // 
            MenuFileImport.Name = "MenuFileImport";
            MenuFileImport.Size = new System.Drawing.Size(114, 26);
            MenuFileImport.Text = "导入";
            // 
            // MenuStripAdm
            // 
            this.MenuStripAdm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSet,
            this.MenuHelp});
            this.MenuStripAdm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAdm.Name = "MenuStripAdm";
            this.MenuStripAdm.Size = new System.Drawing.Size(982, 28);
            this.MenuStripAdm.TabIndex = 0;
            this.MenuStripAdm.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MenuFileImport,
            this.MenuFileExport});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(51, 24);
            this.MenuFile.Text = "文件";
            // 
            // MenuFileExport
            // 
            this.MenuFileExport.Name = "MenuFileExport";
            this.MenuFileExport.Size = new System.Drawing.Size(114, 26);
            this.MenuFileExport.Text = "导出";
            // 
            // MenuSet
            // 
            this.MenuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSetIP});
            this.MenuSet.Name = "MenuSet";
            this.MenuSet.Size = new System.Drawing.Size(51, 24);
            this.MenuSet.Text = "设置";
            // 
            // MenuSetIP
            // 
            this.MenuSetIP.Name = "MenuSetIP";
            this.MenuSetIP.Size = new System.Drawing.Size(157, 26);
            this.MenuSetIP.Text = "设置IP地址";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHlepView,
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(51, 24);
            this.MenuHelp.Text = "帮助";
            // 
            // MenuHlepView
            // 
            this.MenuHlepView.Name = "MenuHlepView";
            this.MenuHlepView.Size = new System.Drawing.Size(174, 26);
            this.MenuHlepView.Text = "查看帮助文档";
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(174, 26);
            this.MenuHelpAbout.Text = "关于Vexease";
            // 
            // FlwLytPnlUser
            // 
            this.FlwLytPnlUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FlwLytPnlUser.Controls.Add(this.BtnUser01);
            this.FlwLytPnlUser.Controls.Add(this.BtnUser02);
            this.FlwLytPnlUser.Location = new System.Drawing.Point(0, 31);
            this.FlwLytPnlUser.Name = "FlwLytPnlUser";
            this.FlwLytPnlUser.Size = new System.Drawing.Size(985, 103);
            this.FlwLytPnlUser.TabIndex = 1;
            // 
            // BtnUser01
            // 
            this.BtnUser01.Location = new System.Drawing.Point(3, 3);
            this.BtnUser01.Name = "BtnUser01";
            this.BtnUser01.Size = new System.Drawing.Size(211, 100);
            this.BtnUser01.TabIndex = 0;
            this.BtnUser01.Text = "吃螃蟹的用户甲...";
            this.BtnUser01.UseVisualStyleBackColor = true;
            // 
            // BtnUser02
            // 
            this.BtnUser02.Location = new System.Drawing.Point(220, 3);
            this.BtnUser02.Name = "BtnUser02";
            this.BtnUser02.Size = new System.Drawing.Size(228, 100);
            this.BtnUser02.TabIndex = 1;
            this.BtnUser02.Text = "拖进坑的用户2";
            this.BtnUser02.UseVisualStyleBackColor = true;
            // 
            // TabCtrlAdm
            // 
            this.TabCtrlAdm.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabCtrlAdm.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabCtrlAdm.Controls.Add(this.TabAbout);
            this.TabCtrlAdm.Controls.Add(this.TabConfigure);
            this.TabCtrlAdm.Controls.Add(this.TabOptimization);
            this.TabCtrlAdm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrlAdm.ImageList = this.ImageList;
            this.TabCtrlAdm.ItemSize = new System.Drawing.Size(50, 150);
            this.TabCtrlAdm.Location = new System.Drawing.Point(0, 140);
            this.TabCtrlAdm.Multiline = true;
            this.TabCtrlAdm.Name = "TabCtrlAdm";
            this.TabCtrlAdm.SelectedIndex = 0;
            this.TabCtrlAdm.Size = new System.Drawing.Size(985, 596);
            this.TabCtrlAdm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrlAdm.TabIndex = 3;
            this.TabCtrlAdm.TabStop = false;
            this.TabCtrlAdm.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabCtrlAdm_DrawItem);
            // 
            // TabAbout
            // 
            this.TabAbout.Controls.Add(this.LblAbout);
            this.TabAbout.Location = new System.Drawing.Point(160, 4);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(821, 588);
            this.TabAbout.TabIndex = 2;
            this.TabAbout.Text = "关于";
            this.TabAbout.UseVisualStyleBackColor = true;
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.Location = new System.Drawing.Point(248, 240);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(248, 15);
            this.LblAbout.TabIndex = 0;
            this.LblAbout.Text = "本菜鸡界面由阿内ki特别提供，科科";
            // 
            // TabConfigure
            // 
            this.TabConfigure.AutoScroll = true;
            this.TabConfigure.Controls.Add(this.PnlWList);
            this.TabConfigure.Controls.Add(this.TlStrWList);
            this.TabConfigure.Controls.Add(this.PnlBList);
            this.TabConfigure.Controls.Add(this.TlStrBList);
            this.TabConfigure.Controls.Add(this.LvStatus);
            this.TabConfigure.Controls.Add(this.TlStrStatus);
            this.TabConfigure.ImageIndex = 0;
            this.TabConfigure.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TabConfigure.Location = new System.Drawing.Point(160, 4);
            this.TabConfigure.Name = "TabConfigure";
            this.TabConfigure.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfigure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabConfigure.Size = new System.Drawing.Size(821, 588);
            this.TabConfigure.TabIndex = 0;
            this.TabConfigure.Text = "系统配置";
            this.TabConfigure.UseVisualStyleBackColor = true;
            // 
            // PnlWList
            // 
            this.PnlWList.Controls.Add(this.LvWList);
            this.PnlWList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlWList.Location = new System.Drawing.Point(3, 381);
            this.PnlWList.Name = "PnlWList";
            this.PnlWList.Size = new System.Drawing.Size(815, 100);
            this.PnlWList.TabIndex = 6;
            // 
            // LvWList
            // 
            this.LvWList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvWList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LvWList.Location = new System.Drawing.Point(0, 0);
            this.LvWList.Name = "LvWList";
            this.LvWList.Size = new System.Drawing.Size(815, 100);
            this.LvWList.TabIndex = 0;
            this.LvWList.UseCompatibleStateImageBehavior = false;
            this.LvWList.View = System.Windows.Forms.View.List;
            // 
            // TlStrWList
            // 
            this.TlStrWList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TlStrWList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrBtnWListSet,
            this.TlStrBtnWList});
            this.TlStrWList.Location = new System.Drawing.Point(3, 354);
            this.TlStrWList.Name = "TlStrWList";
            this.TlStrWList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TlStrWList.Size = new System.Drawing.Size(815, 27);
            this.TlStrWList.TabIndex = 8;
            this.TlStrWList.Text = "toolStrip1";
            // 
            // TlStrBtnWListSet
            // 
            this.TlStrBtnWListSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlStrBtnWListSet.Image = ((System.Drawing.Image)(resources.GetObject("TlStrBtnWListSet.Image")));
            this.TlStrBtnWListSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrBtnWListSet.Name = "TlStrBtnWListSet";
            this.TlStrBtnWListSet.Size = new System.Drawing.Size(24, 24);
            this.TlStrBtnWListSet.Text = "设置";
            this.TlStrBtnWListSet.Click += new System.EventHandler(this.TlStrBtnWListSet_Click);
            // 
            // TlStrBtnWList
            // 
            this.TlStrBtnWList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TlStrBtnWList.AutoSize = false;
            this.TlStrBtnWList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrBtnWList.Image = ((System.Drawing.Image)(resources.GetObject("TlStrBtnWList.Image")));
            this.TlStrBtnWList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrBtnWList.Name = "TlStrBtnWList";
            this.TlStrBtnWList.Size = new System.Drawing.Size(500, 24);
            this.TlStrBtnWList.Text = "<<白名单(n)";
            this.TlStrBtnWList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TlStrBtnWList.Click += new System.EventHandler(this.TlStrBtnWList_Click);
            // 
            // PnlBList
            // 
            this.PnlBList.Controls.Add(this.LvBList);
            this.PnlBList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBList.Location = new System.Drawing.Point(3, 254);
            this.PnlBList.Name = "PnlBList";
            this.PnlBList.Size = new System.Drawing.Size(815, 100);
            this.PnlBList.TabIndex = 5;
            // 
            // LvBList
            // 
            this.LvBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvBList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.LvBList.Location = new System.Drawing.Point(0, 0);
            this.LvBList.Name = "LvBList";
            this.LvBList.Size = new System.Drawing.Size(815, 100);
            this.LvBList.TabIndex = 0;
            this.LvBList.UseCompatibleStateImageBehavior = false;
            this.LvBList.View = System.Windows.Forms.View.List;
            // 
            // TlStrBList
            // 
            this.TlStrBList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TlStrBList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrBtnBListSet,
            this.TlStrBtnBList});
            this.TlStrBList.Location = new System.Drawing.Point(3, 227);
            this.TlStrBList.Name = "TlStrBList";
            this.TlStrBList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TlStrBList.Size = new System.Drawing.Size(815, 27);
            this.TlStrBList.TabIndex = 7;
            this.TlStrBList.Text = "toolStrip1";
            // 
            // TlStrBtnBListSet
            // 
            this.TlStrBtnBListSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TlStrBtnBListSet.Image = ((System.Drawing.Image)(resources.GetObject("TlStrBtnBListSet.Image")));
            this.TlStrBtnBListSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrBtnBListSet.Name = "TlStrBtnBListSet";
            this.TlStrBtnBListSet.Size = new System.Drawing.Size(24, 24);
            this.TlStrBtnBListSet.Text = "设置";
            this.TlStrBtnBListSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TlStrBtnBListSet.Click += new System.EventHandler(this.TlStrBtnBListSet_Click);
            // 
            // TlStrBtnBList
            // 
            this.TlStrBtnBList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TlStrBtnBList.AutoSize = false;
            this.TlStrBtnBList.CheckOnClick = true;
            this.TlStrBtnBList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrBtnBList.Image = ((System.Drawing.Image)(resources.GetObject("TlStrBtnBList.Image")));
            this.TlStrBtnBList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TlStrBtnBList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrBtnBList.Name = "TlStrBtnBList";
            this.TlStrBtnBList.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TlStrBtnBList.Size = new System.Drawing.Size(500, 24);
            this.TlStrBtnBList.Text = "<<黑名单(n)";
            this.TlStrBtnBList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TlStrBtnBList.Click += new System.EventHandler(this.TlStrBtnBList_Click);
            // 
            // LvStatus
            // 
            this.LvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColDflt,
            this.ColNow,
            this.ColButton});
            this.LvStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.LvStatus.LabelWrap = false;
            this.LvStatus.Location = new System.Drawing.Point(3, 30);
            this.LvStatus.Name = "LvStatus";
            this.LvStatus.OwnerDraw = true;
            this.LvStatus.Size = new System.Drawing.Size(815, 197);
            this.LvStatus.TabIndex = 0;
            this.LvStatus.TabStop = false;
            this.LvStatus.UseCompatibleStateImageBehavior = false;
            this.LvStatus.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "名称";
            this.ColName.Width = 179;
            // 
            // ColDflt
            // 
            this.ColDflt.Text = "默认状态";
            this.ColDflt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColDflt.Width = 183;
            // 
            // ColNow
            // 
            this.ColNow.Text = "当前状态";
            this.ColNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColNow.Width = 176;
            // 
            // ColButton
            // 
            this.ColButton.Text = "";
            this.ColButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColButton.Width = 100;
            // 
            // TlStrStatus
            // 
            this.TlStrStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TlStrStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrBtnStatus});
            this.TlStrStatus.Location = new System.Drawing.Point(3, 3);
            this.TlStrStatus.Name = "TlStrStatus";
            this.TlStrStatus.Size = new System.Drawing.Size(815, 27);
            this.TlStrStatus.TabIndex = 9;
            this.TlStrStatus.Text = "toolStrip2";
            // 
            // TlStrBtnStatus
            // 
            this.TlStrBtnStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TlStrBtnStatus.AutoSize = false;
            this.TlStrBtnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TlStrBtnStatus.Image = ((System.Drawing.Image)(resources.GetObject("TlStrBtnStatus.Image")));
            this.TlStrBtnStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrBtnStatus.Name = "TlStrBtnStatus";
            this.TlStrBtnStatus.Size = new System.Drawing.Size(500, 24);
            this.TlStrBtnStatus.Text = "<<状态";
            this.TlStrBtnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TlStrBtnStatus.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TabOptimization
            // 
            this.TabOptimization.ImageIndex = 1;
            this.TabOptimization.Location = new System.Drawing.Point(160, 4);
            this.TabOptimization.Name = "TabOptimization";
            this.TabOptimization.Padding = new System.Windows.Forms.Padding(3);
            this.TabOptimization.Size = new System.Drawing.Size(821, 588);
            this.TabOptimization.TabIndex = 1;
            this.TabOptimization.Text = "系统优化";
            this.TabOptimization.UseVisualStyleBackColor = true;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "SET.png");
            this.ImageList.Images.SetKeyName(1, "UP.png");
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.TabCtrlAdm);
            this.Controls.Add(this.FlwLytPnlUser);
            this.Controls.Add(this.MenuStripAdm);
            this.MainMenuStrip = this.MenuStripAdm;
            this.Name = "AdmForm";
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.AdmForm_Load);
            this.MenuStripAdm.ResumeLayout(false);
            this.MenuStripAdm.PerformLayout();
            this.FlwLytPnlUser.ResumeLayout(false);
            this.TabCtrlAdm.ResumeLayout(false);
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            this.TabConfigure.ResumeLayout(false);
            this.TabConfigure.PerformLayout();
            this.PnlWList.ResumeLayout(false);
            this.TlStrWList.ResumeLayout(false);
            this.TlStrWList.PerformLayout();
            this.PnlBList.ResumeLayout(false);
            this.TlStrBList.ResumeLayout(false);
            this.TlStrBList.PerformLayout();
            this.TlStrStatus.ResumeLayout(false);
            this.TlStrStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnWList_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripAdm;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExport;
        private System.Windows.Forms.ToolStripMenuItem MenuSet;
        private System.Windows.Forms.ToolStripMenuItem MenuSetIP;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHlepView;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlUser;
        private System.Windows.Forms.TabControl TabCtrlAdm;
        private System.Windows.Forms.TabPage TabConfigure;
        private System.Windows.Forms.TabPage TabOptimization;
        private System.Windows.Forms.Panel PnlWList;
         private System.Windows.Forms.Panel PnlBList;
        private System.Windows.Forms.ListView LvStatus;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColDflt;
        private System.Windows.Forms.ColumnHeader ColNow;
        private System.Windows.Forms.ColumnHeader ColButton;
        private Button BtnUser01;
        private Button BtnUser02;
        private ListView LvWList;
        private ListView LvBList;
        private ImageList ImageList;
        private ToolStrip TlStrBList;
        private ToolStripButton TlStrBtnBListSet;
        private ToolStripButton TlStrBtnBList;
        private ToolStrip TlStrWList;
        private ToolStripButton TlStrBtnWListSet;
        private ToolStripButton TlStrBtnWList;
        private TabPage TabAbout;
        private Label LblAbout;
        private ToolStrip TlStrStatus;
        private ToolStripButton TlStrBtnStatus;
    }
}