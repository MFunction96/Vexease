using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
using  System.Collections.Generic;
using System.Diagnostics;

#pragma warning disable 1591 //缺少对公共可见类型或成员的xml注释

//神兽已死
//节哀
//

namespace Vexease.Views
{
    public partial class AdmForm : Form
    {
        private readonly Form _form;
        private  AdmFormCtrl Controller { get; }
        /// <inheritdoc />
        /// <summary>
        /// 管理员控制界面
        /// </summary>
        public AdmForm(Form form)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            TabSet();
            _form = form;
            Controller = new AdmFormCtrl();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdmForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
                                                          //隐藏标签,改成设置Itemsize为（1,1）了
                                                          /*TabCtrlAdm.Region = new Region(new RectangleF(PageCtrlPnl.Left,
                                                            PageCtrlPnl.Top, PageCtrlPnl.Width, PageCtrlPnl.Height));*/
            PnlWListTN.Width = PageAbout.Width - 100;
            foreach (var pair in Controller.LvDictionary)
            {
                 var value = pair.Value;
                var c = Controls.Find(value, true);
                Controller.Colwidth2((ListView)c[0]);
            }
            /*
             * Controller.Colwidth2(LvCmd);
              Controller.Colwidth2(LvConsole);
              Controller.Colwidth2(LvCtrlPnl);
              Controller.Colwidth2(LvSys);
              Controller.Colwidth2(LvPS);
              Controller.Colwidth2(LvRegustry);
              Controller.Colwidth2(LvRunTool);
              Controller.Colwidth2(LvTaskMgr);
             *
             */
        }


        /// <summary>
        /// 双击图标显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        /// <summary>
        /// 画边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplAdm_Panel1_Paint(object sender, PaintEventArgs e)
        {
            SplAdm.BorderStyle = BorderStyle.FixedSingle;
        }
        /// <summary>
        /// 关闭显示“关闭提示”
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
          {
              e.Cancel = true;
              // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                            
              Application.DoEvents();
            Controller.CloseTips(this);
              base.OnClosing(e);
          }

        /// <summary>
        /// Tab转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Title_Click(object sender, EventArgs e)
        {
            Controller.TabChange(TabCtrlAdm,sender);
        }

        /// <summary>
        /// 列表的收缩与扩展
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYorN_Click(object sender,EventArgs e)
        {
            if(!(sender is BtnYorN btnYorN))return;
           // var s = btnYorN.Name;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var n);
            
            Controller.ClickYorN(n);

            /*if (btnYorN == BtnBListYorN){
                Controller.CheckYorN(BtnBListYorN,"B_Clicked");
                Controller.ContracAndAmplifica(PnlBList, BtnBListYorN,"B_Clicked"); }
            if (btnYorN == BtnWListYorN) { Controller.CheckYorN(BtnWListYorN,"W_Clicked"); Controller.ContracAndAmplifica(PnlWList, BtnWListYorN,"W_Clicked"); }
            if (btnYorN == BtnListPathYorN) { Controller.CheckYorN(BtnListPathYorN, "P_Clicked"); }
*/

        }
        /// <summary>
        /// 名单收放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender,EventArgs e)
        {
            if (!(sender is Label lbl)) return;
            Controller.LblLvDictionary.TryGetValue(lbl.Name, out var n);
            var c = Controls.Find(n ?? throw new InvalidOperationException(), true);
            Controller.ContracAndAmplifica(c[0]);
            /*if (lbl == LblConsole) { Controller.ContracAndAmplifica(LvConsole); }
               if (lbl == LblRegustriy) { Controller.ContracAndAmplifica(LvRegustry); }
               if (lbl == LblSys) { Controller.ContracAndAmplifica(LvSys); }
               if (lbl == LblCtrlPnl) { Controller.ContracAndAmplifica(LvCtrlPnl); }
               if (lbl == LblRunTool) { Controller.ContracAndAmplifica(LvRunTool); }
               if (lbl == LblTaskMgr) { Controller.ContracAndAmplifica(LvTaskMgr); }
               if (lbl == LblCmd) { Controller.ContracAndAmplifica(LvCmd); }
               if (lbl == LblPS) { Controller.ContracAndAmplifica(LvPS); }
               if (lbl == LblBListTitleN) Controller.ContracAndAmplifica(PnlBList);
               if (lbl == LblWListTN) Controller.ContracAndAmplifica(PnlWList);*/
        }

