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
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已启用",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用",
            "此处添加button"}, -1);
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem(new string[] {
            "禁用",
            "已禁用"}, -1);
            this.MenuStripAdm = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPwdChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHlepView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SplAdm = new System.Windows.Forms.SplitContainer();
            this.BtnEx = new System.Windows.Forms.Button();
            this.BtnIm = new System.Windows.Forms.Button();
            this.LblOptimization = new System.Windows.Forms.Label();
            this.BtnProcCtrl = new System.Windows.Forms.Button();
            this.BtnPS = new System.Windows.Forms.Button();
            this.BtnCmd = new System.Windows.Forms.Button();
            this.BtnTaskMgr = new System.Windows.Forms.Button();
            this.BtnRunTool = new System.Windows.Forms.Button();
            this.BtnCtrlPnl = new System.Windows.Forms.Button();
            this.BtnRegustry = new System.Windows.Forms.Button();
            this.BtnConsole = new System.Windows.Forms.Button();
            this.BtnSys = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TabCtrlAdm = new System.Windows.Forms.TabControl();
            this.PageAbout = new System.Windows.Forms.TabPage();
            this.LblCreater3 = new System.Windows.Forms.LinkLabel();
            this.LblCreater2 = new System.Windows.Forms.LinkLabel();
            this.LblCreater1 = new System.Windows.Forms.LinkLabel();
            this.LblCreacters = new System.Windows.Forms.Label();
            this.LblTitleInAbout2 = new System.Windows.Forms.Label();
            this.LblAbout = new System.Windows.Forms.Label();
            this.RTxtBoxAbout = new System.Windows.Forms.RichTextBox();
            this.LblTitleInAbout = new System.Windows.Forms.Label();
            this.LblIconInAbout = new System.Windows.Forms.Label();
            this.PageConsole = new System.Windows.Forms.TabPage();
            this.RTxtBoxConsole = new System.Windows.Forms.RichTextBox();
            this.PnlConsoleBtns = new System.Windows.Forms.Panel();
            this.BtnConsoleRe = new System.Windows.Forms.Button();
            this.LvConsole = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlConsole = new System.Windows.Forms.Panel();
            this.LblConsole = new System.Windows.Forms.Label();
            this.BtnConsoleYorN = new Vexease.Views.BtnYorN();
            this.PageRegustry = new System.Windows.Forms.TabPage();
            this.RTxtBoxRegustry = new System.Windows.Forms.RichTextBox();
            this.PnlRegustriyBtns = new System.Windows.Forms.Panel();
            this.BtnRegustriyRe = new System.Windows.Forms.Button();
            this.LvRegustry = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlREgustriy = new System.Windows.Forms.Panel();
            this.LblRegustriy = new System.Windows.Forms.Label();
            this.BtnRegustriyYorN = new Vexease.Views.BtnYorN();
            this.PagePlanningTask = new System.Windows.Forms.TabPage();
            this.RTxtBoxPlanningTask = new System.Windows.Forms.RichTextBox();
            this.PnlPlanningTaskBtns = new System.Windows.Forms.Panel();
            this.BtnPlanningTaskRe = new System.Windows.Forms.Button();
            this.LvSys = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlPlanningTask = new System.Windows.Forms.Panel();
            this.LblSys = new System.Windows.Forms.Label();
            this.BtnSysYorN = new Vexease.Views.BtnYorN();
            this.PageCtrlPnl = new System.Windows.Forms.TabPage();
            this.RTxtBoxCtrlPnl = new System.Windows.Forms.RichTextBox();
            this.PnlCtrlPnlBtns = new System.Windows.Forms.Panel();
            this.BtnCtrlPnlRe = new System.Windows.Forms.Button();
            this.LvCtrlPnl = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlCtrlPnl = new System.Windows.Forms.Panel();
            this.LblCtrlPnl = new System.Windows.Forms.Label();
            this.BtnCtrlPnlYorN = new Vexease.Views.BtnYorN();
            this.PageRunTool = new System.Windows.Forms.TabPage();
            this.RTxtBoxRunTool = new System.Windows.Forms.RichTextBox();
            this.PnlRunToolBtns = new System.Windows.Forms.Panel();
            this.BtnRunToolRe = new System.Windows.Forms.Button();
            this.LvRunTool = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlRunTool = new System.Windows.Forms.Panel();
            this.LblRunTool = new System.Windows.Forms.Label();
            this.BtnRunToolYorN = new Vexease.Views.BtnYorN();
            this.PageTaskMgr = new System.Windows.Forms.TabPage();
            this.RTxtBoxTaskMgr = new System.Windows.Forms.RichTextBox();
            this.PnlTaskMgrBtns = new System.Windows.Forms.Panel();
            this.BtnTaskMgrRe = new System.Windows.Forms.Button();
            this.LvTaskMgr = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlTaskMgr = new System.Windows.Forms.Panel();
            this.LblTaskMgr = new System.Windows.Forms.Label();
            this.BtnTaskMgrYorN = new Vexease.Views.BtnYorN();
            this.PageCmd = new System.Windows.Forms.TabPage();
            this.RTxtBoxCMD = new System.Windows.Forms.RichTextBox();
            this.PnlCmdBtns = new System.Windows.Forms.Panel();
            this.BtnCmdRe = new System.Windows.Forms.Button();
            this.LvCmd = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlCmd = new System.Windows.Forms.Panel();
            this.LblCmd = new System.Windows.Forms.Label();
            this.BtnCmdYorN = new Vexease.Views.BtnYorN();
            this.PagePS = new System.Windows.Forms.TabPage();
            this.RTxtBoxPS = new System.Windows.Forms.RichTextBox();
            this.PnlPsBtns = new System.Windows.Forms.Panel();
            this.BtnPSRe = new System.Windows.Forms.Button();
            this.LvPS = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PnlPS = new System.Windows.Forms.Panel();
            this.LblPS = new System.Windows.Forms.Label();
            this.BtnPSYorN = new Vexease.Views.BtnYorN();
            this.PageProcCtrl = new System.Windows.Forms.TabPage();
            this.RTxtBoxProcCtrl = new System.Windows.Forms.RichTextBox();
            this.PnlListTP = new System.Windows.Forms.Panel();
            this.BtnListPathYorN = new Vexease.Views.BtnYorN();
            this.BtnListSetP = new System.Windows.Forms.Button();
            this.LblListTP = new System.Windows.Forms.Label();
            this.PnlWList = new System.Windows.Forms.Panel();
            this.LvWListN = new System.Windows.Forms.ListView();
            this.PnlWListTN = new System.Windows.Forms.Panel();
            this.BtnWListYorN = new Vexease.Views.BtnYorN();
            this.BtnWListSet = new System.Windows.Forms.Button();
            this.LblWListTN = new System.Windows.Forms.Label();
            this.PnlBList = new System.Windows.Forms.Panel();
            this.LvBListN = new System.Windows.Forms.ListView();
            this.PnlBListTN = new System.Windows.Forms.Panel();
            this.LblBListTitleN = new System.Windows.Forms.Label();
            this.BtnBListYorN = new Vexease.Views.BtnYorN();
            this.BtnBListSet = new System.Windows.Forms.Button();
            this.PageOptimization = new System.Windows.Forms.TabPage();
            this.PageInstruction = new System.Windows.Forms.TabPage();
            this.LblInstruction = new System.Windows.Forms.Label();
            this.LblTitleInInstruction = new System.Windows.Forms.Label();
            this.RTxtBoxBrief = new System.Windows.Forms.RichTextBox();
            this.LblIconInInstruction = new System.Windows.Forms.Label();
            TSMIREflesh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplAdm)).BeginInit();
            this.SplAdm.Panel1.SuspendLayout();
            this.SplAdm.Panel2.SuspendLayout();
            this.SplAdm.SuspendLayout();
            this.TabCtrlAdm.SuspendLayout();
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
            this.PageInstruction.SuspendLayout();
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
            this.MenuStripAdm.BackColor = System.Drawing.Color.White;
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
            this.MenuSetIP,
            this.MenuPwdChange});
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
            // MenuPwdChange
            // 
            this.MenuPwdChange.Name = "MenuPwdChange";
            this.MenuPwdChange.Size = new System.Drawing.Size(157, 26);
            this.MenuPwdChange.Text = "修改密码";
            this.MenuPwdChange.Click += new System.EventHandler(this.MenuPwdChange_Click);
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
            this.SplAdm.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SplAdm.Panel1.Controls.Add(this.BtnEx);
            this.SplAdm.Panel1.Controls.Add(this.BtnIm);
            this.SplAdm.Panel1.Controls.Add(this.LblOptimization);
            this.SplAdm.Panel1.Controls.Add(this.BtnProcCtrl);
            this.SplAdm.Panel1.Controls.Add(this.BtnPS);
            this.SplAdm.Panel1.Controls.Add(this.BtnCmd);
            this.SplAdm.Panel1.Controls.Add(this.BtnTaskMgr);
            this.SplAdm.Panel1.Controls.Add(this.BtnRunTool);
            this.SplAdm.Panel1.Controls.Add(this.BtnCtrlPnl);
            this.SplAdm.Panel1.Controls.Add(this.BtnRegustry);
            this.SplAdm.Panel1.Controls.Add(this.BtnConsole);
            this.SplAdm.Panel1.Controls.Add(this.BtnSys);
            this.SplAdm.Panel1.Controls.Add(this.LblStatus);
            this.SplAdm.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplAdm_Panel1_Paint);
            // 
            // SplAdm.Panel2
            // 
            this.SplAdm.Panel2.AutoScroll = true;
            this.SplAdm.Panel2.Controls.Add(this.TabCtrlAdm);
            this.SplAdm.Size = new System.Drawing.Size(985, 522);
            this.SplAdm.SplitterDistance = 200;
            this.SplAdm.TabIndex = 2;
            // 
            // BtnEx
            // 
            this.BtnEx.BackColor = System.Drawing.Color.White;
            this.BtnEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEx.FlatAppearance.BorderSize = 0;
            this.BtnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEx.Location = new System.Drawing.Point(0, 412);
            this.BtnEx.Name = "BtnEx";
            this.BtnEx.Size = new System.Drawing.Size(200, 42);
            this.BtnEx.TabIndex = 16;
            this.BtnEx.TabStop = false;
            this.BtnEx.Text = "导出";
            this.BtnEx.UseVisualStyleBackColor = false;
            this.BtnEx.Click += new System.EventHandler(this.MenuFileExport_Click);
            // 
            // BtnIm
            // 
            this.BtnIm.BackColor = System.Drawing.Color.White;
            this.BtnIm.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIm.FlatAppearance.BorderSize = 0;
            this.BtnIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIm.Location = new System.Drawing.Point(0, 370);
            this.BtnIm.Name = "BtnIm";
            this.BtnIm.Size = new System.Drawing.Size(200, 42);
            this.BtnIm.TabIndex = 15;
            this.BtnIm.TabStop = false;
            this.BtnIm.Text = "导入";
            this.BtnIm.UseVisualStyleBackColor = false;
            this.BtnIm.Click += new System.EventHandler(this.BtnIm_Click);
            this.BtnIm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnIm.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnIm.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // LblOptimization
            // 
            this.LblOptimization.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblOptimization.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblOptimization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblOptimization.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblOptimization.ForeColor = System.Drawing.Color.White;
            this.LblOptimization.Location = new System.Drawing.Point(0, 320);
            this.LblOptimization.Name = "LblOptimization";
            this.LblOptimization.Size = new System.Drawing.Size(200, 50);
            this.LblOptimization.TabIndex = 12;
            this.LblOptimization.Text = "配置管理";
            this.LblOptimization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblOptimization.Click += new System.EventHandler(this.Title_Click);
            this.LblOptimization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.LblOptimization.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.LblOptimization.MouseLeave += new System.EventHandler(this.LblColor_MouseLeave);
            // 
            // BtnProcCtrl
            // 
            this.BtnProcCtrl.BackColor = System.Drawing.Color.White;
            this.BtnProcCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProcCtrl.FlatAppearance.BorderSize = 0;
            this.BtnProcCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcCtrl.Location = new System.Drawing.Point(0, 290);
            this.BtnProcCtrl.Name = "BtnProcCtrl";
            this.BtnProcCtrl.Size = new System.Drawing.Size(200, 30);
            this.BtnProcCtrl.TabIndex = 13;
            this.BtnProcCtrl.TabStop = false;
            this.BtnProcCtrl.Text = "进程管控";
            this.BtnProcCtrl.UseVisualStyleBackColor = false;
            this.BtnProcCtrl.Click += new System.EventHandler(this.Title_Click);
            this.BtnProcCtrl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnProcCtrl.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnProcCtrl.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnPS
            // 
            this.BtnPS.BackColor = System.Drawing.Color.White;
            this.BtnPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPS.FlatAppearance.BorderSize = 0;
            this.BtnPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPS.Location = new System.Drawing.Point(0, 260);
            this.BtnPS.Name = "BtnPS";
            this.BtnPS.Size = new System.Drawing.Size(200, 30);
            this.BtnPS.TabIndex = 8;
            this.BtnPS.TabStop = false;
            this.BtnPS.Text = "PowerShell";
            this.BtnPS.UseVisualStyleBackColor = false;
            this.BtnPS.Click += new System.EventHandler(this.Title_Click);
            this.BtnPS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnPS.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnPS.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnCmd
            // 
            this.BtnCmd.BackColor = System.Drawing.Color.White;
            this.BtnCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCmd.FlatAppearance.BorderSize = 0;
            this.BtnCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCmd.Location = new System.Drawing.Point(0, 230);
            this.BtnCmd.Name = "BtnCmd";
            this.BtnCmd.Size = new System.Drawing.Size(200, 30);
            this.BtnCmd.TabIndex = 7;
            this.BtnCmd.TabStop = false;
            this.BtnCmd.Text = "命令提示符";
            this.BtnCmd.UseVisualStyleBackColor = false;
            this.BtnCmd.Click += new System.EventHandler(this.Title_Click);
            this.BtnCmd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnCmd.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnCmd.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnTaskMgr
            // 
            this.BtnTaskMgr.BackColor = System.Drawing.Color.White;
            this.BtnTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTaskMgr.FlatAppearance.BorderSize = 0;
            this.BtnTaskMgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaskMgr.Location = new System.Drawing.Point(0, 200);
            this.BtnTaskMgr.Name = "BtnTaskMgr";
            this.BtnTaskMgr.Size = new System.Drawing.Size(200, 30);
            this.BtnTaskMgr.TabIndex = 6;
            this.BtnTaskMgr.TabStop = false;
            this.BtnTaskMgr.Text = "任务管理器";
            this.BtnTaskMgr.UseVisualStyleBackColor = false;
            this.BtnTaskMgr.Click += new System.EventHandler(this.Title_Click);
            this.BtnTaskMgr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnTaskMgr.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnTaskMgr.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnRunTool
            // 
            this.BtnRunTool.BackColor = System.Drawing.Color.White;
            this.BtnRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRunTool.FlatAppearance.BorderSize = 0;
            this.BtnRunTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunTool.Location = new System.Drawing.Point(0, 170);
            this.BtnRunTool.Name = "BtnRunTool";
            this.BtnRunTool.Size = new System.Drawing.Size(200, 30);
            this.BtnRunTool.TabIndex = 5;
            this.BtnRunTool.TabStop = false;
            this.BtnRunTool.Text = "运行工具";
            this.BtnRunTool.UseVisualStyleBackColor = false;
            this.BtnRunTool.Click += new System.EventHandler(this.Title_Click);
            this.BtnRunTool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnRunTool.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnRunTool.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnCtrlPnl
            // 
            this.BtnCtrlPnl.BackColor = System.Drawing.Color.White;
            this.BtnCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCtrlPnl.FlatAppearance.BorderSize = 0;
            this.BtnCtrlPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCtrlPnl.Location = new System.Drawing.Point(0, 140);
            this.BtnCtrlPnl.Name = "BtnCtrlPnl";
            this.BtnCtrlPnl.Size = new System.Drawing.Size(200, 30);
            this.BtnCtrlPnl.TabIndex = 4;
            this.BtnCtrlPnl.TabStop = false;
            this.BtnCtrlPnl.Text = "控制面板";
            this.BtnCtrlPnl.UseVisualStyleBackColor = false;
            this.BtnCtrlPnl.Click += new System.EventHandler(this.Title_Click);
            this.BtnCtrlPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnCtrlPnl.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnCtrlPnl.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnRegustry
            // 
            this.BtnRegustry.BackColor = System.Drawing.Color.White;
            this.BtnRegustry.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegustry.FlatAppearance.BorderSize = 0;
            this.BtnRegustry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegustry.Location = new System.Drawing.Point(0, 110);
            this.BtnRegustry.Name = "BtnRegustry";
            this.BtnRegustry.Size = new System.Drawing.Size(200, 30);
            this.BtnRegustry.TabIndex = 2;
            this.BtnRegustry.TabStop = false;
            this.BtnRegustry.Text = "注册表";
            this.BtnRegustry.UseVisualStyleBackColor = false;
            this.BtnRegustry.Click += new System.EventHandler(this.Title_Click);
            this.BtnRegustry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnRegustry.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnRegustry.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnConsole
            // 
            this.BtnConsole.BackColor = System.Drawing.Color.White;
            this.BtnConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsole.FlatAppearance.BorderSize = 0;
            this.BtnConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsole.Location = new System.Drawing.Point(0, 80);
            this.BtnConsole.Name = "BtnConsole";
            this.BtnConsole.Size = new System.Drawing.Size(200, 30);
            this.BtnConsole.TabIndex = 1;
            this.BtnConsole.TabStop = false;
            this.BtnConsole.Text = "控制台";
            this.BtnConsole.UseVisualStyleBackColor = false;
            this.BtnConsole.Click += new System.EventHandler(this.Title_Click);
            this.BtnConsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnConsole.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnConsole.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // BtnSys
            // 
            this.BtnSys.BackColor = System.Drawing.Color.White;
            this.BtnSys.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSys.FlatAppearance.BorderSize = 0;
            this.BtnSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSys.Location = new System.Drawing.Point(0, 50);
            this.BtnSys.Name = "BtnSys";
            this.BtnSys.Size = new System.Drawing.Size(200, 30);
            this.BtnSys.TabIndex = 3;
            this.BtnSys.TabStop = false;
            this.BtnSys.Text = "系统盘管控";
            this.BtnSys.UseVisualStyleBackColor = false;
            this.BtnSys.Click += new System.EventHandler(this.Title_Click);
            this.BtnSys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.BtnSys.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.BtnSys.MouseLeave += new System.EventHandler(this.BtnColor_MouseLeave);
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblStatus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(0, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(200, 50);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "系统状态";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblStatus.Click += new System.EventHandler(this.Title_Click);
            this.LblStatus.DoubleClick += new System.EventHandler(this.LblStatus_DoubleClick);
            this.LblStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColor_MouseDown);
            this.LblStatus.MouseEnter += new System.EventHandler(this.BtnColor_MouseEnter);
            this.LblStatus.MouseLeave += new System.EventHandler(this.LblColor_MouseLeave);
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
            this.TabCtrlAdm.Controls.Add(this.PageProcCtrl);
            this.TabCtrlAdm.Controls.Add(this.PageOptimization);
            this.TabCtrlAdm.Controls.Add(this.PageInstruction);
            this.TabCtrlAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCtrlAdm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabCtrlAdm.ItemSize = new System.Drawing.Size(10, 10);
            this.TabCtrlAdm.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAdm.Name = "TabCtrlAdm";
            this.TabCtrlAdm.SelectedIndex = 0;
            this.TabCtrlAdm.Size = new System.Drawing.Size(781, 522);
            this.TabCtrlAdm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabCtrlAdm.TabIndex = 5;
            this.TabCtrlAdm.TabStop = false;
            // 
            // PageAbout
            // 
            this.PageAbout.Controls.Add(this.LblCreater3);
            this.PageAbout.Controls.Add(this.LblCreater2);
            this.PageAbout.Controls.Add(this.LblCreater1);
            this.PageAbout.Controls.Add(this.LblCreacters);
            this.PageAbout.Controls.Add(this.LblTitleInAbout2);
            this.PageAbout.Controls.Add(this.LblAbout);
            this.PageAbout.Controls.Add(this.RTxtBoxAbout);
            this.PageAbout.Controls.Add(this.LblTitleInAbout);
            this.PageAbout.Controls.Add(this.LblIconInAbout);
            this.PageAbout.Location = new System.Drawing.Point(4, 14);
            this.PageAbout.Name = "PageAbout";
            this.PageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.PageAbout.Size = new System.Drawing.Size(773, 504);
            this.PageAbout.TabIndex = 2;
            this.PageAbout.Text = "关于";
            this.PageAbout.UseVisualStyleBackColor = true;
            // 
            // LblCreater3
            // 
            this.LblCreater3.AutoSize = true;
            this.LblCreater3.Location = new System.Drawing.Point(373, 413);
            this.LblCreater3.Name = "LblCreater3";
            this.LblCreater3.Size = new System.Drawing.Size(98, 22);
            this.LblCreater3.TabIndex = 17;
            this.LblCreater3.TabStop = true;
            this.LblCreater3.Text = "ChrisYoung96";
            this.LblCreater3.UseCompatibleTextRendering = true;
            this.LblCreater3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreater3_LinkClicked);
            // 
            // LblCreater2
            // 
            this.LblCreater2.AutoSize = true;
            this.LblCreater2.Location = new System.Drawing.Point(331, 413);
            this.LblCreater2.Name = "LblCreater2";
            this.LblCreater2.Size = new System.Drawing.Size(36, 22);
            this.LblCreater2.TabIndex = 16;
            this.LblCreater2.TabStop = true;
            this.LblCreater2.Text = "HLYS";
            this.LblCreater2.UseCompatibleTextRendering = true;
            this.LblCreater2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreater2_LinkClicked);
            // 
            // LblCreater1
            // 
            this.LblCreater1.AutoSize = true;
            this.LblCreater1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LblCreater1.Location = new System.Drawing.Point(235, 413);
            this.LblCreater1.Name = "LblCreater1";
            this.LblCreater1.Size = new System.Drawing.Size(90, 22);
            this.LblCreater1.TabIndex = 15;
            this.LblCreater1.TabStop = true;
            this.LblCreater1.Text = "MFunction96";
            this.LblCreater1.UseCompatibleTextRendering = true;
            this.LblCreater1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreater1_LinkClicked);
            // 
            // LblCreacters
            // 
            this.LblCreacters.AutoSize = true;
            this.LblCreacters.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCreacters.Location = new System.Drawing.Point(235, 355);
            this.LblCreacters.Name = "LblCreacters";
            this.LblCreacters.Size = new System.Drawing.Size(134, 47);
            this.LblCreacters.TabIndex = 13;
            this.LblCreacters.Text = "项目成员";
            this.LblCreacters.UseCompatibleTextRendering = true;
            // 
            // LblTitleInAbout2
            // 
            this.LblTitleInAbout2.AutoSize = true;
            this.LblTitleInAbout2.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleInAbout2.Location = new System.Drawing.Point(366, 355);
            this.LblTitleInAbout2.Name = "LblTitleInAbout2";
            this.LblTitleInAbout2.Size = new System.Drawing.Size(103, 46);
            this.LblTitleInAbout2.TabIndex = 12;
            this.LblTitleInAbout2.Text = "Vexease";
            // 
            // LblAbout
            // 
            this.LblAbout.AutoSize = true;
            this.LblAbout.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAbout.Location = new System.Drawing.Point(295, 155);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(72, 47);
            this.LblAbout.TabIndex = 11;
            this.LblAbout.Text = "关于";
            this.LblAbout.UseCompatibleTextRendering = true;
            // 
            // RTxtBoxAbout
            // 
            this.RTxtBoxAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxAbout.Location = new System.Drawing.Point(66, 204);
            this.RTxtBoxAbout.Name = "RTxtBoxAbout";
            this.RTxtBoxAbout.ReadOnly = true;
            this.RTxtBoxAbout.Size = new System.Drawing.Size(643, 151);
            this.RTxtBoxAbout.TabIndex = 10;
            this.RTxtBoxAbout.Text = resources.GetString("RTxtBoxAbout.Text");
            // 
            // LblTitleInAbout
            // 
            this.LblTitleInAbout.AutoSize = true;
            this.LblTitleInAbout.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleInAbout.Location = new System.Drawing.Point(366, 155);
            this.LblTitleInAbout.Name = "LblTitleInAbout";
            this.LblTitleInAbout.Size = new System.Drawing.Size(103, 46);
            this.LblTitleInAbout.TabIndex = 9;
            this.LblTitleInAbout.Text = "Vexease";
            // 
            // LblIconInAbout
            // 
            this.LblIconInAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblIconInAbout.Image = global::Vexease.Properties.Resources.QQ图片20170928165258;
            this.LblIconInAbout.Location = new System.Drawing.Point(310, 31);
            this.LblIconInAbout.Name = "LblIconInAbout";
            this.LblIconInAbout.Size = new System.Drawing.Size(127, 124);
            this.LblIconInAbout.TabIndex = 2;
            // 
            // PageConsole
            // 
            this.PageConsole.Controls.Add(this.RTxtBoxConsole);
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
            // RTxtBoxConsole
            // 
            this.RTxtBoxConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxConsole.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxConsole.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxConsole.Location = new System.Drawing.Point(3, 143);
            this.RTxtBoxConsole.Name = "RTxtBoxConsole";
            this.RTxtBoxConsole.Size = new System.Drawing.Size(767, 308);
            this.RTxtBoxConsole.TabIndex = 17;
            this.RTxtBoxConsole.Text = "控制台\n\t即微软管理控制台Microsoft Management Console (MMC) 集成了用来管理网络、计算机、服务及其他系统组件的管理工具。是Win" +
    "dows管理控制程序，是显示管理插件的控制面板，例如驱动器管理。\n\t禁用时，则不可以创建、保存或打开管理工具（称为 MMC 控制台）来管理硬件、软件和 Wind" +
    "ows 系统的网络组件。";
            // 
            // PnlConsoleBtns
            // 
            this.PnlConsoleBtns.Controls.Add(this.BtnConsoleRe);
            this.PnlConsoleBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlConsoleBtns.Location = new System.Drawing.Point(3, 451);
            this.PnlConsoleBtns.Name = "PnlConsoleBtns";
            this.PnlConsoleBtns.Size = new System.Drawing.Size(767, 50);
            this.PnlConsoleBtns.TabIndex = 16;
            // 
            // BtnConsoleRe
            // 
            this.BtnConsoleRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            listViewItem18.Checked = true;
            listViewItem18.StateImageIndex = 1;
            this.LvConsole.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem17,
            listViewItem18});
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
            this.LblConsole.Click += new System.EventHandler(this.Label_Click);
            // 
            // BtnConsoleYorN
            // 
            this.BtnConsoleYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnConsoleYorN.Checked = false;
            this.BtnConsoleYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnConsoleYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsoleYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsoleYorN.Enabled = false;
            this.BtnConsoleYorN.Location = new System.Drawing.Point(717, 0);
            this.BtnConsoleYorN.Name = "BtnConsoleYorN";
            this.BtnConsoleYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnConsoleYorN.TabIndex = 13;
            this.BtnConsoleYorN.TabStop = false;
            this.BtnConsoleYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnConsoleYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorN_MouseUp);
            // 
            // PageRegustry
            // 
            this.PageRegustry.Controls.Add(this.RTxtBoxRegustry);
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
            // RTxtBoxRegustry
            // 
            this.RTxtBoxRegustry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxRegustry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxRegustry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxRegustry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxRegustry.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxRegustry.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxRegustry.Name = "RTxtBoxRegustry";
            this.RTxtBoxRegustry.ReadOnly = true;
            this.RTxtBoxRegustry.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxRegustry.TabIndex = 18;
            this.RTxtBoxRegustry.Text = "注册表（Registry，繁体中文版Windows操作系统称之为登录档）\n\t是Microsoft Windows中的一个重要的数据库，其中存放着各种参数，直接控制" +
    "着windows的启动、硬件驱动程序的装载以及一些windows应用程序的运行，从而在整个系统中起着核心作用。\n\t禁用时，则不能通过注册表设置向系统添加或删除程" +
    "序";
            // 
            // PnlRegustriyBtns
            // 
            this.PnlRegustriyBtns.Controls.Add(this.BtnRegustriyRe);
            this.PnlRegustriyBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlRegustriyBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlRegustriyBtns.Name = "PnlRegustriyBtns";
            this.PnlRegustriyBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlRegustriyBtns.TabIndex = 17;
            // 
            // BtnRegustriyRe
            // 
            this.BtnRegustriyRe.BackColor = System.Drawing.Color.White;
            this.BtnRegustriyRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegustriyRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegustriyRe.Location = new System.Drawing.Point(683, 0);
            this.BtnRegustriyRe.Name = "BtnRegustriyRe";
            this.BtnRegustriyRe.Size = new System.Drawing.Size(90, 50);
            this.BtnRegustriyRe.TabIndex = 19;
            this.BtnRegustriyRe.Text = "刷新";
            this.BtnRegustriyRe.UseVisualStyleBackColor = false;
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
            listViewItem20.Checked = true;
            listViewItem20.StateImageIndex = 1;
            this.LvRegustry.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19,
            listViewItem20});
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
            this.LblRegustriy.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnRegustriyYorN.TabStop = false;
            this.BtnRegustriyYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnRegustriyYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PagePlanningTask
            // 
            this.PagePlanningTask.Controls.Add(this.RTxtBoxPlanningTask);
            this.PagePlanningTask.Controls.Add(this.PnlPlanningTaskBtns);
            this.PagePlanningTask.Controls.Add(this.LvSys);
            this.PagePlanningTask.Controls.Add(this.PnlPlanningTask);
            this.PagePlanningTask.Location = new System.Drawing.Point(4, 14);
            this.PagePlanningTask.Name = "PagePlanningTask";
            this.PagePlanningTask.Size = new System.Drawing.Size(773, 504);
            this.PagePlanningTask.TabIndex = 4;
            this.PagePlanningTask.Text = "计划任务状态";
            this.PagePlanningTask.UseVisualStyleBackColor = true;
            // 
            // RTxtBoxPlanningTask
            // 
            this.RTxtBoxPlanningTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxPlanningTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxPlanningTask.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxPlanningTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxPlanningTask.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxPlanningTask.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxPlanningTask.Name = "RTxtBoxPlanningTask";
            this.RTxtBoxPlanningTask.ReadOnly = true;
            this.RTxtBoxPlanningTask.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxPlanningTask.TabIndex = 19;
            this.RTxtBoxPlanningTask.Text = "系统盘\n\t即C盘。";
            // 
            // PnlPlanningTaskBtns
            // 
            this.PnlPlanningTaskBtns.Controls.Add(this.BtnPlanningTaskRe);
            this.PnlPlanningTaskBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPlanningTaskBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlPlanningTaskBtns.Name = "PnlPlanningTaskBtns";
            this.PnlPlanningTaskBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlPlanningTaskBtns.TabIndex = 18;
            // 
            // BtnPlanningTaskRe
            // 
            this.BtnPlanningTaskRe.BackColor = System.Drawing.Color.White;
            this.BtnPlanningTaskRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPlanningTaskRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlanningTaskRe.Location = new System.Drawing.Point(683, 0);
            this.BtnPlanningTaskRe.Name = "BtnPlanningTaskRe";
            this.BtnPlanningTaskRe.Size = new System.Drawing.Size(90, 50);
            this.BtnPlanningTaskRe.TabIndex = 19;
            this.BtnPlanningTaskRe.Text = "刷新";
            this.BtnPlanningTaskRe.UseVisualStyleBackColor = false;
            // 
            // LvSys
            // 
            this.LvSys.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvSys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.LvSys.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvSys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem22.Checked = true;
            listViewItem22.StateImageIndex = 1;
            this.LvSys.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem21,
            listViewItem22});
            this.LvSys.Location = new System.Drawing.Point(0, 30);
            this.LvSys.Name = "LvSys";
            this.LvSys.ShowItemToolTips = true;
            this.LvSys.Size = new System.Drawing.Size(773, 110);
            this.LvSys.TabIndex = 11;
            this.LvSys.TabStop = false;
            this.LvSys.UseCompatibleStateImageBehavior = false;
            this.LvSys.View = System.Windows.Forms.View.Details;
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
            this.PnlPlanningTask.Controls.Add(this.LblSys);
            this.PnlPlanningTask.Controls.Add(this.BtnSysYorN);
            this.PnlPlanningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPlanningTask.Location = new System.Drawing.Point(0, 0);
            this.PnlPlanningTask.Name = "PnlPlanningTask";
            this.PnlPlanningTask.Size = new System.Drawing.Size(773, 30);
            this.PnlPlanningTask.TabIndex = 16;
            // 
            // LblSys
            // 
            this.LblSys.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblSys.Location = new System.Drawing.Point(0, 0);
            this.LblSys.Name = "LblSys";
            this.LblSys.Size = new System.Drawing.Size(600, 30);
            this.LblSys.TabIndex = 15;
            this.LblSys.Text = "系统盘状态————————";
            this.LblSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblSys.Click += new System.EventHandler(this.Label_Click);
            // 
            // BtnSysYorN
            // 
            this.BtnSysYorN.BackColor = System.Drawing.Color.Transparent;
            this.BtnSysYorN.Checked = false;
            this.BtnSysYorN.CheckStyleX = Vexease.Views.CheckStyle.Style1;
            this.BtnSysYorN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSysYorN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSysYorN.Location = new System.Drawing.Point(723, 0);
            this.BtnSysYorN.Name = "BtnSysYorN";
            this.BtnSysYorN.Size = new System.Drawing.Size(50, 30);
            this.BtnSysYorN.TabIndex = 13;
            this.BtnSysYorN.TabStop = false;
            this.BtnSysYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnSysYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PageCtrlPnl
            // 
            this.PageCtrlPnl.Controls.Add(this.RTxtBoxCtrlPnl);
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
            // RTxtBoxCtrlPnl
            // 
            this.RTxtBoxCtrlPnl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxCtrlPnl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxCtrlPnl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxCtrlPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxCtrlPnl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxCtrlPnl.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxCtrlPnl.Name = "RTxtBoxCtrlPnl";
            this.RTxtBoxCtrlPnl.ReadOnly = true;
            this.RTxtBoxCtrlPnl.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxCtrlPnl.TabIndex = 20;
            this.RTxtBoxCtrlPnl.Text = "控制面板\n\t（control panel）是Windows图形用户界面一部分，可通过开始菜单访问。它允许用户查看并操作基本的系统设置，比如添加/删除软件，控制用户" +
    "帐户，更改辅助功能选项。\n\t禁用时，无法打开控制面板，更无法在“添加/删除程序”中添加修改。";
            // 
            // PnlCtrlPnlBtns
            // 
            this.PnlCtrlPnlBtns.Controls.Add(this.BtnCtrlPnlRe);
            this.PnlCtrlPnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCtrlPnlBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlCtrlPnlBtns.Name = "PnlCtrlPnlBtns";
            this.PnlCtrlPnlBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlCtrlPnlBtns.TabIndex = 19;
            // 
            // BtnCtrlPnlRe
            // 
            this.BtnCtrlPnlRe.BackColor = System.Drawing.Color.White;
            this.BtnCtrlPnlRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCtrlPnlRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCtrlPnlRe.Location = new System.Drawing.Point(683, 0);
            this.BtnCtrlPnlRe.Name = "BtnCtrlPnlRe";
            this.BtnCtrlPnlRe.Size = new System.Drawing.Size(90, 50);
            this.BtnCtrlPnlRe.TabIndex = 19;
            this.BtnCtrlPnlRe.Text = "刷新";
            this.BtnCtrlPnlRe.UseVisualStyleBackColor = false;
            // 
            // LvCtrlPnl
            // 
            this.LvCtrlPnl.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCtrlPnl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.LvCtrlPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCtrlPnl.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem24.Checked = true;
            listViewItem24.StateImageIndex = 1;
            this.LvCtrlPnl.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem23,
            listViewItem24});
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
            this.LblCtrlPnl.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnCtrlPnlYorN.TabStop = false;
            this.BtnCtrlPnlYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnCtrlPnlYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PageRunTool
            // 
            this.PageRunTool.Controls.Add(this.RTxtBoxRunTool);
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
            // RTxtBoxRunTool
            // 
            this.RTxtBoxRunTool.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxRunTool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxRunTool.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxRunTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxRunTool.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxRunTool.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxRunTool.Name = "RTxtBoxRunTool";
            this.RTxtBoxRunTool.ReadOnly = true;
            this.RTxtBoxRunTool.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxRunTool.TabIndex = 21;
            this.RTxtBoxRunTool.Text = "运行工具\n\t是Windows的必要组成部分，可以简单理解为一个应用程序快速调用的组件。通过“运行”窗口，可以调用Windows中任何应用程序甚至DOS命令。\n\t禁" +
    "用时，无法通过运行工具打开安装或卸载程序。";
            // 
            // PnlRunToolBtns
            // 
            this.PnlRunToolBtns.Controls.Add(this.BtnRunToolRe);
            this.PnlRunToolBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlRunToolBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlRunToolBtns.Name = "PnlRunToolBtns";
            this.PnlRunToolBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlRunToolBtns.TabIndex = 20;
            // 
            // BtnRunToolRe
            // 
            this.BtnRunToolRe.BackColor = System.Drawing.Color.White;
            this.BtnRunToolRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRunToolRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRunToolRe.Location = new System.Drawing.Point(683, 0);
            this.BtnRunToolRe.Name = "BtnRunToolRe";
            this.BtnRunToolRe.Size = new System.Drawing.Size(90, 50);
            this.BtnRunToolRe.TabIndex = 19;
            this.BtnRunToolRe.Text = "刷新";
            this.BtnRunToolRe.UseVisualStyleBackColor = false;
            // 
            // LvRunTool
            // 
            this.LvRunTool.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvRunTool.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.LvRunTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvRunTool.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem26.Checked = true;
            listViewItem26.StateImageIndex = 1;
            this.LvRunTool.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem25,
            listViewItem26});
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
            this.LblRunTool.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnRunToolYorN.TabStop = false;
            this.BtnRunToolYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnRunToolYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PageTaskMgr
            // 
            this.PageTaskMgr.Controls.Add(this.RTxtBoxTaskMgr);
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
            // RTxtBoxTaskMgr
            // 
            this.RTxtBoxTaskMgr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxTaskMgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxTaskMgr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxTaskMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxTaskMgr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxTaskMgr.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxTaskMgr.Name = "RTxtBoxTaskMgr";
            this.RTxtBoxTaskMgr.ReadOnly = true;
            this.RTxtBoxTaskMgr.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxTaskMgr.TabIndex = 22;
            this.RTxtBoxTaskMgr.Text = "任务管理器\n\t提供了有关计算机性能的信息，并显示了计算机上所运行的程序和进程的详细信息；它的用户界面提供了进程、性能、应用历史记录、开机启动项列表、用户、详细信息" +
    "与服务等菜单项。\n\t禁用时，无法打开任务管理器，更无法通过任务管理器关闭指定应用进程。";
            // 
            // PnlTaskMgrBtns
            // 
            this.PnlTaskMgrBtns.Controls.Add(this.BtnTaskMgrRe);
            this.PnlTaskMgrBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlTaskMgrBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlTaskMgrBtns.Name = "PnlTaskMgrBtns";
            this.PnlTaskMgrBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlTaskMgrBtns.TabIndex = 21;
            // 
            // BtnTaskMgrRe
            // 
            this.BtnTaskMgrRe.BackColor = System.Drawing.Color.White;
            this.BtnTaskMgrRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnTaskMgrRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTaskMgrRe.Location = new System.Drawing.Point(683, 0);
            this.BtnTaskMgrRe.Name = "BtnTaskMgrRe";
            this.BtnTaskMgrRe.Size = new System.Drawing.Size(90, 50);
            this.BtnTaskMgrRe.TabIndex = 19;
            this.BtnTaskMgrRe.Text = "刷新";
            this.BtnTaskMgrRe.UseVisualStyleBackColor = false;
            // 
            // LvTaskMgr
            // 
            this.LvTaskMgr.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvTaskMgr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.LvTaskMgr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvTaskMgr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem28.Checked = true;
            listViewItem28.StateImageIndex = 1;
            this.LvTaskMgr.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem27,
            listViewItem28});
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
            this.LblTaskMgr.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnTaskMgrYorN.TabStop = false;
            this.BtnTaskMgrYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnTaskMgrYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PageCmd
            // 
            this.PageCmd.Controls.Add(this.RTxtBoxCMD);
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
            // RTxtBoxCMD
            // 
            this.RTxtBoxCMD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxCMD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxCMD.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxCMD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxCMD.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxCMD.Name = "RTxtBoxCMD";
            this.RTxtBoxCMD.ReadOnly = true;
            this.RTxtBoxCMD.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxCMD.TabIndex = 23;
            this.RTxtBoxCMD.Text = "命令提示符\n\t是在操作系统中，提示进行命令输入的一种工作提示符。在不同的操作系统环境下，命令提示符各不相同。在windows环境下，命令行程序为cmd.exe，是" +
    "一个32位的命令行程序，微软Windows系统基于Windows上的命令解释程序，类似于微软的DOS操作系统。\n\t禁用时，无法使用命令提示符打开应用程序。";
            // 
            // PnlCmdBtns
            // 
            this.PnlCmdBtns.Controls.Add(this.BtnCmdRe);
            this.PnlCmdBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCmdBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlCmdBtns.Name = "PnlCmdBtns";
            this.PnlCmdBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlCmdBtns.TabIndex = 22;
            // 
            // BtnCmdRe
            // 
            this.BtnCmdRe.BackColor = System.Drawing.Color.White;
            this.BtnCmdRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCmdRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCmdRe.Location = new System.Drawing.Point(683, 0);
            this.BtnCmdRe.Name = "BtnCmdRe";
            this.BtnCmdRe.Size = new System.Drawing.Size(90, 50);
            this.BtnCmdRe.TabIndex = 19;
            this.BtnCmdRe.Text = "刷新";
            this.BtnCmdRe.UseVisualStyleBackColor = false;
            // 
            // LvCmd
            // 
            this.LvCmd.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvCmd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.LvCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvCmd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem30.Checked = true;
            listViewItem30.StateImageIndex = 1;
            this.LvCmd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem29,
            listViewItem30});
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
            this.LblCmd.Text = "命令提示符状态————————";
            this.LblCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCmd.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnCmdYorN.TabStop = false;
            this.BtnCmdYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnCmdYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PagePS
            // 
            this.PagePS.Controls.Add(this.RTxtBoxPS);
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
            // RTxtBoxPS
            // 
            this.RTxtBoxPS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxPS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxPS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxPS.Location = new System.Drawing.Point(0, 140);
            this.RTxtBoxPS.Name = "RTxtBoxPS";
            this.RTxtBoxPS.ReadOnly = true;
            this.RTxtBoxPS.Size = new System.Drawing.Size(773, 314);
            this.RTxtBoxPS.TabIndex = 24;
            this.RTxtBoxPS.Text = "PowerShell\n\t是运行在windows机器上实现系统和应用程序管理自动化的命令行脚本环境。\n\t禁用时，无法通过PowerShell中命令行进行计算机更改。" +
    "";
            // 
            // PnlPsBtns
            // 
            this.PnlPsBtns.Controls.Add(this.BtnPSRe);
            this.PnlPsBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPsBtns.Location = new System.Drawing.Point(0, 454);
            this.PnlPsBtns.Name = "PnlPsBtns";
            this.PnlPsBtns.Size = new System.Drawing.Size(773, 50);
            this.PnlPsBtns.TabIndex = 23;
            // 
            // BtnPSRe
            // 
            this.BtnPSRe.BackColor = System.Drawing.Color.White;
            this.BtnPSRe.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPSRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPSRe.Location = new System.Drawing.Point(683, 0);
            this.BtnPSRe.Name = "BtnPSRe";
            this.BtnPSRe.Size = new System.Drawing.Size(90, 50);
            this.BtnPSRe.TabIndex = 19;
            this.BtnPSRe.Text = "刷新";
            this.BtnPSRe.UseVisualStyleBackColor = false;
            // 
            // LvPS
            // 
            this.LvPS.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.LvPS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20});
            this.LvPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvPS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem32.Checked = true;
            listViewItem32.StateImageIndex = 1;
            this.LvPS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32});
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
            this.LblPS.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnPSYorN.TabStop = false;
            this.BtnPSYorN.Load += new System.EventHandler(this.BtnYorNStatus_Load);
            this.BtnPSYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorNStatus_MouseUp);
            // 
            // PageProcCtrl
            // 
            this.PageProcCtrl.Controls.Add(this.RTxtBoxProcCtrl);
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
            // RTxtBoxProcCtrl
            // 
            this.RTxtBoxProcCtrl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxProcCtrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxProcCtrl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxProcCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTxtBoxProcCtrl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RTxtBoxProcCtrl.Location = new System.Drawing.Point(0, 287);
            this.RTxtBoxProcCtrl.Name = "RTxtBoxProcCtrl";
            this.RTxtBoxProcCtrl.ReadOnly = true;
            this.RTxtBoxProcCtrl.Size = new System.Drawing.Size(773, 217);
            this.RTxtBoxProcCtrl.TabIndex = 25;
            this.RTxtBoxProcCtrl.Text = "黑名单\n\t不能进行系统访问且无法安装或运行的名单。\n白名单\n\t与“黑名单”相对应。值得信任允许访问或者允许通过验证的名单。\n黑名单（名称）\n\t即通过增删程序名称的" +
    "方式更改黑名单。\n白名单（名称）\n\t即通过增删程序名称的方式更改白名单。\n黑白名单（路径）\n\t即通过增删文件路径（Path）的方式更改黑白名单。";
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
            this.BtnListPathYorN.TabStop = false;
            this.BtnListPathYorN.Load += new System.EventHandler(this.BtnYorN_Load);
            this.BtnListPathYorN.Click += new System.EventHandler(this.BtnYorN_Click);
            this.BtnListPathYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorN_MouseUp);
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
            this.BtnWListYorN.TabStop = false;
            this.BtnWListYorN.Load += new System.EventHandler(this.BtnYorN_Load);
            this.BtnWListYorN.Click += new System.EventHandler(this.BtnYorN_Click);
            this.BtnWListYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorN_MouseUp);
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
            // LblWListTN
            // 
            this.LblWListTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblWListTN.Location = new System.Drawing.Point(0, 0);
            this.LblWListTN.Name = "LblWListTN";
            this.LblWListTN.Size = new System.Drawing.Size(600, 30);
            this.LblWListTN.TabIndex = 0;
            this.LblWListTN.Text = "白名单（名称）>>";
            this.LblWListTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblWListTN.Click += new System.EventHandler(this.Label_Click);
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
            this.LvBListN.Location = new System.Drawing.Point(0, 0);
            this.LvBListN.Name = "LvBListN";
            this.LvBListN.Size = new System.Drawing.Size(773, 95);
            this.LvBListN.TabIndex = 18;
            this.LvBListN.UseCompatibleStateImageBehavior = false;
            this.LvBListN.View = System.Windows.Forms.View.List;
            this.LvBListN.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.LvBListN_DrawItem);
            this.LvBListN.SelectedIndexChanged += new System.EventHandler(this.LvBListN_SelectedIndexChanged);
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
            this.LblBListTitleN.Click += new System.EventHandler(this.Label_Click);
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
            this.BtnBListYorN.TabStop = false;
            this.BtnBListYorN.Load += new System.EventHandler(this.BtnYorN_Load);
            this.BtnBListYorN.Click += new System.EventHandler(this.BtnYorN_Click);
            this.BtnBListYorN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnYorN_MouseUp);
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
            // PageInstruction
            // 
            this.PageInstruction.Controls.Add(this.LblInstruction);
            this.PageInstruction.Controls.Add(this.LblTitleInInstruction);
            this.PageInstruction.Controls.Add(this.RTxtBoxBrief);
            this.PageInstruction.Controls.Add(this.LblIconInInstruction);
            this.PageInstruction.Location = new System.Drawing.Point(4, 14);
            this.PageInstruction.Name = "PageInstruction";
            this.PageInstruction.Size = new System.Drawing.Size(773, 504);
            this.PageInstruction.TabIndex = 11;
            this.PageInstruction.Text = "说明";
            this.PageInstruction.UseVisualStyleBackColor = true;
            // 
            // LblInstruction
            // 
            this.LblInstruction.AutoSize = true;
            this.LblInstruction.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblInstruction.Location = new System.Drawing.Point(53, 175);
            this.LblInstruction.Name = "LblInstruction";
            this.LblInstruction.Size = new System.Drawing.Size(98, 50);
            this.LblInstruction.TabIndex = 9;
            this.LblInstruction.Text = "说明";
            // 
            // LblTitleInInstruction
            // 
            this.LblTitleInInstruction.AutoSize = true;
            this.LblTitleInInstruction.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleInInstruction.Location = new System.Drawing.Point(48, 139);
            this.LblTitleInInstruction.Name = "LblTitleInInstruction";
            this.LblTitleInInstruction.Size = new System.Drawing.Size(103, 46);
            this.LblTitleInInstruction.TabIndex = 8;
            this.LblTitleInInstruction.Text = "Vexease";
            // 
            // RTxtBoxBrief
            // 
            this.RTxtBoxBrief.AcceptsTab = true;
            this.RTxtBoxBrief.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTxtBoxBrief.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxBrief.BulletIndent = 2;
            this.RTxtBoxBrief.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTxtBoxBrief.Location = new System.Drawing.Point(192, 13);
            this.RTxtBoxBrief.Name = "RTxtBoxBrief";
            this.RTxtBoxBrief.ReadOnly = true;
            this.RTxtBoxBrief.Size = new System.Drawing.Size(541, 452);
            this.RTxtBoxBrief.TabIndex = 6;
            this.RTxtBoxBrief.Text = resources.GetString("RTxtBoxBrief.Text");
            // 
            // LblIconInInstruction
            // 
            this.LblIconInInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblIconInInstruction.Image = global::Vexease.Properties.Resources.QQ图片20170928165258;
            this.LblIconInInstruction.Location = new System.Drawing.Point(35, 13);
            this.LblIconInInstruction.Name = "LblIconInInstruction";
            this.LblIconInInstruction.Size = new System.Drawing.Size(127, 124);
            this.LblIconInInstruction.TabIndex = 1;
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.PageInstruction.ResumeLayout(false);
            this.PageInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TabPage PageConsole;
        private TabPage PageOptimization;
        private Button BtnPS;
        private Button BtnCmd;
        private Button BtnTaskMgr;
        private Button BtnRunTool;
        private Button BtnCtrlPnl;
        private Button BtnSys;
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
        private ListView LvSys;
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
        private Panel PnlListTP;
        private BtnYorN BtnListPathYorN;
        private Button BtnListSetP;
        private Label LblListTP;
        private Panel PnlConsole;
        private Label LblConsole;
        private BtnYorN BtnConsoleYorN;
        private Panel PnlREgustriy;
        private Label LblRegustriy;
        private BtnYorN BtnRegustriyYorN;
        private Panel PnlPlanningTask;
        private Label LblSys;
        private BtnYorN BtnSysYorN;
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
        private Button BtnConsoleRe;
        private Panel PnlRegustriyBtns;
        private Button BtnRegustriyRe;
        private Panel PnlPlanningTaskBtns;
        private Button BtnPlanningTaskRe;
        private Panel PnlCtrlPnlBtns;
        private Button BtnCtrlPnlRe;
        private Panel PnlRunToolBtns;
        private Button BtnRunToolRe;
        private Panel PnlTaskMgrBtns;
        private Button BtnTaskMgrRe;
        private Panel PnlCmdBtns;
        private Button BtnCmdRe;
        private Panel PnlPsBtns;
        private Button BtnPSRe;
        private Label LblIconInInstruction;
        private RichTextBox RTxtBoxBrief;
        private Label LblInstruction;
        private Label LblTitleInInstruction;
        private Label LblIconInAbout;
        private Label LblTitleInAbout;
        private RichTextBox RTxtBoxAbout;
        private Label LblCreacters;
        private Label LblTitleInAbout2;
        private Label LblAbout;
        private LinkLabel LblCreater1;
        private LinkLabel LblCreater2;
        private LinkLabel LblCreater3;
        private RichTextBox RTxtBoxConsole;
        private RichTextBox RTxtBoxRegustry;
        private RichTextBox RTxtBoxPlanningTask;
        private RichTextBox RTxtBoxCtrlPnl;
        private RichTextBox RTxtBoxRunTool;
        private RichTextBox RTxtBoxTaskMgr;
        private RichTextBox RTxtBoxCMD;
        private RichTextBox RTxtBoxPS;
        private RichTextBox RTxtBoxProcCtrl;
        private Button BtnEx;
        private Button BtnIm;
        private ToolStripMenuItem MenuPwdChange;
    }
}