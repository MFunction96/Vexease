using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vexease.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmForm));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("CSDN的手机版的搜索功能有毒啊...");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("对瑜伽这东西再也没法直视了....知乎真是文盲之友啊");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("这个世界充满了恶意.......");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("我明明只是一个菜鸡......");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("注册表状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("计划任务状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("控制面板状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("运行工具状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("任务管理器状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("命令指示符状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("PowerShell状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("控制台状态", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
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
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SplAdm = new System.Windows.Forms.SplitContainer();
            this.Btnyouhua = new System.Windows.Forms.Button();
            this.LblOptimization = new System.Windows.Forms.Label();
            this.BtnPS = new System.Windows.Forms.Button();
            this.BtnCmd = new System.Windows.Forms.Button();
            this.BtnTaskMgr = new System.Windows.Forms.Button();
            this.BtnRunTool = new System.Windows.Forms.Button();
            this.BtnCtrlPnl = new System.Windows.Forms.Button();
            this.BtnPlanningTask = new System.Windows.Forms.Button();
            this.BtnRegustry = new System.Windows.Forms.Button();
            this.BtnConsole = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TabCtrlAdm = new System.Windows.Forms.TabControl();
            this.PageAbout = new System.Windows.Forms.TabPage();
            this.LblAbout = new System.Windows.Forms.Label();
            this.PageConsole = new System.Windows.Forms.TabPage();
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
            this.PageRegustry = new System.Windows.Forms.TabPage();
            this.LvRegustry = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvRegustryTitle = new System.Windows.Forms.ListView();
            this.PagePlanningTask = new System.Windows.Forms.TabPage();
            this.LvPlanningTask = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvPlanningTaskTitle = new System.Windows.Forms.ListView();
            this.PageCtrlPnl = new System.Windows.Forms.TabPage();
            this.LvCtrlPnl = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCtrlPnlTitle = new System.Windows.Forms.ListView();
            this.PageRunTool = new System.Windows.Forms.TabPage();
            this.LvRunTool = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvRunToolTile = new System.Windows.Forms.ListView();
            this.PageTaskMgr = new System.Windows.Forms.TabPage();
            this.LvTaskMgr = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvTaskMgrTitle = new System.Windows.Forms.ListView();
            this.PageCmd = new System.Windows.Forms.TabPage();
            this.LvCmd = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCmdTitle = new System.Windows.Forms.ListView();
            this.PagePS = new System.Windows.Forms.TabPage();
            this.LvPS = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvPSTitle = new System.Windows.Forms.ListView();
            this.PageOptimization = new System.Windows.Forms.TabPage();
            this.LvConsole = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvConsoleTitle = new System.Windows.Forms.ListView();
            MenuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdm.SuspendLayout();
            this.FlwLytPnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplAdm)).BeginInit();
            this.SplAdm.Panel1.SuspendLayout();
            this.SplAdm.Panel2.SuspendLayout();
            this.SplAdm.SuspendLayout();
            this.TabCtrlAdm.SuspendLayout();
            this.PageAbout.SuspendLayout();
            this.PageConsole.SuspendLayout();
            this.PnlWList.SuspendLayout();
            this.TlStrWList.SuspendLayout();
            this.PnlBList.SuspendLayout();
            this.TlStrBList.SuspendLayout();
            this.PageRegustry.SuspendLayout();
            this.PagePlanningTask.SuspendLayout();
            this.PageCtrlPnl.SuspendLayout();
            this.PageRunTool.SuspendLayout();
            this.PageTaskMgr.SuspendLayout();
            this.PageCmd.SuspendLayout();
            this.PagePS.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFileImport
            // 
            MenuFileImport.Name = "MenuFileImport";
            MenuFileImport.Size = new System.Drawing.Size(114, 26);
            MenuFileImport.Text = "导入";
            MenuFileImport.Click += new System.EventHandler(this.MenuFileImport_Click);
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
            this.MenuStripAdm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripAdm_ItemClicked_1);
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
            this.MenuFileExport.Click += new System.EventHandler(this.MenuFileExport_Click);
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
            this.MenuSetIP.Click += new System.EventHandler(this.MenuSetIP_Click);
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
            this.FlwLytPnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.FlwLytPnlUser_Paint);
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
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "SET.png");
            this.ImageList.Images.SetKeyName(1, "UP.png");
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            // 
            // SplAdm
            // 
            this.SplAdm.Location = new System.Drawing.Point(0, 135);
            this.SplAdm.Name = "SplAdm";
            // 
            // SplAdm.Panel1
            // 
            this.SplAdm.Panel1.Controls.Add(this.Btnyouhua);
            this.SplAdm.Panel1.Controls.Add(this.LblOptimization);
            this.SplAdm.Panel1.Controls.Add(this.BtnPS);
            this.SplAdm.Panel1.Controls.Add(this.BtnCmd);
            this.SplAdm.Panel1.Controls.Add(this.BtnTaskMgr);
            this.SplAdm.Panel1.Controls.Add(this.BtnRunTool);
            this.SplAdm.Panel1.Controls.Add(this.BtnCtrlPnl);
            this.SplAdm.Panel1.Controls.Add(this.BtnPlanningTask);
            this.SplAdm.Panel1.Controls.Add(this.BtnRegustry);
            this.SplAdm.Panel1.Controls.Add(this.BtnConsole);
            this.SplAdm.Panel1.Controls.Add(this.LblStatus);
            // 
            // SplAdm.Panel2
            // 
            this.SplAdm.Panel2.AutoScroll = true;
            this.SplAdm.Panel2.Controls.Add(this.TabCtrlAdm);
            this.SplAdm.Size = new System.Drawing.Size(985, 618);
            this.SplAdm.SplitterDistance = 200;
            this.SplAdm.TabIndex = 2;
            // 
            // Btnyouhua
            // 
            this.Btnyouhua.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnyouhua.Location = new System.Drawing.Point(0, 340);
            this.Btnyouhua.Name = "Btnyouhua";
            this.Btnyouhua.Size = new System.Drawing.Size(200, 30);
            this.Btnyouhua.TabIndex = 10;
            this.Btnyouhua.Text = "我叫Btnyouhua";
            this.Btnyouhua.UseVisualStyleBackColor = true;
            this.Btnyouhua.Click += new System.EventHandler(this.Btnyouhua_Click);
            // 
            // LblOptimization
            // 
            this.LblOptimization.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblOptimization.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblOptimization.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblOptimization.Location = new System.Drawing.Point(0, 290);
            this.LblOptimization.Name = "LblOptimization";
            this.LblOptimization.Size = new System.Drawing.Size(200, 50);
            this.LblOptimization.TabIndex = 12;
            this.LblOptimization.Text = "btn不能右击双击，只能我上";
            this.LblOptimization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblOptimization.Click += new System.EventHandler(this.LblOptimization_Click);
            this.LblOptimization.DoubleClick += new System.EventHandler(this.LblOptimization_DoubleClick);
            // 
            // BtnPS
            // 
            this.BtnPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPS.Location = new System.Drawing.Point(0, 260);
            this.BtnPS.Name = "BtnPS";
            this.BtnPS.Size = new System.Drawing.Size(200, 30);
            this.BtnPS.TabIndex = 8;
            this.BtnPS.Text = "PowerShell状态";
            this.BtnPS.UseVisualStyleBackColor = true;
            this.BtnPS.Click += new System.EventHandler(this.BtnPS_Click);
            // 
            // BtnCmd
            // 
            this.BtnCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCmd.Location = new System.Drawing.Point(0, 230);
            this.BtnCmd.Name = "BtnCmd";
            this.BtnCmd.Size = new System.Drawing.Size(200, 30);
            this.BtnCmd.TabIndex = 7;
            this.BtnCmd.Text = "命令指示符状态";
            this.BtnCmd.UseVisualStyleBackColor = true;
            this.BtnCmd.Click += new System.EventHandler(this.BtnCmd_Click);
            // 
            // BtnTaskMgr
            // 
            this.BtnTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTaskMgr.Location = new System.Drawing.Point(0, 200);
            this.BtnTaskMgr.Name = "BtnTaskMgr";
            this.BtnTaskMgr.Size = new System.Drawing.Size(200, 30);
            this.BtnTaskMgr.TabIndex = 6;
            this.BtnTaskMgr.Text = "任务管理器状态";
            this.BtnTaskMgr.UseVisualStyleBackColor = true;
            this.BtnTaskMgr.Click += new System.EventHandler(this.BtnTaskMgr_Click);
            // 
            // BtnRunTool
            // 
            this.BtnRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRunTool.Location = new System.Drawing.Point(0, 170);
            this.BtnRunTool.Name = "BtnRunTool";
            this.BtnRunTool.Size = new System.Drawing.Size(200, 30);
            this.BtnRunTool.TabIndex = 5;
            this.BtnRunTool.Text = "运行工具状态";
            this.BtnRunTool.UseVisualStyleBackColor = true;
            this.BtnRunTool.Click += new System.EventHandler(this.BtnRunTool_Click);
            // 
            // BtnCtrlPnl
            // 
            this.BtnCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCtrlPnl.Location = new System.Drawing.Point(0, 140);
            this.BtnCtrlPnl.Name = "BtnCtrlPnl";
            this.BtnCtrlPnl.Size = new System.Drawing.Size(200, 30);
            this.BtnCtrlPnl.TabIndex = 4;
            this.BtnCtrlPnl.Text = "控制面板状态";
            this.BtnCtrlPnl.UseVisualStyleBackColor = true;
            this.BtnCtrlPnl.Click += new System.EventHandler(this.BtnCtrlPnl_Click);
            // 
            // BtnPlanningTask
            // 
            this.BtnPlanningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPlanningTask.Location = new System.Drawing.Point(0, 110);
            this.BtnPlanningTask.Name = "BtnPlanningTask";
            this.BtnPlanningTask.Size = new System.Drawing.Size(200, 30);
            this.BtnPlanningTask.TabIndex = 3;
            this.BtnPlanningTask.Text = "计划任务状态";
            this.BtnPlanningTask.UseVisualStyleBackColor = true;
            this.BtnPlanningTask.Click += new System.EventHandler(this.BtnPlanningTask_Click);
            // 
            // BtnRegustry
            // 
            this.BtnRegustry.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegustry.Location = new System.Drawing.Point(0, 80);
            this.BtnRegustry.Name = "BtnRegustry";
            this.BtnRegustry.Size = new System.Drawing.Size(200, 30);
            this.BtnRegustry.TabIndex = 2;
            this.BtnRegustry.Text = "注册表状态";
            this.BtnRegustry.UseVisualStyleBackColor = true;
            this.BtnRegustry.Click += new System.EventHandler(this.BtnRegustry_Click);
            // 
            // BtnConsole
            // 
            this.BtnConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsole.Location = new System.Drawing.Point(0, 50);
            this.BtnConsole.Name = "BtnConsole";
            this.BtnConsole.Size = new System.Drawing.Size(200, 30);
            this.BtnConsole.TabIndex = 1;
            this.BtnConsole.Text = "控制台状态";
            this.BtnConsole.UseVisualStyleBackColor = true;
            this.BtnConsole.Click += new System.EventHandler(this.BtnConsole_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblStatus.Location = new System.Drawing.Point(0, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(200, 50);
            this.LblStatus.TabIndex = 11;
            this.LblStatus.Text = "我是一个Lbl";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            this.LblStatus.DoubleClick += new System.EventHandler(this.LblStatus_DoubleClick);
            // 
            // TabCtrlAdm
            // 
            this.TabCtrlAdm.Controls.Add(this.PageAbout);
            this.TabCtrlAdm.Controls.Add(this.PageConsole);
            this.TabCtrlAdm.Controls.Add(this.PageRegustry);
            this.TabCtrlAdm.Controls.Add(this.PagePlanningTask);
            this.TabCtrlAdm.Controls.Add(this.PageCtrlPnl);
            this.TabCtrlAdm.Controls.Add(this.PageRunTool);
            this.TabCtrlAdm.Controls.Add(this.PageTaskMgr);
            this.TabCtrlAdm.Controls.Add(this.PageCmd);
            this.TabCtrlAdm.Controls.Add(this.PagePS);
            this.TabCtrlAdm.Controls.Add(this.PageOptimization);
            this.TabCtrlAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAdm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrlAdm.ItemSize = new System.Drawing.Size(1, 1);
            this.TabCtrlAdm.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAdm.Name = "TabCtrlAdm";
            this.TabCtrlAdm.SelectedIndex = 0;
            this.TabCtrlAdm.Size = new System.Drawing.Size(781, 606);
            this.TabCtrlAdm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrlAdm.TabIndex = 5;
            this.TabCtrlAdm.TabStop = false;
            // 
            // PageAbout
            // 
            this.PageAbout.Controls.Add(this.LblAbout);
            this.PageAbout.Location = new System.Drawing.Point(4, 45);
            this.PageAbout.Name = "PageAbout";
            this.PageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.PageAbout.Size = new System.Drawing.Size(773, 557);
            this.PageAbout.TabIndex = 2;
            this.PageAbout.Text = "关于";
            this.PageAbout.UseVisualStyleBackColor = true;
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
            // PageConsole
            // 
            this.PageConsole.AutoScroll = false;
            this.PageConsole.Controls.Add(this.PnlWList);
            this.PageConsole.Controls.Add(this.TlStrWList);
            this.PageConsole.Controls.Add(this.PnlBList);
            this.PageConsole.Controls.Add(this.TlStrBList);
            this.PageConsole.Controls.Add(this.LvConsole);
            this.PageConsole.Controls.Add(this.LvConsoleTitle);
            this.PageConsole.ImageIndex = 0;
            this.PageConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PageConsole.Location = new System.Drawing.Point(4, 45);
            this.PageConsole.Name = "PageConsole";
            this.PageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.PageConsole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PageConsole.Size = new System.Drawing.Size(773, 557);
            this.PageConsole.TabIndex = 0;
            this.PageConsole.Text = "控制台状态";
            this.PageConsole.UseVisualStyleBackColor = true;
            this.PageConsole.Click += new System.EventHandler(this.TabConfigure_Click);
            // 
            // PnlWList
            // 
            this.PnlWList.Controls.Add(this.LvWList);
            this.PnlWList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlWList.Location = new System.Drawing.Point(3, 157);
            this.PnlWList.Name = "PnlWList";
            this.PnlWList.Size = new System.Drawing.Size(767, 100);
            this.PnlWList.TabIndex = 6;
            // 
            // LvWList
            // 
            this.LvWList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvWList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5});
            this.LvWList.Location = new System.Drawing.Point(0, 0);
            this.LvWList.Name = "LvWList";
            this.LvWList.Size = new System.Drawing.Size(767, 100);
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
            this.TlStrWList.Location = new System.Drawing.Point(3, 130);
            this.TlStrWList.Name = "TlStrWList";
            this.TlStrWList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TlStrWList.Size = new System.Drawing.Size(767, 27);
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
            this.PnlBList.Location = new System.Drawing.Point(3, 30);
            this.PnlBList.Name = "PnlBList";
            this.PnlBList.Size = new System.Drawing.Size(767, 100);
            this.PnlBList.TabIndex = 5;
            // 
            // LvBList
            // 
            this.LvBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvBList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7});
            this.LvBList.Location = new System.Drawing.Point(0, 0);
            this.LvBList.Name = "LvBList";
            this.LvBList.Size = new System.Drawing.Size(767, 100);
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
            this.TlStrBList.Location = new System.Drawing.Point(3, 3);
            this.TlStrBList.Name = "TlStrBList";
            this.TlStrBList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TlStrBList.Size = new System.Drawing.Size(767, 27);
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
            // PageRegustry
            // 
            this.PageRegustry.Controls.Add(this.LvRegustry);
            this.PageRegustry.Controls.Add(this.LvRegustryTitle);
            this.PageRegustry.Location = new System.Drawing.Point(4, 45);
            this.PageRegustry.Name = "PageRegustry";
            this.PageRegustry.Size = new System.Drawing.Size(773, 557);
            this.PageRegustry.TabIndex = 3;
            this.PageRegustry.Text = "注册表状态";
            this.PageRegustry.UseVisualStyleBackColor = true;
            // 
            // LvRegustry
            // 
            this.LvRegustry.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvRegustry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LvRegustry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvRegustry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem9.Checked = true;
            listViewItem9.StateImageIndex = 1;
            this.LvRegustry.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9});
            this.LvRegustry.Location = new System.Drawing.Point(0, 39);
            this.LvRegustry.Name = "LvRegustry";
            this.LvRegustry.ShowItemToolTips = true;
            this.LvRegustry.Size = new System.Drawing.Size(773, 110);
            this.LvRegustry.TabIndex = 11;
            this.LvRegustry.TabStop = false;
            this.LvRegustry.UseCompatibleStateImageBehavior = false;
            this.LvRegustry.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "默认状态";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "当前状态";
            this.columnHeader2.Width = 222;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "自定义";
            this.columnHeader3.Width = 222;
            // 
            // LvRegustryTitle
            // 
            this.LvRegustryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup2.Header = "注册表状态";
            listViewGroup2.Name = "LvgRegustry";
            this.LvRegustryTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            listViewItem10.Group = listViewGroup2;
            this.LvRegustryTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10});
            this.LvRegustryTitle.Location = new System.Drawing.Point(0, 0);
            this.LvRegustryTitle.Name = "LvRegustryTitle";
            this.LvRegustryTitle.Scrollable = false;
            this.LvRegustryTitle.Size = new System.Drawing.Size(773, 39);
            this.LvRegustryTitle.TabIndex = 12;
            this.LvRegustryTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PagePlanningTask
            // 
            this.PagePlanningTask.Controls.Add(this.LvPlanningTask);
            this.PagePlanningTask.Controls.Add(this.LvPlanningTaskTitle);
            this.PagePlanningTask.Location = new System.Drawing.Point(4, 45);
            this.PagePlanningTask.Name = "PagePlanningTask";
            this.PagePlanningTask.Size = new System.Drawing.Size(773, 557);
            this.PagePlanningTask.TabIndex = 4;
            this.PagePlanningTask.Text = "计划任务状态";
            this.PagePlanningTask.UseVisualStyleBackColor = true;
            // 
            // LvPlanningTask
            // 
            this.LvPlanningTask.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvPlanningTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LvPlanningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvPlanningTask.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem12.Checked = true;
            listViewItem12.StateImageIndex = 1;
            this.LvPlanningTask.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12});
            this.LvPlanningTask.Location = new System.Drawing.Point(0, 39);
            this.LvPlanningTask.Name = "LvPlanningTask";
            this.LvPlanningTask.ShowItemToolTips = true;
            this.LvPlanningTask.Size = new System.Drawing.Size(773, 110);
            this.LvPlanningTask.TabIndex = 11;
            this.LvPlanningTask.TabStop = false;
            this.LvPlanningTask.UseCompatibleStateImageBehavior = false;
            this.LvPlanningTask.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "默认状态";
            this.columnHeader4.Width = 222;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "当前状态";
            this.columnHeader5.Width = 222;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "自定义";
            this.columnHeader6.Width = 222;
            // 
            // LvPlanningTaskTitle
            // 
            this.LvPlanningTaskTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup3.Header = "计划任务状态";
            listViewGroup3.Name = "LvgPlanningTask";
            this.LvPlanningTaskTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            listViewItem13.Group = listViewGroup3;
            this.LvPlanningTaskTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13});
            this.LvPlanningTaskTitle.Location = new System.Drawing.Point(0, 0);
            this.LvPlanningTaskTitle.Name = "LvPlanningTaskTitle";
            this.LvPlanningTaskTitle.Scrollable = false;
            this.LvPlanningTaskTitle.Size = new System.Drawing.Size(773, 39);
            this.LvPlanningTaskTitle.TabIndex = 12;
            this.LvPlanningTaskTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PageCtrlPnl
            // 
            this.PageCtrlPnl.Controls.Add(this.LvCtrlPnl);
            this.PageCtrlPnl.Controls.Add(this.LvCtrlPnlTitle);
            this.PageCtrlPnl.Location = new System.Drawing.Point(4, 45);
            this.PageCtrlPnl.Name = "PageCtrlPnl";
            this.PageCtrlPnl.Size = new System.Drawing.Size(773, 557);
            this.PageCtrlPnl.TabIndex = 5;
            this.PageCtrlPnl.Text = "控制面板状态";
            this.PageCtrlPnl.UseVisualStyleBackColor = true;
            // 
            // LvCtrlPnl
            // 
            this.LvCtrlPnl.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCtrlPnl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LvCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCtrlPnl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem15.Checked = true;
            listViewItem15.StateImageIndex = 1;
            this.LvCtrlPnl.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14,
            listViewItem15});
            this.LvCtrlPnl.Location = new System.Drawing.Point(0, 39);
            this.LvCtrlPnl.Name = "LvCtrlPnl";
            this.LvCtrlPnl.ShowItemToolTips = true;
            this.LvCtrlPnl.Size = new System.Drawing.Size(773, 110);
            this.LvCtrlPnl.TabIndex = 11;
            this.LvCtrlPnl.TabStop = false;
            this.LvCtrlPnl.UseCompatibleStateImageBehavior = false;
            this.LvCtrlPnl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "默认状态";
            this.columnHeader7.Width = 222;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "当前状态";
            this.columnHeader8.Width = 222;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "自定义";
            this.columnHeader9.Width = 222;
            // 
            // LvCtrlPnlTitle
            // 
            this.LvCtrlPnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup4.Header = "控制面板状态";
            listViewGroup4.Name = "LvgConsole";
            this.LvCtrlPnlTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            listViewItem16.Group = listViewGroup4;
            this.LvCtrlPnlTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16});
            this.LvCtrlPnlTitle.Location = new System.Drawing.Point(0, 0);
            this.LvCtrlPnlTitle.Name = "LvCtrlPnlTitle";
            this.LvCtrlPnlTitle.Scrollable = false;
            this.LvCtrlPnlTitle.Size = new System.Drawing.Size(773, 39);
            this.LvCtrlPnlTitle.TabIndex = 12;
            this.LvCtrlPnlTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PageRunTool
            // 
            this.PageRunTool.Controls.Add(this.LvRunTool);
            this.PageRunTool.Controls.Add(this.LvRunToolTile);
            this.PageRunTool.Location = new System.Drawing.Point(4, 45);
            this.PageRunTool.Name = "PageRunTool";
            this.PageRunTool.Size = new System.Drawing.Size(773, 557);
            this.PageRunTool.TabIndex = 7;
            this.PageRunTool.Text = "运行工具状态";
            this.PageRunTool.UseVisualStyleBackColor = true;
            // 
            // LvRunTool
            // 
            this.LvRunTool.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvRunTool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.LvRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvRunTool.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem18.Checked = true;
            listViewItem18.StateImageIndex = 1;
            this.LvRunTool.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18});
            this.LvRunTool.Location = new System.Drawing.Point(0, 39);
            this.LvRunTool.Name = "LvRunTool";
            this.LvRunTool.ShowItemToolTips = true;
            this.LvRunTool.Size = new System.Drawing.Size(773, 110);
            this.LvRunTool.TabIndex = 11;
            this.LvRunTool.TabStop = false;
            this.LvRunTool.UseCompatibleStateImageBehavior = false;
            this.LvRunTool.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "默认状态";
            this.columnHeader10.Width = 222;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "当前状态";
            this.columnHeader11.Width = 222;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "自定义";
            this.columnHeader12.Width = 222;
            // 
            // LvRunToolTile
            // 
            this.LvRunToolTile.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup5.Header = "运行工具状态";
            listViewGroup5.Name = "LvgConsole";
            this.LvRunToolTile.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            listViewItem19.Group = listViewGroup5;
            this.LvRunToolTile.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19});
            this.LvRunToolTile.Location = new System.Drawing.Point(0, 0);
            this.LvRunToolTile.Name = "LvRunToolTile";
            this.LvRunToolTile.Scrollable = false;
            this.LvRunToolTile.Size = new System.Drawing.Size(773, 39);
            this.LvRunToolTile.TabIndex = 12;
            this.LvRunToolTile.UseCompatibleStateImageBehavior = false;
            // 
            // PageTaskMgr
            // 
            this.PageTaskMgr.Controls.Add(this.LvTaskMgr);
            this.PageTaskMgr.Controls.Add(this.LvTaskMgrTitle);
            this.PageTaskMgr.Location = new System.Drawing.Point(4, 45);
            this.PageTaskMgr.Name = "PageTaskMgr";
            this.PageTaskMgr.Size = new System.Drawing.Size(773, 557);
            this.PageTaskMgr.TabIndex = 6;
            this.PageTaskMgr.Text = "任务管理器状态";
            this.PageTaskMgr.UseVisualStyleBackColor = true;
            // 
            // LvTaskMgr
            // 
            this.LvTaskMgr.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvTaskMgr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.LvTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvTaskMgr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem21.Checked = true;
            listViewItem21.StateImageIndex = 1;
            this.LvTaskMgr.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem20,
            listViewItem21});
            this.LvTaskMgr.Location = new System.Drawing.Point(0, 39);
            this.LvTaskMgr.Name = "LvTaskMgr";
            this.LvTaskMgr.ShowItemToolTips = true;
            this.LvTaskMgr.Size = new System.Drawing.Size(773, 110);
            this.LvTaskMgr.TabIndex = 11;
            this.LvTaskMgr.TabStop = false;
            this.LvTaskMgr.UseCompatibleStateImageBehavior = false;
            this.LvTaskMgr.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "默认状态";
            this.columnHeader13.Width = 222;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "当前状态";
            this.columnHeader14.Width = 222;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "自定义";
            this.columnHeader15.Width = 222;
            // 
            // LvTaskMgrTitle
            // 
            this.LvTaskMgrTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup6.Header = "任务管理器状态";
            listViewGroup6.Name = "LvgTaskMgr";
            this.LvTaskMgrTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6});
            listViewItem22.Group = listViewGroup6;
            this.LvTaskMgrTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem22});
            this.LvTaskMgrTitle.Location = new System.Drawing.Point(0, 0);
            this.LvTaskMgrTitle.Name = "LvTaskMgrTitle";
            this.LvTaskMgrTitle.Scrollable = false;
            this.LvTaskMgrTitle.Size = new System.Drawing.Size(773, 39);
            this.LvTaskMgrTitle.TabIndex = 12;
            this.LvTaskMgrTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PageCmd
            // 
            this.PageCmd.Controls.Add(this.LvCmd);
            this.PageCmd.Controls.Add(this.LvCmdTitle);
            this.PageCmd.Location = new System.Drawing.Point(4, 45);
            this.PageCmd.Name = "PageCmd";
            this.PageCmd.Size = new System.Drawing.Size(773, 557);
            this.PageCmd.TabIndex = 8;
            this.PageCmd.Text = "命令指示符状态";
            this.PageCmd.UseVisualStyleBackColor = true;
            // 
            // LvCmd
            // 
            this.LvCmd.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCmd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.LvCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCmd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem24.Checked = true;
            listViewItem24.StateImageIndex = 1;
            this.LvCmd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem23,
            listViewItem24});
            this.LvCmd.Location = new System.Drawing.Point(0, 39);
            this.LvCmd.Name = "LvCmd";
            this.LvCmd.ShowItemToolTips = true;
            this.LvCmd.Size = new System.Drawing.Size(773, 110);
            this.LvCmd.TabIndex = 11;
            this.LvCmd.TabStop = false;
            this.LvCmd.UseCompatibleStateImageBehavior = false;
            this.LvCmd.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "默认状态";
            this.columnHeader16.Width = 222;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "当前状态";
            this.columnHeader17.Width = 222;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "自定义";
            this.columnHeader18.Width = 222;
            // 
            // LvCmdTitle
            // 
            this.LvCmdTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup7.Header = "命令指示符状态";
            listViewGroup7.Name = "LvgCmd";
            this.LvCmdTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7});
            listViewItem25.Group = listViewGroup7;
            this.LvCmdTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem25});
            this.LvCmdTitle.Location = new System.Drawing.Point(0, 0);
            this.LvCmdTitle.Name = "LvCmdTitle";
            this.LvCmdTitle.Scrollable = false;
            this.LvCmdTitle.Size = new System.Drawing.Size(773, 39);
            this.LvCmdTitle.TabIndex = 12;
            this.LvCmdTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PagePS
            // 
            this.PagePS.Controls.Add(this.LvPS);
            this.PagePS.Controls.Add(this.LvPSTitle);
            this.PagePS.Location = new System.Drawing.Point(4, 45);
            this.PagePS.Name = "PagePS";
            this.PagePS.Size = new System.Drawing.Size(773, 557);
            this.PagePS.TabIndex = 9;
            this.PagePS.Text = "PowerShell状态";
            this.PagePS.UseVisualStyleBackColor = true;
            // 
            // LvPS
            // 
            this.LvPS.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvPS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.LvPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvPS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem27.Checked = true;
            listViewItem27.StateImageIndex = 1;
            this.LvPS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem26,
            listViewItem27});
            this.LvPS.Location = new System.Drawing.Point(0, 39);
            this.LvPS.Name = "LvPS";
            this.LvPS.ShowItemToolTips = true;
            this.LvPS.Size = new System.Drawing.Size(773, 110);
            this.LvPS.TabIndex = 11;
            this.LvPS.TabStop = false;
            this.LvPS.UseCompatibleStateImageBehavior = false;
            this.LvPS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "默认状态";
            this.columnHeader19.Width = 222;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "当前状态";
            this.columnHeader20.Width = 222;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "自定义";
            this.columnHeader21.Width = 222;
            // 
            // LvPSTitle
            // 
            this.LvPSTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup8.Header = "PowerShell状态";
            listViewGroup8.Name = "LvgPS";
            this.LvPSTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup8});
            listViewItem28.Group = listViewGroup8;
            this.LvPSTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem28});
            this.LvPSTitle.Location = new System.Drawing.Point(0, 0);
            this.LvPSTitle.Name = "LvPSTitle";
            this.LvPSTitle.Scrollable = false;
            this.LvPSTitle.Size = new System.Drawing.Size(773, 39);
            this.LvPSTitle.TabIndex = 12;
            this.LvPSTitle.UseCompatibleStateImageBehavior = false;
            // 
            // PageOptimization
            // 
            this.PageOptimization.AutoScroll = true;
            this.PageOptimization.ImageIndex = 1;
            this.PageOptimization.Location = new System.Drawing.Point(4, 45);
            this.PageOptimization.Name = "PageOptimization";
            this.PageOptimization.Padding = new System.Windows.Forms.Padding(3);
            this.PageOptimization.Size = new System.Drawing.Size(773, 557);
            this.PageOptimization.TabIndex = 1;
            this.PageOptimization.Text = "系统优化";
            // 
            // LvConsole
            // 
            this.LvConsole.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvConsole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.LvConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvConsole.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            this.LvConsole.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.LvConsole.Location = new System.Drawing.Point(3, 296);
            this.LvConsole.Name = "LvConsole";
            this.LvConsole.ShowItemToolTips = true;
            this.LvConsole.Size = new System.Drawing.Size(767, 110);
            this.LvConsole.TabIndex = 13;
            this.LvConsole.TabStop = false;
            this.LvConsole.UseCompatibleStateImageBehavior = false;
            this.LvConsole.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "默认状态";
            this.columnHeader22.Width = 222;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "当前状态";
            this.columnHeader23.Width = 222;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "自定义";
            this.columnHeader24.Width = 222;
            // 
            // LvConsoleTitle
            // 
            this.LvConsoleTitle.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup1.Header = "控制台状态";
            listViewGroup1.Name = "LvgConsole";
            this.LvConsoleTitle.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem3.Group = listViewGroup1;
            this.LvConsoleTitle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.LvConsoleTitle.Location = new System.Drawing.Point(3, 257);
            this.LvConsoleTitle.Name = "LvConsoleTitle";
            this.LvConsoleTitle.Scrollable = false;
            this.LvConsoleTitle.Size = new System.Drawing.Size(767, 39);
            this.LvConsoleTitle.TabIndex = 14;
            this.LvConsoleTitle.UseCompatibleStateImageBehavior = false;
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.SplAdm);
            this.Controls.Add(this.FlwLytPnlUser);
            this.Controls.Add(this.MenuStripAdm);
            this.MainMenuStrip = this.MenuStripAdm;
            this.Name = "AdmForm";
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.AdmForm_Load);
            this.MenuStripAdm.ResumeLayout(false);
            this.MenuStripAdm.PerformLayout();
            this.FlwLytPnlUser.ResumeLayout(false);
            this.SplAdm.Panel1.ResumeLayout(false);
            this.SplAdm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplAdm)).EndInit();
            this.SplAdm.ResumeLayout(false);
            this.TabCtrlAdm.ResumeLayout(false);
            this.PageAbout.ResumeLayout(false);
            this.PageAbout.PerformLayout();
            this.PageConsole.ResumeLayout(false);
            this.PageConsole.PerformLayout();
            this.PnlWList.ResumeLayout(false);
            this.TlStrWList.ResumeLayout(false);
            this.TlStrWList.PerformLayout();
            this.PnlBList.ResumeLayout(false);
            this.TlStrBList.ResumeLayout(false);
            this.TlStrBList.PerformLayout();
            this.PageRegustry.ResumeLayout(false);
            this.PagePlanningTask.ResumeLayout(false);
            this.PageCtrlPnl.ResumeLayout(false);
            this.PageRunTool.ResumeLayout(false);
            this.PageTaskMgr.ResumeLayout(false);
            this.PageCmd.ResumeLayout(false);
            this.PagePS.ResumeLayout(false);
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
        private Button BtnUser01;
        private Button BtnUser02;
        private ImageList ImageList;
        private NotifyIcon NotifyIcon;
        private SplitContainer SplAdm;
        private TabControl TabCtrlAdm;
        private TabPage PageAbout;
        private Label LblAbout;
        private TabPage PageConsole;
        private Panel PnlWList;
        private ListView LvWList;
        private ToolStrip TlStrWList;
        private ToolStripButton TlStrBtnWListSet;
        private ToolStripButton TlStrBtnWList;
        private Panel PnlBList;
        private ListView LvBList;
        private ToolStrip TlStrBList;
        private ToolStripButton TlStrBtnBListSet;
        private ToolStripButton TlStrBtnBList;
        private TabPage PageOptimization;
        private Button BtnPS;
        private Button BtnCmd;
        private Button BtnTaskMgr;
        private Button BtnRunTool;
        private Button BtnCtrlPnl;
        private Button BtnPlanningTask;
        private Button BtnRegustry;
        private Button BtnConsole;
        private TabPage PageRegustry;
        private TabPage PagePlanningTask;
        private TabPage PageCtrlPnl;
        private TabPage PageTaskMgr;
        private TabPage PageRunTool;
        private TabPage PageCmd;
        private TabPage PagePS;
        private ListView LvRegustry;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView LvRegustryTitle;
        private ListView LvPlanningTask;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView LvPlanningTaskTitle;
        private ListView LvCtrlPnl;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ListView LvCtrlPnlTitle;
        private ListView LvRunTool;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView LvRunToolTile;
        private ListView LvTaskMgr;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ListView LvTaskMgrTitle;
        private ListView LvCmd;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ListView LvCmdTitle;
        private ListView LvPS;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ListView LvPSTitle;
        private Button Btnyouhua;
        private Label LblStatus;
        private Label LblOptimization;
        private ListView LvConsole;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ListView LvConsoleTitle;
    }
}