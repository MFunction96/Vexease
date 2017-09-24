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
            System.Windows.Forms.ToolStripMenuItem TSMIREflesh;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmForm));
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem("0");
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem(new string[] {
            "--0.",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem("CSDN的手机版的搜索功能有毒啊...");
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem("对瑜伽这东西再也没法直视了....知乎真是文盲之友啊");
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem("这个世界充满了恶意.......");
            System.Windows.Forms.ListViewItem listViewItem60 = new System.Windows.Forms.ListViewItem("我明明只是一个菜鸡......");
            this.MenuStripAdm = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHlepView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SplAdm = new System.Windows.Forms.SplitContainer();
            this.PnlEmpty = new System.Windows.Forms.Panel();
            this.Btnyouhua = new System.Windows.Forms.Button();
            this.LblOptimization = new System.Windows.Forms.Label();
            this.BtnProcCtrl = new System.Windows.Forms.Button();
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
            this.PageInstruction = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.PageAbout = new System.Windows.Forms.TabPage();
            this.LblAbout = new System.Windows.Forms.Label();
            this.PageConsole = new System.Windows.Forms.TabPage();
            this.PnlConsoleBtns = new System.Windows.Forms.Panel();
            this.BtnConsoleEx = new System.Windows.Forms.Button();
            this.BtnConsoleIm = new System.Windows.Forms.Button();
            this.BtnConsoleRe = new System.Windows.Forms.Button();
            this.LvConsole = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlConsole = new System.Windows.Forms.Panel();
            this.LblConsole = new System.Windows.Forms.Label();
            this.BtnConsoleYorN = new Vexease.Views.BtnYorN();
            this.PageRegustry = new System.Windows.Forms.TabPage();
            this.PnlRegustriyBtns = new System.Windows.Forms.Panel();
            this.BtnRegustriyIm = new System.Windows.Forms.Button();
            this.BtnRegustriyEx = new System.Windows.Forms.Button();
            this.BtnRegustriyRe = new System.Windows.Forms.Button();
            this.LvRegustry = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlREgustriy = new System.Windows.Forms.Panel();
            this.LblRegustriy = new System.Windows.Forms.Label();
            this.BtnRegustriyYorN = new Vexease.Views.BtnYorN();
            this.PagePlanningTask = new System.Windows.Forms.TabPage();
            this.PnlPlanningTaskBtns = new System.Windows.Forms.Panel();
            this.BtnPlanningTaskIm = new System.Windows.Forms.Button();
            this.BtnPlanningTaskEx = new System.Windows.Forms.Button();
            this.BtnPlanningTaskRe = new System.Windows.Forms.Button();
            this.LvPlanningTask = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlPlanningTask = new System.Windows.Forms.Panel();
            this.LblPlanningTask = new System.Windows.Forms.Label();
            this.BtnPlanningTaskYorN = new Vexease.Views.BtnYorN();
            this.PageCtrlPnl = new System.Windows.Forms.TabPage();
            this.PnlCtrlPnlBtns = new System.Windows.Forms.Panel();
            this.BtnCtrlPnlIm = new System.Windows.Forms.Button();
            this.BtnCtrlPnlEx = new System.Windows.Forms.Button();
            this.BtnCtrlPnlRe = new System.Windows.Forms.Button();
            this.LvCtrlPnl = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlCtrlPnl = new System.Windows.Forms.Panel();
            this.LblCtrlPnl = new System.Windows.Forms.Label();
            this.BtnCtrlPnlYorN = new Vexease.Views.BtnYorN();
            this.PageRunTool = new System.Windows.Forms.TabPage();
            this.PnlRunToolBtns = new System.Windows.Forms.Panel();
            this.BtnRunToolIm = new System.Windows.Forms.Button();
            this.BtnRunToolEx = new System.Windows.Forms.Button();
            this.BtnRunToolRe = new System.Windows.Forms.Button();
            this.LvRunTool = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlRunTool = new System.Windows.Forms.Panel();
            this.LblRunTool = new System.Windows.Forms.Label();
            this.BtnRunToolYorN = new Vexease.Views.BtnYorN();
            this.PageTaskMgr = new System.Windows.Forms.TabPage();
            this.PnlTaskMgrBtns = new System.Windows.Forms.Panel();
            this.BtnTaskMgrIm = new System.Windows.Forms.Button();
            this.BtnTaskMgrEx = new System.Windows.Forms.Button();
            this.BtnTaskMgrRe = new System.Windows.Forms.Button();
            this.LvTaskMgr = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlTaskMgr = new System.Windows.Forms.Panel();
            this.LblTaskMgr = new System.Windows.Forms.Label();
            this.BtnTaskMgrYorN = new Vexease.Views.BtnYorN();
            this.PageCmd = new System.Windows.Forms.TabPage();
            this.PnlCmdBtns = new System.Windows.Forms.Panel();
            this.BtnCmdIm = new System.Windows.Forms.Button();
            this.BtnCmdEx = new System.Windows.Forms.Button();
            this.BtnCmdRe = new System.Windows.Forms.Button();
            this.LvCmd = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlCmd = new System.Windows.Forms.Panel();
            this.LblCmd = new System.Windows.Forms.Label();
            this.BtnCmdYorN = new Vexease.Views.BtnYorN();
            this.PagePS = new System.Windows.Forms.TabPage();
            this.PnlPsBtns = new System.Windows.Forms.Panel();
            this.BtnPSIm = new System.Windows.Forms.Button();
            this.BtnPSEx = new System.Windows.Forms.Button();
            this.BtnPSRe = new System.Windows.Forms.Button();
            this.LvPS = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlPS = new System.Windows.Forms.Panel();
            this.LblPS = new System.Windows.Forms.Label();
            this.BtnPSYorN = new Vexease.Views.BtnYorN();
            this.PageProcCtrl = new System.Windows.Forms.TabPage();
            this.PnlListTP = new System.Windows.Forms.Panel();
            this.BtnListPathYorN = new Vexease.Views.BtnYorN();
            this.LblListTP = new System.Windows.Forms.Label();
            this.PnlWList = new System.Windows.Forms.Panel();
            this.LvWListN = new System.Windows.Forms.ListView();
            this.PnlWListTN = new System.Windows.Forms.Panel();
            this.BtnWListYorN = new Vexease.Views.BtnYorN();
            this.LblWListTN = new System.Windows.Forms.Label();
            this.PnlBList = new System.Windows.Forms.Panel();
            this.LvBListN = new System.Windows.Forms.ListView();
            this.PnlBListTN = new System.Windows.Forms.Panel();
            this.LblBListTitleN = new System.Windows.Forms.Label();
            this.BtnBListYorN = new Vexease.Views.BtnYorN();
            this.PageOptimization = new System.Windows.Forms.TabPage();
            this.BtnListSetP = new System.Windows.Forms.Button();
            this.BtnWListSet = new System.Windows.Forms.Button();
            this.BtnBListSet = new System.Windows.Forms.Button();
            TSMIREflesh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplAdm)).BeginInit();
            this.SplAdm.Panel1.SuspendLayout();
            this.SplAdm.Panel2.SuspendLayout();
            this.SplAdm.SuspendLayout();
            this.TabCtrlAdm.SuspendLayout();
            this.PageInstruction.SuspendLayout();
            this.PageAbout.SuspendLayout();
            this.PageConsole.SuspendLayout();
            this.PnlConsoleBtns.SuspendLayout();
            this.PnlConsole.SuspendLayout();
            this.PageRegustry.SuspendLayout();
            this.PnlRegustriyBtns.SuspendLayout();
            this.PnlREgustriy.SuspendLayout();
            this.PagePlanningTask.SuspendLayout();
            this.PnlPlanningTaskBtns.SuspendLayout();
            this.PnlPlanningTask.SuspendLayout();
            this.PageCtrlPnl.SuspendLayout();
            this.PnlCtrlPnlBtns.SuspendLayout();
            this.PnlCtrlPnl.SuspendLayout();
            this.PageRunTool.SuspendLayout();
            this.PnlRunToolBtns.SuspendLayout();
            this.PnlRunTool.SuspendLayout();
            this.PageTaskMgr.SuspendLayout();
            this.PnlTaskMgrBtns.SuspendLayout();
            this.PnlTaskMgr.SuspendLayout();
            this.PageCmd.SuspendLayout();
            this.PnlCmdBtns.SuspendLayout();
            this.PnlCmd.SuspendLayout();
            this.PagePS.SuspendLayout();
            this.PnlPsBtns.SuspendLayout();
            this.PnlPS.SuspendLayout();
            this.PageProcCtrl.SuspendLayout();
            this.PnlListTP.SuspendLayout();
            this.PnlWList.SuspendLayout();
            this.PnlWListTN.SuspendLayout();
            this.PnlBList.SuspendLayout();
            this.PnlBListTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMIREflesh
            // 
            TSMIREflesh.Name = "TSMIREflesh";
            TSMIREflesh.Size = new System.Drawing.Size(114, 26);
            TSMIREflesh.Text = "刷新";
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
            TSMIREflesh});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(51, 24);
            this.MenuFile.Text = "文件";
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
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "SET.png");
            this.ImageList.Images.SetKeyName(1, "UP.png");
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // SplAdm
            // 
            this.SplAdm.Location = new System.Drawing.Point(0, 31);
            this.SplAdm.Name = "SplAdm";
            // 
            // SplAdm.Panel1
            // 
            this.SplAdm.Panel1.Controls.Add(this.PnlEmpty);
            this.SplAdm.Panel1.Controls.Add(this.Btnyouhua);
            this.SplAdm.Panel1.Controls.Add(this.LblOptimization);
            this.SplAdm.Panel1.Controls.Add(this.BtnProcCtrl);
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
            this.SplAdm.Size = new System.Drawing.Size(985, 522);
            this.SplAdm.SplitterDistance = 200;
            this.SplAdm.TabIndex = 2;
            // 
            // PnlEmpty
            // 
            this.PnlEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEmpty.Location = new System.Drawing.Point(0, 400);
            this.PnlEmpty.Name = "PnlEmpty";
            this.PnlEmpty.Size = new System.Drawing.Size(200, 122);
            this.PnlEmpty.TabIndex = 14;
            this.PnlEmpty.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlEmpty_Click);
            // 
            // Btnyouhua
            // 
            this.Btnyouhua.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnyouhua.Location = new System.Drawing.Point(0, 370);
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
            this.LblOptimization.Location = new System.Drawing.Point(0, 320);
            this.LblOptimization.Name = "LblOptimization";
            this.LblOptimization.Size = new System.Drawing.Size(200, 50);
            this.LblOptimization.TabIndex = 12;
            this.LblOptimization.Text = "系统优化";
            this.LblOptimization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblOptimization.Click += new System.EventHandler(this.LblOptimization_Click);
            this.LblOptimization.DoubleClick += new System.EventHandler(this.LblOptimization_DoubleClick);
            // 
            // BtnProcCtrl
            // 
            this.BtnProcCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProcCtrl.Location = new System.Drawing.Point(0, 290);
            this.BtnProcCtrl.Name = "BtnProcCtrl";
            this.BtnProcCtrl.Size = new System.Drawing.Size(200, 30);
            this.BtnProcCtrl.TabIndex = 13;
            this.BtnProcCtrl.Text = "进程管控";
            this.BtnProcCtrl.UseVisualStyleBackColor = true;
            this.BtnProcCtrl.Click += new System.EventHandler(this.BtnProcCtrl_Click);
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
            this.LblStatus.Text = "系统管理";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            this.LblStatus.DoubleClick += new System.EventHandler(this.LblStatus_DoubleClick);
            // 
            // TabCtrlAdm
            // 
            this.TabCtrlAdm.Controls.Add(this.PageInstruction);
            this.TabCtrlAdm.Controls.Add(this.PageAbout);
            this.TabCtrlAdm.Controls.Add(this.PageConsole);
            this.TabCtrlAdm.Controls.Add(this.PageRegustry);
            this.TabCtrlAdm.Controls.Add(this.PagePlanningTask);
            this.TabCtrlAdm.Controls.Add(this.PageCtrlPnl);
            this.TabCtrlAdm.Controls.Add(this.PageRunTool);
            this.TabCtrlAdm.Controls.Add(this.PageTaskMgr);
            this.TabCtrlAdm.Controls.Add(this.PageCmd);
            this.TabCtrlAdm.Controls.Add(this.PagePS);
            this.TabCtrlAdm.Controls.Add(this.PageProcCtrl);
            this.TabCtrlAdm.Controls.Add(this.PageOptimization);
            this.TabCtrlAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAdm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrlAdm.ItemSize = new System.Drawing.Size(1, 1);
            this.TabCtrlAdm.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAdm.Name = "TabCtrlAdm";
            this.TabCtrlAdm.SelectedIndex = 0;
            this.TabCtrlAdm.Size = new System.Drawing.Size(781, 522);
            this.TabCtrlAdm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrlAdm.TabIndex = 5;
            this.TabCtrlAdm.TabStop = false;
            // 
            // PageInstruction
            // 
            this.PageInstruction.Controls.Add(this.label1);
            this.PageInstruction.Location = new System.Drawing.Point(4, 14);
            this.PageInstruction.Name = "PageInstruction";
            this.PageInstruction.Size = new System.Drawing.Size(773, 504);
            this.PageInstruction.TabIndex = 11;
            this.PageInstruction.Text = "说明";
            this.PageInstruction.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "说明balabal。。。";
            // 
            // PageAbout
            // 
            this.PageAbout.Controls.Add(this.LblAbout);
            this.PageAbout.Location = new System.Drawing.Point(4, 14);
            this.PageAbout.Name = "PageAbout";
            this.PageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.PageAbout.Size = new System.Drawing.Size(773, 504);
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
            this.PageConsole.Controls.Add(this.PnlConsoleBtns);
            this.PageConsole.Controls.Add(this.LvConsole);
            this.PageConsole.Controls.Add(this.PnlConsole);
            this.PageConsole.ImageIndex = 0;
            this.PageConsole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PageConsole.Location = new System.Drawing.Point(4, 14);
            this.PageConsole.Name = "PageConsole";
            this.PageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.PageConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PageConsole.Size = new System.Drawing.Size(773, 504);
            this.PageConsole.TabIndex = 0;
            this.PageConsole.Text = "控制台状态";
            this.PageConsole.UseVisualStyleBackColor = true;
            // 
            // PnlConsoleBtns
            // 
            this.PnlConsoleBtns.Controls.Add(this.BtnConsoleEx);
            this.PnlConsoleBtns.Controls.Add(this.BtnConsoleIm);
            this.PnlConsoleBtns.Controls.Add(this.BtnConsoleRe);
            this.PnlConsoleBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlConsoleBtns.Location = new System.Drawing.Point(3, 451);
            this.PnlConsoleBtns.Name = "PnlConsoleBtns";
            this.PnlConsoleBtns.Size = new System.Drawing.Size(767, 50);
            this.PnlConsoleBtns.TabIndex = 16;
            // 
            // BtnConsoleEx
            // 
            this.BtnConsoleEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleEx.Location = new System.Drawing.Point(497, 0);
            this.BtnConsoleEx.Name = "BtnConsoleEx";
            this.BtnConsoleEx.Size = new System.Drawing.Size(90, 50);
            this.BtnConsoleEx.TabIndex = 21;
            this.BtnConsoleEx.Text = "导出";
            this.BtnConsoleEx.UseVisualStyleBackColor = true;
            // 
            // BtnConsoleIm
            // 
            this.BtnConsoleIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleIm.Location = new System.Drawing.Point(587, 0);
            this.BtnConsoleIm.Name = "BtnConsoleIm";
            this.BtnConsoleIm.Size = new System.Drawing.Size(90, 50);
            this.BtnConsoleIm.TabIndex = 20;
            this.BtnConsoleIm.Text = "导入";
            this.BtnConsoleIm.UseVisualStyleBackColor = true;
            // 
            // BtnConsoleRe
            // 
            this.BtnConsoleRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleRe.Location = new System.Drawing.Point(677, 0);
            this.BtnConsoleRe.Name = "BtnConsoleRe";
            this.BtnConsoleRe.Size = new System.Drawing.Size(90, 50);
            this.BtnConsoleRe.TabIndex = 19;
            this.BtnConsoleRe.Text = "刷新";
            this.BtnConsoleRe.UseVisualStyleBackColor = true;
            // 
            // LvConsole
            // 
            this.LvConsole.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvConsole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23});
            this.LvConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvConsole.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem42.Checked = true;
            listViewItem42.StateImageIndex = 1;
            this.LvConsole.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem41,
            listViewItem42});
            this.LvConsole.Location = new System.Drawing.Point(3, 33);
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
            // PnlConsole
            // 
            this.PnlConsole.Controls.Add(this.LblConsole);
            this.PnlConsole.Controls.Add(this.BtnConsoleYorN);
            this.PnlConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlConsole.Location = new System.Drawing.Point(3, 3);
            this.PnlConsole.Name = "PnlConsole";
            this.PnlConsole.Size = new System.Drawing.Size(767, 30);
            this.PnlConsole.TabIndex = 15;
            // 
            // LblConsole
            // 
            this.LblConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblConsole.Location = new System.Drawing.Point(0, 0);
            this.LblConsole.Name = "LblConsole";
            this.LblConsole.Size = new System.Drawing.Size(600, 30);
            this.LblConsole.TabIndex = 15;
            this.LblConsole.Text = "控制台状态————————";
            this.LblConsole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblConsole.Click += new System.EventHandler(this.LblConsole_Click);
            // 
            // BtnConsoleYorN
            // 
            this.BtnConsoleYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsoleYorN.Checked = false;
            this.BtnConsoleYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnConsoleYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsoleYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleYorN.Location = new System.Drawing.Point(717, 0);
            this.BtnConsoleYorN.Name = "BtnConsoleYorN";
            this.BtnConsoleYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnConsoleYorN.TabIndex = 13;
            this.BtnConsoleYorN.Load += new System.EventHandler(this.BtnConsoleYorN_Load);
            this.BtnConsoleYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnConsoleYorN_MouseUp);
            // 
            // PageRegustry
            // 
            this.PageRegustry.Controls.Add(this.PnlRegustriyBtns);
            this.PageRegustry.Controls.Add(this.LvRegustry);
            this.PageRegustry.Controls.Add(this.PnlREgustriy);
            this.PageRegustry.Location = new System.Drawing.Point(4, 14);
            this.PageRegustry.Name = "PageRegustry";
            this.PageRegustry.Size = new System.Drawing.Size(773, 504);
            this.PageRegustry.TabIndex = 3;
            this.PageRegustry.Text = "注册表状态";
            this.PageRegustry.UseVisualStyleBackColor = true;
            // 
            // PnlRegustriyBtns
            // 
            this.PnlRegustriyBtns.Controls.Add(this.BtnRegustriyIm);
            this.PnlRegustriyBtns.Controls.Add(this.BtnRegustriyEx);
            this.PnlRegustriyBtns.Controls.Add(this.BtnRegustriyRe);
            this.PnlRegustriyBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlRegustriyBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlRegustriyBtns.Name = "PnlRegustriyBtns";
            this.PnlRegustriyBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlRegustriyBtns.TabIndex = 17;
            // 
            // BtnRegustriyIm
            // 
            this.BtnRegustriyIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegustriyIm.Location = new System.Drawing.Point(503, 0);
            this.BtnRegustriyIm.Name = "BtnRegustriyIm";
            this.BtnRegustriyIm.Size = new System.Drawing.Size(90, 50);
            this.BtnRegustriyIm.TabIndex = 21;
            this.BtnRegustriyIm.Text = "导出";
            this.BtnRegustriyIm.UseVisualStyleBackColor = true;
            // 
            // BtnRegustriyEx
            // 
            this.BtnRegustriyEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegustriyEx.Location = new System.Drawing.Point(593, 0);
            this.BtnRegustriyEx.Name = "BtnRegustriyEx";
            this.BtnRegustriyEx.Size = new System.Drawing.Size(90, 50);
            this.BtnRegustriyEx.TabIndex = 20;
            this.BtnRegustriyEx.Text = "导入";
            this.BtnRegustriyEx.UseVisualStyleBackColor = true;
            // 
            // BtnRegustriyRe
            // 
            this.BtnRegustriyRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegustriyRe.Location = new System.Drawing.Point(683, 0);
            this.BtnRegustriyRe.Name = "BtnRegustriyRe";
            this.BtnRegustriyRe.Size = new System.Drawing.Size(90, 50);
            this.BtnRegustriyRe.TabIndex = 19;
            this.BtnRegustriyRe.Text = "刷新";
            this.BtnRegustriyRe.UseVisualStyleBackColor = true;
            // 
            // LvRegustry
            // 
            this.LvRegustry.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvRegustry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LvRegustry.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvRegustry.FullRowSelect = true;
            this.LvRegustry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem44.Checked = true;
            listViewItem44.StateImageIndex = 1;
            this.LvRegustry.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem43,
            listViewItem44});
            this.LvRegustry.Location = new System.Drawing.Point(0, 30);
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
            // PnlREgustriy
            // 
            this.PnlREgustriy.Controls.Add(this.LblRegustriy);
            this.PnlREgustriy.Controls.Add(this.BtnRegustriyYorN);
            this.PnlREgustriy.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlREgustriy.Location = new System.Drawing.Point(0, 0);
            this.PnlREgustriy.Name = "PnlREgustriy";
            this.PnlREgustriy.Size = new System.Drawing.Size(773, 30);
            this.PnlREgustriy.TabIndex = 16;
            // 
            // LblRegustriy
            // 
            this.LblRegustriy.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblRegustriy.Location = new System.Drawing.Point(0, 0);
            this.LblRegustriy.Name = "LblRegustriy";
            this.LblRegustriy.Size = new System.Drawing.Size(600, 30);
            this.LblRegustriy.TabIndex = 15;
            this.LblRegustriy.Text = "注册表状态————————";
            this.LblRegustriy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRegustriy.Click += new System.EventHandler(this.LblRegustriy_Click);
            // 
            // BtnRegustriyYorN
            // 
            this.BtnRegustriyYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegustriyYorN.Checked = false;
            this.BtnRegustriyYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnRegustriyYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegustriyYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegustriyYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnRegustriyYorN.Name = "BtnRegustriyYorN";
            this.BtnRegustriyYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnRegustriyYorN.TabIndex = 13;
            this.BtnRegustriyYorN.Load += new System.EventHandler(this.BtnRegustriyYorN_Load);
            this.BtnRegustriyYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRegustriyYorN_MouseUp);
            // 
            // PagePlanningTask
            // 
            this.PagePlanningTask.Controls.Add(this.PnlPlanningTaskBtns);
            this.PagePlanningTask.Controls.Add(this.LvPlanningTask);
            this.PagePlanningTask.Controls.Add(this.PnlPlanningTask);
            this.PagePlanningTask.Location = new System.Drawing.Point(4, 14);
            this.PagePlanningTask.Name = "PagePlanningTask";
            this.PagePlanningTask.Size = new System.Drawing.Size(773, 504);
            this.PagePlanningTask.TabIndex = 4;
            this.PagePlanningTask.Text = "计划任务状态";
            this.PagePlanningTask.UseVisualStyleBackColor = true;
            // 
            // PnlPlanningTaskBtns
            // 
            this.PnlPlanningTaskBtns.Controls.Add(this.BtnPlanningTaskIm);
            this.PnlPlanningTaskBtns.Controls.Add(this.BtnPlanningTaskEx);
            this.PnlPlanningTaskBtns.Controls.Add(this.BtnPlanningTaskRe);
            this.PnlPlanningTaskBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPlanningTaskBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlPlanningTaskBtns.Name = "PnlPlanningTaskBtns";
            this.PnlPlanningTaskBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlPlanningTaskBtns.TabIndex = 18;
            // 
            // BtnPlanningTaskIm
            // 
            this.BtnPlanningTaskIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlanningTaskIm.Location = new System.Drawing.Point(503, 0);
            this.BtnPlanningTaskIm.Name = "BtnPlanningTaskIm";
            this.BtnPlanningTaskIm.Size = new System.Drawing.Size(90, 50);
            this.BtnPlanningTaskIm.TabIndex = 21;
            this.BtnPlanningTaskIm.Text = "导出";
            this.BtnPlanningTaskIm.UseVisualStyleBackColor = true;
            // 
            // BtnPlanningTaskEx
            // 
            this.BtnPlanningTaskEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlanningTaskEx.Location = new System.Drawing.Point(593, 0);
            this.BtnPlanningTaskEx.Name = "BtnPlanningTaskEx";
            this.BtnPlanningTaskEx.Size = new System.Drawing.Size(90, 50);
            this.BtnPlanningTaskEx.TabIndex = 20;
            this.BtnPlanningTaskEx.Text = "导入";
            this.BtnPlanningTaskEx.UseVisualStyleBackColor = true;
            // 
            // BtnPlanningTaskRe
            // 
            this.BtnPlanningTaskRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlanningTaskRe.Location = new System.Drawing.Point(683, 0);
            this.BtnPlanningTaskRe.Name = "BtnPlanningTaskRe";
            this.BtnPlanningTaskRe.Size = new System.Drawing.Size(90, 50);
            this.BtnPlanningTaskRe.TabIndex = 19;
            this.BtnPlanningTaskRe.Text = "刷新";
            this.BtnPlanningTaskRe.UseVisualStyleBackColor = true;
            // 
            // LvPlanningTask
            // 
            this.LvPlanningTask.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvPlanningTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.LvPlanningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvPlanningTask.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem46.Checked = true;
            listViewItem46.StateImageIndex = 1;
            this.LvPlanningTask.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem45,
            listViewItem46});
            this.LvPlanningTask.Location = new System.Drawing.Point(0, 30);
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
            // PnlPlanningTask
            // 
            this.PnlPlanningTask.Controls.Add(this.LblPlanningTask);
            this.PnlPlanningTask.Controls.Add(this.BtnPlanningTaskYorN);
            this.PnlPlanningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPlanningTask.Location = new System.Drawing.Point(0, 0);
            this.PnlPlanningTask.Name = "PnlPlanningTask";
            this.PnlPlanningTask.Size = new System.Drawing.Size(773, 30);
            this.PnlPlanningTask.TabIndex = 16;
            // 
            // LblPlanningTask
            // 
            this.LblPlanningTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPlanningTask.Location = new System.Drawing.Point(0, 0);
            this.LblPlanningTask.Name = "LblPlanningTask";
            this.LblPlanningTask.Size = new System.Drawing.Size(600, 30);
            this.LblPlanningTask.TabIndex = 15;
            this.LblPlanningTask.Text = "计划任务状态————————";
            this.LblPlanningTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPlanningTask.Click += new System.EventHandler(this.LblPlanningTask_Click);
            // 
            // BtnPlanningTaskYorN
            // 
            this.BtnPlanningTaskYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlanningTaskYorN.Checked = false;
            this.BtnPlanningTaskYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnPlanningTaskYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlanningTaskYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlanningTaskYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnPlanningTaskYorN.Name = "BtnPlanningTaskYorN";
            this.BtnPlanningTaskYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnPlanningTaskYorN.TabIndex = 13;
            this.BtnPlanningTaskYorN.Load += new System.EventHandler(this.BtnPlanningTaskYorN_Load);
            this.BtnPlanningTaskYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPlanningTaskYorN_MouseUp);
            // 
            // PageCtrlPnl
            // 
            this.PageCtrlPnl.Controls.Add(this.PnlCtrlPnlBtns);
            this.PageCtrlPnl.Controls.Add(this.LvCtrlPnl);
            this.PageCtrlPnl.Controls.Add(this.PnlCtrlPnl);
            this.PageCtrlPnl.Location = new System.Drawing.Point(4, 14);
            this.PageCtrlPnl.Name = "PageCtrlPnl";
            this.PageCtrlPnl.Size = new System.Drawing.Size(773, 504);
            this.PageCtrlPnl.TabIndex = 5;
            this.PageCtrlPnl.Text = "控制面板状态";
            this.PageCtrlPnl.UseVisualStyleBackColor = true;
            // 
            // PnlCtrlPnlBtns
            // 
            this.PnlCtrlPnlBtns.Controls.Add(this.BtnCtrlPnlIm);
            this.PnlCtrlPnlBtns.Controls.Add(this.BtnCtrlPnlEx);
            this.PnlCtrlPnlBtns.Controls.Add(this.BtnCtrlPnlRe);
            this.PnlCtrlPnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCtrlPnlBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlCtrlPnlBtns.Name = "PnlCtrlPnlBtns";
            this.PnlCtrlPnlBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlCtrlPnlBtns.TabIndex = 19;
            // 
            // BtnCtrlPnlIm
            // 
            this.BtnCtrlPnlIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCtrlPnlIm.Location = new System.Drawing.Point(503, 0);
            this.BtnCtrlPnlIm.Name = "BtnCtrlPnlIm";
            this.BtnCtrlPnlIm.Size = new System.Drawing.Size(90, 50);
            this.BtnCtrlPnlIm.TabIndex = 21;
            this.BtnCtrlPnlIm.Text = "导出";
            this.BtnCtrlPnlIm.UseVisualStyleBackColor = true;
            // 
            // BtnCtrlPnlEx
            // 
            this.BtnCtrlPnlEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCtrlPnlEx.Location = new System.Drawing.Point(593, 0);
            this.BtnCtrlPnlEx.Name = "BtnCtrlPnlEx";
            this.BtnCtrlPnlEx.Size = new System.Drawing.Size(90, 50);
            this.BtnCtrlPnlEx.TabIndex = 20;
            this.BtnCtrlPnlEx.Text = "导入";
            this.BtnCtrlPnlEx.UseVisualStyleBackColor = true;
            // 
            // BtnCtrlPnlRe
            // 
            this.BtnCtrlPnlRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCtrlPnlRe.Location = new System.Drawing.Point(683, 0);
            this.BtnCtrlPnlRe.Name = "BtnCtrlPnlRe";
            this.BtnCtrlPnlRe.Size = new System.Drawing.Size(90, 50);
            this.BtnCtrlPnlRe.TabIndex = 19;
            this.BtnCtrlPnlRe.Text = "刷新";
            this.BtnCtrlPnlRe.UseVisualStyleBackColor = true;
            // 
            // LvCtrlPnl
            // 
            this.LvCtrlPnl.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCtrlPnl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.LvCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCtrlPnl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem48.Checked = true;
            listViewItem48.StateImageIndex = 1;
            this.LvCtrlPnl.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem47,
            listViewItem48});
            this.LvCtrlPnl.Location = new System.Drawing.Point(0, 30);
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
            // PnlCtrlPnl
            // 
            this.PnlCtrlPnl.Controls.Add(this.LblCtrlPnl);
            this.PnlCtrlPnl.Controls.Add(this.BtnCtrlPnlYorN);
            this.PnlCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCtrlPnl.Location = new System.Drawing.Point(0, 0);
            this.PnlCtrlPnl.Name = "PnlCtrlPnl";
            this.PnlCtrlPnl.Size = new System.Drawing.Size(773, 30);
            this.PnlCtrlPnl.TabIndex = 16;
            // 
            // LblCtrlPnl
            // 
            this.LblCtrlPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCtrlPnl.Location = new System.Drawing.Point(0, 0);
            this.LblCtrlPnl.Name = "LblCtrlPnl";
            this.LblCtrlPnl.Size = new System.Drawing.Size(600, 30);
            this.LblCtrlPnl.TabIndex = 15;
            this.LblCtrlPnl.Text = "控制面板状态————————";
            this.LblCtrlPnl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCtrlPnl.Click += new System.EventHandler(this.LblCtrlPnl_Click);
            // 
            // BtnCtrlPnlYorN
            // 
            this.BtnCtrlPnlYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnCtrlPnlYorN.Checked = false;
            this.BtnCtrlPnlYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnCtrlPnlYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCtrlPnlYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCtrlPnlYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnCtrlPnlYorN.Name = "BtnCtrlPnlYorN";
            this.BtnCtrlPnlYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnCtrlPnlYorN.TabIndex = 13;
            this.BtnCtrlPnlYorN.Load += new System.EventHandler(this.BtnCtrlPnlYorN_Load);
            this.BtnCtrlPnlYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCtrlPnlYorN_MouseUp);
            // 
            // PageRunTool
            // 
            this.PageRunTool.Controls.Add(this.PnlRunToolBtns);
            this.PageRunTool.Controls.Add(this.LvRunTool);
            this.PageRunTool.Controls.Add(this.PnlRunTool);
            this.PageRunTool.Location = new System.Drawing.Point(4, 14);
            this.PageRunTool.Name = "PageRunTool";
            this.PageRunTool.Size = new System.Drawing.Size(773, 504);
            this.PageRunTool.TabIndex = 7;
            this.PageRunTool.Text = "运行工具状态";
            this.PageRunTool.UseVisualStyleBackColor = true;
            // 
            // PnlRunToolBtns
            // 
            this.PnlRunToolBtns.Controls.Add(this.BtnRunToolIm);
            this.PnlRunToolBtns.Controls.Add(this.BtnRunToolEx);
            this.PnlRunToolBtns.Controls.Add(this.BtnRunToolRe);
            this.PnlRunToolBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlRunToolBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlRunToolBtns.Name = "PnlRunToolBtns";
            this.PnlRunToolBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlRunToolBtns.TabIndex = 20;
            // 
            // BtnRunToolIm
            // 
            this.BtnRunToolIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRunToolIm.Location = new System.Drawing.Point(503, 0);
            this.BtnRunToolIm.Name = "BtnRunToolIm";
            this.BtnRunToolIm.Size = new System.Drawing.Size(90, 50);
            this.BtnRunToolIm.TabIndex = 21;
            this.BtnRunToolIm.Text = "导出";
            this.BtnRunToolIm.UseVisualStyleBackColor = true;
            // 
            // BtnRunToolEx
            // 
            this.BtnRunToolEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRunToolEx.Location = new System.Drawing.Point(593, 0);
            this.BtnRunToolEx.Name = "BtnRunToolEx";
            this.BtnRunToolEx.Size = new System.Drawing.Size(90, 50);
            this.BtnRunToolEx.TabIndex = 20;
            this.BtnRunToolEx.Text = "导入";
            this.BtnRunToolEx.UseVisualStyleBackColor = true;
            // 
            // BtnRunToolRe
            // 
            this.BtnRunToolRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRunToolRe.Location = new System.Drawing.Point(683, 0);
            this.BtnRunToolRe.Name = "BtnRunToolRe";
            this.BtnRunToolRe.Size = new System.Drawing.Size(90, 50);
            this.BtnRunToolRe.TabIndex = 19;
            this.BtnRunToolRe.Text = "刷新";
            this.BtnRunToolRe.UseVisualStyleBackColor = true;
            // 
            // LvRunTool
            // 
            this.LvRunTool.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvRunTool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.LvRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvRunTool.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem50.Checked = true;
            listViewItem50.StateImageIndex = 1;
            this.LvRunTool.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem49,
            listViewItem50});
            this.LvRunTool.Location = new System.Drawing.Point(0, 30);
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
            // PnlRunTool
            // 
            this.PnlRunTool.Controls.Add(this.LblRunTool);
            this.PnlRunTool.Controls.Add(this.BtnRunToolYorN);
            this.PnlRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlRunTool.Location = new System.Drawing.Point(0, 0);
            this.PnlRunTool.Name = "PnlRunTool";
            this.PnlRunTool.Size = new System.Drawing.Size(773, 30);
            this.PnlRunTool.TabIndex = 16;
            // 
            // LblRunTool
            // 
            this.LblRunTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblRunTool.Location = new System.Drawing.Point(0, 0);
            this.LblRunTool.Name = "LblRunTool";
            this.LblRunTool.Size = new System.Drawing.Size(600, 30);
            this.LblRunTool.TabIndex = 15;
            this.LblRunTool.Text = "运行工具状态————————";
            this.LblRunTool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRunTool.Click += new System.EventHandler(this.LblRunTool_Click);
            // 
            // BtnRunToolYorN
            // 
            this.BtnRunToolYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnRunToolYorN.Checked = false;
            this.BtnRunToolYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnRunToolYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRunToolYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRunToolYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnRunToolYorN.Name = "BtnRunToolYorN";
            this.BtnRunToolYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnRunToolYorN.TabIndex = 13;
            this.BtnRunToolYorN.Load += new System.EventHandler(this.BtnRunToolYorN_Load);
            this.BtnRunToolYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRunToolYorN_MouseUp);
            // 
            // PageTaskMgr
            // 
            this.PageTaskMgr.Controls.Add(this.PnlTaskMgrBtns);
            this.PageTaskMgr.Controls.Add(this.LvTaskMgr);
            this.PageTaskMgr.Controls.Add(this.PnlTaskMgr);
            this.PageTaskMgr.Location = new System.Drawing.Point(4, 14);
            this.PageTaskMgr.Name = "PageTaskMgr";
            this.PageTaskMgr.Size = new System.Drawing.Size(773, 504);
            this.PageTaskMgr.TabIndex = 6;
            this.PageTaskMgr.Text = "任务管理器状态";
            this.PageTaskMgr.UseVisualStyleBackColor = true;
            // 
            // PnlTaskMgrBtns
            // 
            this.PnlTaskMgrBtns.Controls.Add(this.BtnTaskMgrIm);
            this.PnlTaskMgrBtns.Controls.Add(this.BtnTaskMgrEx);
            this.PnlTaskMgrBtns.Controls.Add(this.BtnTaskMgrRe);
            this.PnlTaskMgrBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlTaskMgrBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlTaskMgrBtns.Name = "PnlTaskMgrBtns";
            this.PnlTaskMgrBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlTaskMgrBtns.TabIndex = 21;
            // 
            // BtnTaskMgrIm
            // 
            this.BtnTaskMgrIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTaskMgrIm.Location = new System.Drawing.Point(503, 0);
            this.BtnTaskMgrIm.Name = "BtnTaskMgrIm";
            this.BtnTaskMgrIm.Size = new System.Drawing.Size(90, 50);
            this.BtnTaskMgrIm.TabIndex = 21;
            this.BtnTaskMgrIm.Text = "导出";
            this.BtnTaskMgrIm.UseVisualStyleBackColor = true;
            // 
            // BtnTaskMgrEx
            // 
            this.BtnTaskMgrEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTaskMgrEx.Location = new System.Drawing.Point(593, 0);
            this.BtnTaskMgrEx.Name = "BtnTaskMgrEx";
            this.BtnTaskMgrEx.Size = new System.Drawing.Size(90, 50);
            this.BtnTaskMgrEx.TabIndex = 20;
            this.BtnTaskMgrEx.Text = "导入";
            this.BtnTaskMgrEx.UseVisualStyleBackColor = true;
            // 
            // BtnTaskMgrRe
            // 
            this.BtnTaskMgrRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTaskMgrRe.Location = new System.Drawing.Point(683, 0);
            this.BtnTaskMgrRe.Name = "BtnTaskMgrRe";
            this.BtnTaskMgrRe.Size = new System.Drawing.Size(90, 50);
            this.BtnTaskMgrRe.TabIndex = 19;
            this.BtnTaskMgrRe.Text = "刷新";
            this.BtnTaskMgrRe.UseVisualStyleBackColor = true;
            // 
            // LvTaskMgr
            // 
            this.LvTaskMgr.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvTaskMgr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.LvTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvTaskMgr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem52.Checked = true;
            listViewItem52.StateImageIndex = 1;
            this.LvTaskMgr.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem51,
            listViewItem52});
            this.LvTaskMgr.Location = new System.Drawing.Point(0, 30);
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
            // PnlTaskMgr
            // 
            this.PnlTaskMgr.Controls.Add(this.LblTaskMgr);
            this.PnlTaskMgr.Controls.Add(this.BtnTaskMgrYorN);
            this.PnlTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTaskMgr.Location = new System.Drawing.Point(0, 0);
            this.PnlTaskMgr.Name = "PnlTaskMgr";
            this.PnlTaskMgr.Size = new System.Drawing.Size(773, 30);
            this.PnlTaskMgr.TabIndex = 16;
            // 
            // LblTaskMgr
            // 
            this.LblTaskMgr.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTaskMgr.Location = new System.Drawing.Point(0, 0);
            this.LblTaskMgr.Name = "LblTaskMgr";
            this.LblTaskMgr.Size = new System.Drawing.Size(600, 30);
            this.LblTaskMgr.TabIndex = 15;
            this.LblTaskMgr.Text = "任务管理器状态————————";
            this.LblTaskMgr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTaskMgr.Click += new System.EventHandler(this.LblTaskMgr_Click);
            // 
            // BtnTaskMgrYorN
            // 
            this.BtnTaskMgrYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnTaskMgrYorN.Checked = false;
            this.BtnTaskMgrYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnTaskMgrYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTaskMgrYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTaskMgrYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnTaskMgrYorN.Name = "BtnTaskMgrYorN";
            this.BtnTaskMgrYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnTaskMgrYorN.TabIndex = 13;
            this.BtnTaskMgrYorN.Load += new System.EventHandler(this.BtnTaskMgrYorN_Load);
            this.BtnTaskMgrYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnTaskMgrYorN_MouseUp);
            // 
            // PageCmd
            // 
            this.PageCmd.Controls.Add(this.PnlCmdBtns);
            this.PageCmd.Controls.Add(this.LvCmd);
            this.PageCmd.Controls.Add(this.PnlCmd);
            this.PageCmd.Location = new System.Drawing.Point(4, 14);
            this.PageCmd.Name = "PageCmd";
            this.PageCmd.Size = new System.Drawing.Size(773, 504);
            this.PageCmd.TabIndex = 8;
            this.PageCmd.Text = "命令指示符状态";
            this.PageCmd.UseVisualStyleBackColor = true;
            // 
            // PnlCmdBtns
            // 
            this.PnlCmdBtns.Controls.Add(this.BtnCmdIm);
            this.PnlCmdBtns.Controls.Add(this.BtnCmdEx);
            this.PnlCmdBtns.Controls.Add(this.BtnCmdRe);
            this.PnlCmdBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCmdBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlCmdBtns.Name = "PnlCmdBtns";
            this.PnlCmdBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlCmdBtns.TabIndex = 22;
            // 
            // BtnCmdIm
            // 
            this.BtnCmdIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCmdIm.Location = new System.Drawing.Point(503, 0);
            this.BtnCmdIm.Name = "BtnCmdIm";
            this.BtnCmdIm.Size = new System.Drawing.Size(90, 50);
            this.BtnCmdIm.TabIndex = 21;
            this.BtnCmdIm.Text = "导出";
            this.BtnCmdIm.UseVisualStyleBackColor = true;
            // 
            // BtnCmdEx
            // 
            this.BtnCmdEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCmdEx.Location = new System.Drawing.Point(593, 0);
            this.BtnCmdEx.Name = "BtnCmdEx";
            this.BtnCmdEx.Size = new System.Drawing.Size(90, 50);
            this.BtnCmdEx.TabIndex = 20;
            this.BtnCmdEx.Text = "导入";
            this.BtnCmdEx.UseVisualStyleBackColor = true;
            // 
            // BtnCmdRe
            // 
            this.BtnCmdRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCmdRe.Location = new System.Drawing.Point(683, 0);
            this.BtnCmdRe.Name = "BtnCmdRe";
            this.BtnCmdRe.Size = new System.Drawing.Size(90, 50);
            this.BtnCmdRe.TabIndex = 19;
            this.BtnCmdRe.Text = "刷新";
            this.BtnCmdRe.UseVisualStyleBackColor = true;
            // 
            // LvCmd
            // 
            this.LvCmd.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCmd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.LvCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCmd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem54.Checked = true;
            listViewItem54.StateImageIndex = 1;
            this.LvCmd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem53,
            listViewItem54});
            this.LvCmd.Location = new System.Drawing.Point(0, 30);
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
            // PnlCmd
            // 
            this.PnlCmd.Controls.Add(this.LblCmd);
            this.PnlCmd.Controls.Add(this.BtnCmdYorN);
            this.PnlCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCmd.Location = new System.Drawing.Point(0, 0);
            this.PnlCmd.Name = "PnlCmd";
            this.PnlCmd.Size = new System.Drawing.Size(773, 30);
            this.PnlCmd.TabIndex = 16;
            // 
            // LblCmd
            // 
            this.LblCmd.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblCmd.Location = new System.Drawing.Point(0, 0);
            this.LblCmd.Name = "LblCmd";
            this.LblCmd.Size = new System.Drawing.Size(600, 30);
            this.LblCmd.TabIndex = 15;
            this.LblCmd.Text = "命令指示符状态————————";
            this.LblCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCmd.Click += new System.EventHandler(this.LblCmd_Click);
            // 
            // BtnCmdYorN
            // 
            this.BtnCmdYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnCmdYorN.Checked = false;
            this.BtnCmdYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnCmdYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCmdYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCmdYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnCmdYorN.Name = "BtnCmdYorN";
            this.BtnCmdYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnCmdYorN.TabIndex = 13;
            this.BtnCmdYorN.Load += new System.EventHandler(this.BtnCmdYorN_Load);
            this.BtnCmdYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCmdYorN_MouseUp);
            // 
            // PagePS
            // 
            this.PagePS.Controls.Add(this.PnlPsBtns);
            this.PagePS.Controls.Add(this.LvPS);
            this.PagePS.Controls.Add(this.PnlPS);
            this.PagePS.Location = new System.Drawing.Point(4, 14);
            this.PagePS.Name = "PagePS";
            this.PagePS.Size = new System.Drawing.Size(773, 504);
            this.PagePS.TabIndex = 9;
            this.PagePS.Text = "PowerShell状态";
            this.PagePS.UseVisualStyleBackColor = true;
            // 
            // PnlPsBtns
            // 
            this.PnlPsBtns.Controls.Add(this.BtnPSIm);
            this.PnlPsBtns.Controls.Add(this.BtnPSEx);
            this.PnlPsBtns.Controls.Add(this.BtnPSRe);
            this.PnlPsBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPsBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlPsBtns.Name = "PnlPsBtns";
            this.PnlPsBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlPsBtns.TabIndex = 23;
            // 
            // BtnPSIm
            // 
            this.BtnPSIm.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPSIm.Location = new System.Drawing.Point(503, 0);
            this.BtnPSIm.Name = "BtnPSIm";
            this.BtnPSIm.Size = new System.Drawing.Size(90, 50);
            this.BtnPSIm.TabIndex = 21;
            this.BtnPSIm.Text = "导出";
            this.BtnPSIm.UseVisualStyleBackColor = true;
            // 
            // BtnPSEx
            // 
            this.BtnPSEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPSEx.Location = new System.Drawing.Point(593, 0);
            this.BtnPSEx.Name = "BtnPSEx";
            this.BtnPSEx.Size = new System.Drawing.Size(90, 50);
            this.BtnPSEx.TabIndex = 20;
            this.BtnPSEx.Text = "导入";
            this.BtnPSEx.UseVisualStyleBackColor = true;
            // 
            // BtnPSRe
            // 
            this.BtnPSRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPSRe.Location = new System.Drawing.Point(683, 0);
            this.BtnPSRe.Name = "BtnPSRe";
            this.BtnPSRe.Size = new System.Drawing.Size(90, 50);
            this.BtnPSRe.TabIndex = 19;
            this.BtnPSRe.Text = "刷新";
            this.BtnPSRe.UseVisualStyleBackColor = true;
            // 
            // LvPS
            // 
            this.LvPS.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvPS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20});
            this.LvPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvPS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem56.Checked = true;
            listViewItem56.StateImageIndex = 1;
            this.LvPS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem55,
            listViewItem56});
            this.LvPS.Location = new System.Drawing.Point(0, 30);
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
            // PnlPS
            // 
            this.PnlPS.Controls.Add(this.LblPS);
            this.PnlPS.Controls.Add(this.BtnPSYorN);
            this.PnlPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPS.Location = new System.Drawing.Point(0, 0);
            this.PnlPS.Name = "PnlPS";
            this.PnlPS.Size = new System.Drawing.Size(773, 30);
            this.PnlPS.TabIndex = 16;
            // 
            // LblPS
            // 
            this.LblPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblPS.Location = new System.Drawing.Point(0, 0);
            this.LblPS.Name = "LblPS";
            this.LblPS.Size = new System.Drawing.Size(600, 30);
            this.LblPS.TabIndex = 15;
            this.LblPS.Text = "PowerShell状态————————";
            this.LblPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPS.Click += new System.EventHandler(this.LblPS_Click);
            // 
            // BtnPSYorN
            // 
            this.BtnPSYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnPSYorN.Checked = false;
            this.BtnPSYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnPSYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPSYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPSYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnPSYorN.Name = "BtnPSYorN";
            this.BtnPSYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnPSYorN.TabIndex = 13;
            this.BtnPSYorN.Load += new System.EventHandler(this.BtnPSYorN_Load);
            this.BtnPSYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPSYorN_MouseUp);
            // 
            // PageProcCtrl
            // 
            this.PageProcCtrl.Controls.Add(this.PnlListTP);
            this.PageProcCtrl.Controls.Add(this.PnlWList);
            this.PageProcCtrl.Controls.Add(this.PnlWListTN);
            this.PageProcCtrl.Controls.Add(this.PnlBList);
            this.PageProcCtrl.Controls.Add(this.PnlBListTN);
            this.PageProcCtrl.Location = new System.Drawing.Point(4, 14);
            this.PageProcCtrl.Name = "PageProcCtrl";
            this.PageProcCtrl.Size = new System.Drawing.Size(773, 504);
            this.PageProcCtrl.TabIndex = 10;
            this.PageProcCtrl.Text = "进程管控";
            this.PageProcCtrl.UseVisualStyleBackColor = true;
            // 
            // PnlListTP
            // 
            this.PnlListTP.Controls.Add(this.BtnListPathYorN);
            this.PnlListTP.Controls.Add(this.BtnListSetP);
            this.PnlListTP.Controls.Add(this.LblListTP);
            this.PnlListTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlListTP.Location = new System.Drawing.Point(0, 257);
            this.PnlListTP.Name = "PnlListTP";
            this.PnlListTP.Size = new System.Drawing.Size(773, 30);
            this.PnlListTP.TabIndex = 17;
            // 
            // BtnListPathYorN
            // 
            this.BtnListPathYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnListPathYorN.Checked = false;
            this.BtnListPathYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnListPathYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListPathYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnListPathYorN.Location = new System.Drawing.Point(693, 0);
            this.BtnListPathYorN.Name = "BtnListPathYorN";
            this.BtnListPathYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnListPathYorN.TabIndex = 16;
            // 
            // LblListTP
            // 
            this.LblListTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblListTP.Location = new System.Drawing.Point(0, 0);
            this.LblListTP.Name = "LblListTP";
            this.LblListTP.Size = new System.Drawing.Size(600, 30);
            this.LblListTP.TabIndex = 0;
            this.LblListTP.Text = "黑白名单（路径）>>";
            this.LblListTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlWList
            // 
            this.PnlWList.Controls.Add(this.LvWListN);
            this.PnlWList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlWList.Location = new System.Drawing.Point(0, 157);
            this.PnlWList.Name = "PnlWList";
            this.PnlWList.Size = new System.Drawing.Size(773, 100);
            this.PnlWList.TabIndex = 10;
            // 
            // LvWListN
            // 
            this.LvWListN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvWListN.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem57,
            listViewItem58});
            this.LvWListN.Location = new System.Drawing.Point(0, 0);
            this.LvWListN.Name = "LvWListN";
            this.LvWListN.Size = new System.Drawing.Size(773, 100);
            this.LvWListN.TabIndex = 0;
            this.LvWListN.UseCompatibleStateImageBehavior = false;
            this.LvWListN.View = System.Windows.Forms.View.List;
            // 
            // PnlWListTN
            // 
            this.PnlWListTN.Controls.Add(this.BtnWListYorN);
            this.PnlWListTN.Controls.Add(this.BtnWListSet);
            this.PnlWListTN.Controls.Add(this.LblWListTN);
            this.PnlWListTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlWListTN.Location = new System.Drawing.Point(0, 127);
            this.PnlWListTN.Name = "PnlWListTN";
            this.PnlWListTN.Size = new System.Drawing.Size(773, 30);
            this.PnlWListTN.TabIndex = 15;
            // 
            // BtnWListYorN
            // 
            this.BtnWListYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnWListYorN.Checked = false;
            this.BtnWListYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnWListYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWListYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnWListYorN.Location = new System.Drawing.Point(693, 0);
            this.BtnWListYorN.Name = "BtnWListYorN";
            this.BtnWListYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnWListYorN.TabIndex = 16;
            this.BtnWListYorN.Load += new System.EventHandler(this.BtnWListYorN_Load);
            this.BtnWListYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnWListYorNStatus_MouseUp);
            // 
            // LblWListTN
            // 
            this.LblWListTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblWListTN.Location = new System.Drawing.Point(0, 0);
            this.LblWListTN.Name = "LblWListTN";
            this.LblWListTN.Size = new System.Drawing.Size(600, 30);
            this.LblWListTN.TabIndex = 0;
            this.LblWListTN.Text = "白名单（名称）>>";
            this.LblWListTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblWListTN.Click += new System.EventHandler(this.WListTNCtrl_Click);
            // 
            // PnlBList
            // 
            this.PnlBList.Controls.Add(this.LvBListN);
            this.PnlBList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBList.Location = new System.Drawing.Point(0, 30);
            this.PnlBList.Name = "PnlBList";
            this.PnlBList.Size = new System.Drawing.Size(773, 97);
            this.PnlBList.TabIndex = 9;
            // 
            // LvBListN
            // 
            this.LvBListN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvBListN.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem59,
            listViewItem60});
            this.LvBListN.Location = new System.Drawing.Point(0, 0);
            this.LvBListN.Name = "LvBListN";
            this.LvBListN.Size = new System.Drawing.Size(773, 95);
            this.LvBListN.TabIndex = 18;
            this.LvBListN.UseCompatibleStateImageBehavior = false;
            this.LvBListN.View = System.Windows.Forms.View.List;
            // 
            // PnlBListTN
            // 
            this.PnlBListTN.Controls.Add(this.LblBListTitleN);
            this.PnlBListTN.Controls.Add(this.BtnBListYorN);
            this.PnlBListTN.Controls.Add(this.BtnBListSet);
            this.PnlBListTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBListTN.Location = new System.Drawing.Point(0, 0);
            this.PnlBListTN.Name = "PnlBListTN";
            this.PnlBListTN.Size = new System.Drawing.Size(773, 30);
            this.PnlBListTN.TabIndex = 14;
            // 
            // LblBListTitleN
            // 
            this.LblBListTitleN.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblBListTitleN.Location = new System.Drawing.Point(0, 0);
            this.LblBListTitleN.Name = "LblBListTitleN";
            this.LblBListTitleN.Size = new System.Drawing.Size(600, 30);
            this.LblBListTitleN.TabIndex = 15;
            this.LblBListTitleN.Text = "黑名单（名称）>>";
            this.LblBListTitleN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBListTitleN.Click += new System.EventHandler(this.BListTNCtrl_Click);
            // 
            // BtnBListYorN
            // 
            this.BtnBListYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnBListYorN.Checked = false;
            this.BtnBListYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnBListYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBListYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBListYorN.Location = new System.Drawing.Point(693, 0);
            this.BtnBListYorN.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBListYorN.Name = "BtnBListYorN";
            this.BtnBListYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnBListYorN.TabIndex = 13;
            this.BtnBListYorN.Load += new System.EventHandler(this.BtnBListYorN_Load);
            this.BtnBListYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBListYorNStatus_MouseUp);
            // 
            // PageOptimization
            // 
            this.PageOptimization.AutoScroll = true;
            this.PageOptimization.ImageIndex = 1;
            this.PageOptimization.Location = new System.Drawing.Point(4, 14);
            this.PageOptimization.Name = "PageOptimization";
            this.PageOptimization.Padding = new System.Windows.Forms.Padding(3);
            this.PageOptimization.Size = new System.Drawing.Size(773, 504);
            this.PageOptimization.TabIndex = 1;
            this.PageOptimization.Text = "系统优化";
            // 
            // BtnListSetP
            // 
            this.BtnListSetP.BackgroundImage = global::Vexease.Properties.Resources.Set;
            this.BtnListSetP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnListSetP.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnListSetP.FlatAppearance.BorderSize = 0;
            this.BtnListSetP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListSetP.ForeColor = System.Drawing.Color.Transparent;
            this.BtnListSetP.Location = new System.Drawing.Point(743, 0);
            this.BtnListSetP.Name = "BtnListSetP";
            this.BtnListSetP.Size = new System.Drawing.Size(30, 30);
            this.BtnListSetP.TabIndex = 15;
            this.BtnListSetP.UseVisualStyleBackColor = true;
            this.BtnListSetP.Click += new System.EventHandler(this.BtnListSetP_Click);
            // 
            // BtnWListSet
            // 
            this.BtnWListSet.BackgroundImage = global::Vexease.Properties.Resources.Set;
            this.BtnWListSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnWListSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnWListSet.FlatAppearance.BorderSize = 0;
            this.BtnWListSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWListSet.Location = new System.Drawing.Point(743, 0);
            this.BtnWListSet.Name = "BtnWListSet";
            this.BtnWListSet.Size = new System.Drawing.Size(30, 30);
            this.BtnWListSet.TabIndex = 15;
            this.BtnWListSet.UseVisualStyleBackColor = true;
            this.BtnWListSet.Click += new System.EventHandler(this.BtnWListSet_Click);
            // 
            // BtnBListSet
            // 
            this.BtnBListSet.BackgroundImage = global::Vexease.Properties.Resources.Set;
            this.BtnBListSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBListSet.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBListSet.FlatAppearance.BorderSize = 0;
            this.BtnBListSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBListSet.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBListSet.Location = new System.Drawing.Point(743, 0);
            this.BtnBListSet.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBListSet.Name = "BtnBListSet";
            this.BtnBListSet.Size = new System.Drawing.Size(30, 30);
            this.BtnBListSet.TabIndex = 14;
            this.BtnBListSet.UseVisualStyleBackColor = true;
            this.BtnBListSet.Click += new System.EventHandler(this.BtnBListSet_Click);
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.SplAdm);
            this.Controls.Add(this.MenuStripAdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripAdm;
            this.Name = "AdmForm";
            this.Text = "管理员模式";
            this.Load += new System.EventHandler(this.AdmForm_Load);
            this.MenuStripAdm.ResumeLayout(false);
            this.MenuStripAdm.PerformLayout();
            this.SplAdm.Panel1.ResumeLayout(false);
            this.SplAdm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplAdm)).EndInit();
            this.SplAdm.ResumeLayout(false);
            this.TabCtrlAdm.ResumeLayout(false);
            this.PageInstruction.ResumeLayout(false);
            this.PageInstruction.PerformLayout();
            this.PageAbout.ResumeLayout(false);
            this.PageAbout.PerformLayout();
            this.PageConsole.ResumeLayout(false);
            this.PnlConsoleBtns.ResumeLayout(false);
            this.PnlConsole.ResumeLayout(false);
            this.PageRegustry.ResumeLayout(false);
            this.PnlRegustriyBtns.ResumeLayout(false);
            this.PnlREgustriy.ResumeLayout(false);
            this.PagePlanningTask.ResumeLayout(false);
            this.PnlPlanningTaskBtns.ResumeLayout(false);
            this.PnlPlanningTask.ResumeLayout(false);
            this.PageCtrlPnl.ResumeLayout(false);
            this.PnlCtrlPnlBtns.ResumeLayout(false);
            this.PnlCtrlPnl.ResumeLayout(false);
            this.PageRunTool.ResumeLayout(false);
            this.PnlRunToolBtns.ResumeLayout(false);
            this.PnlRunTool.ResumeLayout(false);
            this.PageTaskMgr.ResumeLayout(false);
            this.PnlTaskMgrBtns.ResumeLayout(false);
            this.PnlTaskMgr.ResumeLayout(false);
            this.PageCmd.ResumeLayout(false);
            this.PnlCmdBtns.ResumeLayout(false);
            this.PnlCmd.ResumeLayout(false);
            this.PagePS.ResumeLayout(false);
            this.PnlPsBtns.ResumeLayout(false);
            this.PnlPS.ResumeLayout(false);
            this.PageProcCtrl.ResumeLayout(false);
            this.PnlListTP.ResumeLayout(false);
            this.PnlWList.ResumeLayout(false);
            this.PnlWListTN.ResumeLayout(false);
            this.PnlBList.ResumeLayout(false);
            this.PnlBListTN.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem MenuSet;
        private System.Windows.Forms.ToolStripMenuItem MenuSetIP;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHlepView;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private ImageList ImageList;
        private NotifyIcon NotifyIcon;
        private SplitContainer SplAdm;
        private TabControl TabCtrlAdm;
        private TabPage PageAbout;
        private Label LblAbout;
        private TabPage PageConsole;
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
        private ListView LvPlanningTask;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView LvCtrlPnl;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView LvRunTool;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ListView LvTaskMgr;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ListView LvCmd;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ListView LvPS;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private Button Btnyouhua;
        private Label LblStatus;
        private Label LblOptimization;
        private ListView LvConsole;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private Button BtnProcCtrl;
        private TabPage PageProcCtrl;
        private Panel PnlWList;
        private ListView LvWListN;
        private Panel PnlBList;
        private ListView LvBListN;
        private BtnYorN BtnBListYorN;
        private Panel PnlBListTN;
        private Button BtnBListSet;
        private Panel PnlWListTN;
        private Label LblWListTN;
        private Label LblBListTitleN;
        private BtnYorN BtnWListYorN;
        private Button BtnWListSet;
        private TabPage PageInstruction;
        private Label label1;
        private Panel PnlListTP;
        private BtnYorN BtnListPathYorN;
        private Button BtnListSetP;
        private Label LblListTP;
        private Panel PnlEmpty;
        private Panel PnlConsole;
        private Label LblConsole;
        private BtnYorN BtnConsoleYorN;
        private Panel PnlREgustriy;
        private Label LblRegustriy;
        private BtnYorN BtnRegustriyYorN;
        private Panel PnlPlanningTask;
        private Label LblPlanningTask;
        private BtnYorN BtnPlanningTaskYorN;
        private Panel PnlCtrlPnl;
        private Label LblCtrlPnl;
        private BtnYorN BtnCtrlPnlYorN;
        private Panel PnlRunTool;
        private Label LblRunTool;
        private BtnYorN BtnRunToolYorN;
        private Panel PnlTaskMgr;
        private Label LblTaskMgr;
        private BtnYorN BtnTaskMgrYorN;
        private Panel PnlCmd;
        private Label LblCmd;
        private BtnYorN BtnCmdYorN;
        private Panel PnlPS;
        private Label LblPS;
        private BtnYorN BtnPSYorN;
        private Panel PnlConsoleBtns;
        private Button BtnConsoleEx;
        private Button BtnConsoleIm;
        private Button BtnConsoleRe;
        private Panel PnlRegustriyBtns;
        private Button BtnRegustriyIm;
        private Button BtnRegustriyEx;
        private Button BtnRegustriyRe;
        private Panel PnlPlanningTaskBtns;
        private Button BtnPlanningTaskIm;
        private Button BtnPlanningTaskEx;
        private Button BtnPlanningTaskRe;
        private Panel PnlCtrlPnlBtns;
        private Button BtnCtrlPnlIm;
        private Button BtnCtrlPnlEx;
        private Button BtnCtrlPnlRe;
        private Panel PnlRunToolBtns;
        private Button BtnRunToolIm;
        private Button BtnRunToolEx;
        private Button BtnRunToolRe;
        private Panel PnlTaskMgrBtns;
        private Button BtnTaskMgrIm;
        private Button BtnTaskMgrEx;
        private Button BtnTaskMgrRe;
        private Panel PnlCmdBtns;
        private Button BtnCmdIm;
        private Button BtnCmdEx;
        private Button BtnCmdRe;
        private Panel PnlPsBtns;
        private Button BtnPSIm;
        private Button BtnPSEx;
        private Button BtnPSRe;
    }
}