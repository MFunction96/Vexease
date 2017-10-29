using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
// ┏┓　　　┏┓
// ┏┛┻━━━┛┻┓
// ┃　　　　　　　┃ 　
// ┃　　　━　　　┃
// ┃　┳┛　┗┳　┃
// ┃　　　　　　　┃
// ┃　　　┻　　　┃
// ┃　　　　　　　┃
// ┗━┓　　　┏━┛
//     ┃　　　┃ 神兽保佑　　　　　　　　
//     ┃　　　┃ 永无BUG！
//     ┃　　　┗━━━┓
//     ┃　　　　　　　┣┓
//     ┃　　　　　　　┏┛
//     ┗┓┓┏━┳┓┏┛
//       ┃┫┫　┃┫┫
//       ┗┻┛　┗┻┛
namespace Vexease.Views
{
    public partial class AdmForm : Form
    {
        public AdmForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            TabSet();
        }

        private void AdmForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
                                                          //隐藏标签,改成设置Itemsize为（1,1）了
                                                          /*TabCtrlAdm.Region = new Region(new RectangleF(PageCtrlPnl.Left,
                                                            PageCtrlPnl.Top, PageCtrlPnl.Width, PageCtrlPnl.Height));*/

            PnlWListTN.Width = PageAbout.Width - 100;
            // LvCmd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ViewMethod.Colwidth2(LvCmd);
            ViewMethod.Colwidth2(LvConsole);
            ViewMethod.Colwidth2(LvCtrlPnl);
            ViewMethod.Colwidth2(LvSys);
            ViewMethod.Colwidth2(LvPS);
            ViewMethod.Colwidth2(LvRegustry);
            ViewMethod.Colwidth2(LvRunTool);
            ViewMethod.Colwidth2(LvTaskMgr);
        }

       
         //
         //双击图标显示
         //
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        //
        //画边框
        //
        private void SplAdm_Panel1_Paint(object sender, PaintEventArgs e)
        {
            SplAdm.BorderStyle = BorderStyle.FixedSingle;
        }
        //
        //关闭显示“关闭提示”
        //
        protected override void OnClosing(CancelEventArgs e)
          {
              e.Cancel = true;
              // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                            
              Application.DoEvents();
            ViewMethod.CloseTips(this);
              base.OnClosing(e);
          }    
        //
        //Tab转换
        //
        private void LblStatus_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageAbout;

        private void LblOptimization_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageAbout;

        private void BtnConsole_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageConsole;

        private void BtnRegustry_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageRegustry;

        private void BtnPlanningTask_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PagePlanningTask;

        private void BtnCtrlPnl_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageCtrlPnl;

        private void BtnRunTool_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageRunTool;

        private void BtnTaskMgr_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageTaskMgr;

        private void BtnCmd_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageCmd;

        private void BtnPS_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PagePS;

        private void Btnyouhua_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageOptimization;

        private void PnlEmpty_Click(object sender, MouseEventArgs e) => TabCtrlAdm.SelectedTab = PageInstruction;

        private void BtnProcCtrl_Click(object sender, EventArgs e) => TabCtrlAdm.SelectedTab = PageProcCtrl;

        //
        //收放
        //
        private  void BtnYorN_Click(object sender,EventArgs e)
        {
            BtnYorN btnYorN = sender as BtnYorN;          
            if (btnYorN == BtnBListYorN){
                BtnYorNCtrl.CheckYorN(BtnBListYorN,"B_Clicked");
                ViewMethod.ContracAndAmplifica(PnlBList, BtnBListYorN,"B_Clicked"); }
            if (btnYorN == BtnWListYorN) { BtnYorNCtrl.CheckYorN(BtnWListYorN,"W_Clicked"); ViewMethod.ContracAndAmplifica(PnlWList, BtnWListYorN,"W_Clicked"); }
            if (btnYorN == BtnListPathYorN) { BtnYorNCtrl.CheckYorN(BtnListPathYorN, "P_Clicked"); }

           
        }
        private void Label_Click(object sender,EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == LblConsole) { ViewMethod.ContracAndAmplifica(LvConsole); }
            if (lbl == LblRegustriy) { ViewMethod.ContracAndAmplifica(LvRegustry); }
            if (lbl == LblSys) { ViewMethod.ContracAndAmplifica(LvSys); }
            if (lbl == LblCtrlPnl) { ViewMethod.ContracAndAmplifica(LvCtrlPnl); }
            if (lbl == LblRunTool) { ViewMethod.ContracAndAmplifica(LvRunTool); }
            if (lbl == LblTaskMgr) { ViewMethod.ContracAndAmplifica(LvTaskMgr); }
            if (lbl == LblCmd) { ViewMethod.ContracAndAmplifica(LvCmd); }
            if (lbl == LblPS) { ViewMethod.ContracAndAmplifica(LvPS); }
            if (lbl == LblBListTitleN) ViewMethod.ContracAndAmplifica(PnlBList);
            if (lbl == LblWListTN) ViewMethod.ContracAndAmplifica(PnlWList);
        }  

        //
        //页面跳转
        //
        private void BtnBListSet_Click(object sender, EventArgs e)
        {
            var bListSetForm = new BandWListSetForm();
            bListSetForm.Show();
        }

        private void TlStrBtnWListSet_Click(object sender, EventArgs e)
        {
            var wListSetForm = new BandWListSetForm();
            wListSetForm.Show();
        }

        private void MenuSetIP_Click(object sender, EventArgs e)
        {
            var setIPForm = new SetIPForm {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };

            setIPForm.Show();
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

        private void TSMIBack_Click(object sender, EventArgs e)
        {
            Close();
            var userForm = new UserForm();
            userForm.Show();
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
            BtnYorN btnYorN = sender as BtnYorN;
            if (btnYorN == BtnBListYorN)
            {
                BtnYorNCtrl.CheckYorN(BtnBListYorN, "B_Load");
                ViewMethod.Contraction(BtnBListYorN, PnlBList, "B_Load"); }
            if (btnYorN == BtnWListYorN) {
                BtnYorNCtrl.CheckYorN(BtnWListYorN, "W_Load");
                ViewMethod.Contraction(BtnWListYorN, PnlWList, "W_Load"); }
            if (btnYorN == BtnListPathYorN)
                BtnYorNCtrl.CheckYorN(BtnListPathYorN,"P_Load");
        }
              
        private void BtnYorN_MouseUp(object sender,MouseEventArgs e)
        {
            BtnYorN btnYorN = new BtnYorN();
            if (btnYorN == BtnWListYorN)
                ViewMethod.ContracAndAmplifica(PnlWList,BtnWListYorN,"W_Clicked");
            if (btnYorN == BtnBListYorN)
                ViewMethod.ContracAndAmplifica(PnlBList, BtnBListYorN,"B_Clicked");
            if (btnYorN == BtnListPathYorN)
                BtnYorNCtrl.CheckYorN(BtnListPathYorN, "P_Load");
        }
       
        //
        //状态显示跟随开关改变
        //
        private void BtnYorNStatus_Load(object sender,EventArgs e)
        {
            BtnYorN btnYorN = sender as BtnYorN;
            if (btnYorN == BtnRegustriyYorN) ViewMethod.StatusChange(btnYorN, LvRegustry, "Registry_Load");
            if (btnYorN == BtnConsoleYorN) ViewMethod.StatusChange(btnYorN, LvConsole,"Mmc_Load");
            if (btnYorN == BtnSysYorN) ViewMethod.StatusChange(BtnSysYorN, LvSys,"Sys_Load");
            if (btnYorN == BtnCtrlPnlYorN) ViewMethod.StatusChange(BtnCtrlPnlYorN, LvCtrlPnl,"CtrlPnl_Load");
            if (btnYorN == BtnRunToolYorN) ViewMethod.StatusChange(BtnRunToolYorN, LvRunTool,"RunTool_Load");
            if (btnYorN == BtnTaskMgrYorN) ViewMethod.StatusChange(BtnTaskMgrYorN, LvTaskMgr,"Taskmgr_Load");
            if (btnYorN == BtnCmdYorN) ViewMethod.StatusChange(BtnCmdYorN, LvCmd,"Cmd_Load");
            if (btnYorN == BtnPSYorN) ViewMethod.StatusChange(BtnPSYorN, LvPS,"PwrShell_Load");
        }
   
        private void BtnYorNStatus_MouseUp(object sender,MouseEventArgs e)
        {
            BtnYorN btnYorN = sender as BtnYorN;
            if (btnYorN == BtnRegustriyYorN) ViewMethod.StatusChange(btnYorN, LvRegustry, "Registry_Clicked");
            if (btnYorN == BtnConsoleYorN) ViewMethod.StatusChange(btnYorN, LvConsole, "Mmc_Clicked");
            if (btnYorN == BtnSysYorN) ViewMethod.StatusChange(BtnSysYorN, LvSys, "Sys_Clicked");
            if (btnYorN == BtnCtrlPnlYorN) ViewMethod.StatusChange(BtnCtrlPnlYorN, LvCtrlPnl, "CtrlPnl_Clicked");
            if (btnYorN == BtnRunToolYorN) ViewMethod.StatusChange(BtnRunToolYorN, LvRunTool, "RunTool_Clicked");
            if (btnYorN == BtnTaskMgrYorN) ViewMethod.StatusChange(BtnTaskMgrYorN, LvTaskMgr, "Taskmgr_Clicked");
            if (btnYorN == BtnCmdYorN) ViewMethod.StatusChange(BtnCmdYorN, LvCmd, "Cmd_Clicked");
            if (btnYorN == BtnPSYorN) ViewMethod.StatusChange(BtnPSYorN, LvPS, "PwrShell_Clicked");
        }

       
        //
        //项目成员名跳转github主页
        //
        private void LblCreater1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/MFunction96");
        }
             
        private void LblCreater2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/hlys");
        }

        private void LblCreater3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/ChrisYoung96");
        }

       //
       //左侧栏点击颜色变化
       //      
        private void BtnColor_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
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
            if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "D");
        }
        
        private void LblColor_MouseLeave(object sender, EventArgs e)
        {

            Label lbl = sender as Label;
            if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "L");
            if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "L");
        }

        private void MenuPwdChange_Click(object sender, EventArgs e)
        {
            var pwdchangeform = new PwdChangeForm();
            pwdchangeform.Show();
        }

        private void BtnColor_MouseLeave(object sender, EventArgs e)
        {            
                Button button = sender as Button;
                if (button == BtnConsole) ViewMethod.ColorChange(BtnConsole, "L");
                if (button == BtnRegustry) ViewMethod.ColorChange(BtnRegustry, "L");
                if (button == BtnCmd) ViewMethod.ColorChange(BtnCmd, "L");
                if (button == BtnPS) ViewMethod.ColorChange(BtnPS, "L");
                if (button == BtnCtrlPnl) ViewMethod.ColorChange(BtnCtrlPnl, "L");
                if (button == BtnTaskMgr) ViewMethod.ColorChange(BtnTaskMgr, "L");
                if (button == BtnSys) ViewMethod.ColorChange(BtnSys, "L");
                if (button == BtnRunTool) ViewMethod.ColorChange(BtnRunTool, "L");
                if (button == BtnProcCtrl) ViewMethod.ColorChange(BtnProcCtrl, "L");
            if (button == BtnIm) ViewMethod.ColorChange(BtnIm, "L");
            if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "L");
        }

        private void BtnColor_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == BtnConsole) ViewMethod.ColorChange(BtnConsole, "E");
            if (button == BtnRegustry) ViewMethod.ColorChange(BtnRegustry, "E");
            if (button == BtnCmd) ViewMethod.ColorChange(BtnCmd, "E");
            if (button == BtnPS) ViewMethod.ColorChange(BtnPS, "E");
            if (button == BtnCtrlPnl) ViewMethod.ColorChange(BtnCtrlPnl, "E");
            if (button == BtnTaskMgr) ViewMethod.ColorChange(BtnTaskMgr, "E");
            if (button == BtnSys) ViewMethod.ColorChange(BtnSys, "E");
            if (button == BtnRunTool) ViewMethod.ColorChange(BtnRunTool, "E");
            if (button == BtnProcCtrl) ViewMethod.ColorChange(BtnProcCtrl, "E");
            if (button == BtnIm) ViewMethod.ColorChange(BtnIm, "E");
            if (button == BtnEx) ViewMethod.ColorChange(BtnEx, "E");
        }

        private void LblColor_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "D");
            if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "D");
        }

        private void LblStatus_MouseLeave(object sender, EventArgs e)
        {
            LblStatus.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void LblColor_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl == LblOptimization) ViewMethod.ColorChange(LblOptimization, "E");
            if (lbl == LblStatus) ViewMethod.ColorChange(LblStatus, "E");
        }

        private void PageAbout_Click(object sender, EventArgs e)
        {

        }

        private void LvPlanningTask_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }

}