        //
        //页面跳转
        //
        private void BtnBListSet_Click(object sender, EventArgs e)
        {
            var bListSetForm = new BandWListSetForm();
            bListSetForm.Show();
        }
        private void MenuSetIP_Click(object sender, EventArgs e)
        {
            var setIpForm = new SetIPForm {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };

            setIpForm.Show();
        }
        private void BtnIm_Click(object sender, EventArgs e)
        {
            var importform =new ImportForm();
            importform.Show();
        }
        private void MenuFileExport_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportForm();
            exportForm.Show();
        }
        private void BtnWListSet_Click(object sender, EventArgs e)
        {
            var wlistset = new WListSetForm();
            wlistset.Show();
        }
        private void BtnListSetP_Click(object sender, EventArgs e)
        {
            var listByPath = new ListByPathSetForm();
            listByPath.Show();
        }

        //
        //大标题的双击
        //
        private void LblStatus_DoubleClick(object sender, EventArgs e)
        {
           
            ViewMethod.DoubleCliclLbl(BtnConsole, BtnRegustry, BtnSys, BtnCtrlPnl, BtnRunTool, BtnTaskMgr, BtnCmd,  BtnPS,  BtnProcCtrl);
        }

        //
        //checkbutton-状态列表的收缩
        //
        private void BtnYorN_Load(object sender,EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            // var s = btnYorN.Name;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var n);
           
            Controller.LoadYorN(btnYorN,n);
            /*if (btnYorN == BtnBListYorN)
               {
               BtnYorNCtrl.CheckYorN(BtnBListYorN, "B_Load");
               ViewMethod.Contraction(BtnBListYorN, PnlBList, "B_Load"); }
               if (btnYorN == BtnWListYorN) {
               BtnYorNCtrl.CheckYorN(BtnWListYorN, "W_Load");
               ViewMethod.Contraction(BtnWListYorN, PnlWList, "W_Load"); }
               if (btnYorN == BtnListPathYorN)
               BtnYorNCtrl.CheckYorN(BtnListPathYorN,"P_Load");*/
        }

        private void BtnYorN_MouseUp(object sender,MouseEventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            // var s = btnYorN.Name;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var n);
           
            Controller.ClickYorN(n);
            /*if (btnYorN == BtnWListYorN)
               ViewMethod.ContracAndAmplifica(PnlWList,BtnWListYorN,"W_Clicked");
               if (btnYorN == BtnBListYorN)
               ViewMethod.ContracAndAmplifica(PnlBList, BtnBListYorN,"B_Clicked");
               if (btnYorN == BtnListPathYorN)
               BtnYorNCtrl.CheckYorN(BtnListPathYorN, "P_Load");*/
        }

        //
        //状态显示跟随开关改变
        //
        private void BtnYorNStatus_Load(object sender,EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            // var s = btnYorN.Name;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var n);
            
            Controller.LoadYorN(btnYorN,n);
            /* if (btnYorN == BtnRegustriyYorN) ViewMethod.StatusChange(btnYorN, LvRegustry, "Registry_Load");
             if (btnYorN == BtnConsoleYorN) ViewMethod.StatusChange(btnYorN, LvConsole,"Mmc_Load");
             if (btnYorN == BtnSysYorN) ViewMethod.StatusChange(BtnSysYorN, LvSys,"Sys_Load");
             if (btnYorN == BtnCtrlPnlYorN) ViewMethod.StatusChange(BtnCtrlPnlYorN, LvCtrlPnl,"CtrlPnl_Load");
             if (btnYorN == BtnRunToolYorN) ViewMethod.StatusChange(BtnRunToolYorN, LvRunTool,"RunTool_Load");
             if (btnYorN == BtnTaskMgrYorN) ViewMethod.StatusChange(BtnTaskMgrYorN, LvTaskMgr,"Taskmgr_Load");
             if (btnYorN == BtnCmdYorN) ViewMethod.StatusChange(BtnCmdYorN, LvCmd,"Cmd_Load");
             if (btnYorN == BtnPSYorN) ViewMethod.StatusChange(BtnPSYorN, LvPS,"PwrShell_Load");*/
        }

        private void BtnYorNStatus_MouseUp(object sender,MouseEventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            // var s = btnYorN.Name;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var n);
            Controller.ClickYorN(n);
            /* if (btnYorN == BtnRegustriyYorN) ViewMethod.StatusChange(btnYorN, LvRegustry, "Registry_Clicked");
              if (btnYorN == BtnConsoleYorN) ViewMethod.StatusChange(btnYorN, LvConsole, "Mmc_Clicked");
              if (btnYorN == BtnSysYorN) ViewMethod.StatusChange(BtnSysYorN, LvSys, "Sys_Clicked");
              if (btnYorN == BtnCtrlPnlYorN) ViewMethod.StatusChange(BtnCtrlPnlYorN, LvCtrlPnl, "CtrlPnl_Clicked");
              if (btnYorN == BtnRunToolYorN) ViewMethod.StatusChange(BtnRunToolYorN, LvRunTool, "RunTool_Clicked");
              if (btnYorN == BtnTaskMgrYorN) ViewMethod.StatusChange(BtnTaskMgrYorN, LvTaskMgr, "Taskmgr_Clicked");
              if (btnYorN == BtnCmdYorN) ViewMethod.StatusChange(BtnCmdYorN, LvCmd, "Cmd_Clicked");
              if (btnYorN == BtnPSYorN) ViewMethod.StatusChange(BtnPSYorN, LvPS, "PwrShell_Clicked");*/
        }


        //
        //项目成员名跳转github主页
        //
        private void LblCreater1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/MFunction96");
        }
             
        private void LblCreater2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/hlys");
        }

        private void LblCreater3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/ChrisYoung96");
        }

       //
       //左侧栏点击颜色变化
       //      
        private void BtnColor_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
           Controller.ColorChange(button,"D");
            /*
              if (button == BtnConsole) ViewMethod.ColorChange(BtnConsole, "D");
              if (button == BtnRegustry) ViewMethod.ColorChange(BtnRegustry, "D");
              if (button == BtnCmd) ViewMethod.ColorChange(BtnCmd, "D");
              if (button == BtnPS) ViewMethod.ColorChange(BtnPS, "D");
              if (button == BtnCtrlPnl) ViewMethod.ColorChange(BtnCtrlPnl, "D");
              if (button == BtnTaskMgr) ViewMethod.ColorChange(BtnTaskMgr, "D");
              if (button == BtnSys) ViewMethod.ColorChange(BtnSys, "D");
              if (button == BtnRunTool) ViewMethod.ColorChange(BtnRunTool, "D");
              if (button == BtnProcCtrl) ViewMethod.ColorChange(BtnProcCtrl, "D");
              if (button == BtnIm) ViewMethod.ColorChange(BtnIm, "D");
              if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "D");*/
        }

        private void LblColor_MouseLeave(object sender, EventArgs e)
        {

            var lbl = sender as Label;
            Controller.ColorChange(lbl,"L");
            /*if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "L");
               if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "L");*/
        }

        private void MenuPwdChange_Click(object sender, EventArgs e)
        {
            var pwdchangeform = new PwdChangeForm(this);
            pwdchangeform.Show();
        }

        private void BtnColor_MouseLeave(object sender, EventArgs e)
        {            
                Button button = sender as Button;
            Controller.ColorChange(button,"L");
            /*if (button == BtnConsole) ViewMethod.ColorChange(BtnConsole, "L");
                   if (button == BtnRegustry) ViewMethod.ColorChange(BtnRegustry, "L");
                   if (button == BtnCmd) ViewMethod.ColorChange(BtnCmd, "L");
                   if (button == BtnPS) ViewMethod.ColorChange(BtnPS, "L");
                   if (button == BtnCtrlPnl) ViewMethod.ColorChange(BtnCtrlPnl, "L");
                   if (button == BtnTaskMgr) ViewMethod.ColorChange(BtnTaskMgr, "L");
                   if (button == BtnSys) ViewMethod.ColorChange(BtnSys, "L");
                   if (button == BtnRunTool) ViewMethod.ColorChange(BtnRunTool, "L");
                   if (button == BtnProcCtrl) ViewMethod.ColorChange(BtnProcCtrl, "L");
                   if (button == BtnIm) ViewMethod.ColorChange(BtnIm, "L");
                   if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "L");*/
        }

        private void BtnColor_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Controller.ColorChange(button,"E");
            /*if (button == BtnConsole) ViewMethod.ColorChange(BtnConsole, "E");
            if (button == BtnRegustry) ViewMethod.ColorChange(BtnRegustry, "E");
            if (button == BtnCmd) ViewMethod.ColorChange(BtnCmd, "E");
            if (button == BtnPS) ViewMethod.ColorChange(BtnPS, "E");
            if (button == BtnCtrlPnl) ViewMethod.ColorChange(BtnCtrlPnl, "E");
            if (button == BtnTaskMgr) ViewMethod.ColorChange(BtnTaskMgr, "E");
            if (button == BtnSys) ViewMethod.ColorChange(BtnSys, "E");
            if (button == BtnRunTool) ViewMethod.ColorChange(BtnRunTool, "E");
            if (button == BtnProcCtrl) ViewMethod.ColorChange(BtnProcCtrl, "E");
            if (button == BtnIm) ViewMethod.ColorChange(BtnIm, "E");
            if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "E");*/
        }

        private void LblColor_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Controller.ColorChange(lbl,"D");
            /* if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "D");
              if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "D");*/
        }

        private void LblColor_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            Controller.ColorChange(lbl,"E");
            /* if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "E");
              if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "E");*/
        }

        private void PageAbout_Click(object sender, EventArgs e)
        {

        }

        private void LvPlanningTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }

}