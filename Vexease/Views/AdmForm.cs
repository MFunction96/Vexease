using System;
using System.ComponentModel;
using System.Windows.Forms;

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
            //ControlBox = false;//上面三个按钮隐藏
           // ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
                                                          //隐藏标签,改成设置Itemsize为（1,1）了
                                                          /*TabCtrlAdm.Region = new Region(new RectangleF(PageCtrlPnl.Left,
                                                            PageCtrlPnl.Top, PageCtrlPnl.Width, PageCtrlPnl.Height));*/

            PnlWListTN.Width = PageAbout.Width - 100;
            // LvCmd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Colwidth(LvCmd);
            Colwidth(LvConsole);
            Colwidth(LvCtrlPnl);
            Colwidth(LvPlanningTask);
            Colwidth(LvPS);
            Colwidth(LvRegustry);
            Colwidth(LvRunTool);
            Colwidth(LvTaskMgr);
        }

        //Tab 可以切换TabControl中的页，可以通过捕捉按键消息屏蔽 组合键
        /* protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
         {
             switch (keyData)
             {
                 case (Keys.Tab | Keys.Control):
                     return true;

                 default:
                     break;
             }
             return base.ProcessCmdKey(ref msg, keyData);
         }*/
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
              var onclosingForm = new OnClosingForm();
              onclosingForm.ShowDialog();
              Application.DoEvents();
             if (onclosingForm.t==0)
              {
                //t=0,最小化

                Hide();
                  NotifyIcon.Visible = true;//托盘图标可见
                onclosingForm.Close();
              }
              else if(onclosingForm.t==1)
              {
                  //t=1，关闭
                  e.Cancel = false;
                  Environment.Exit(0);//彻底关掉！
              }
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
        private void BListTNCtrl_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..

            if (PnlBList.Height == 0 && BtnBListYorN.Checked == true) { PnlBList.Height = 90; } else { PnlBList.Height = 0; }
        }

        private void WListTNCtrl_Click(object sender, EventArgs e)
        {
            // int n = 0;//给个名单内名字的个数吧..

            if (PnlWList.Height == 0 && BtnWListYorN.Checked == true) { PnlWList.Height = 90; } else { PnlWList.Height = 0; }
        }       

        private void LblConsole_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvConsole.Height == 0) { LvConsole.Height = 90; } else { LvConsole.Height = 0; }
        }

        private void LblRegustriy_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvRegustry.Height == 0 ) { LvRegustry.Height = 90; } else { LvRegustry.Height = 0; }
        }

        private void LblPlanningTask_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvPlanningTask.Height == 0 ) { LvPlanningTask.Height = 90; } else { LvPlanningTask.Height = 0; }
        }

        private void LblCtrlPnl_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvCtrlPnl.Height == 0 ) { LvCtrlPnl.Height = 90; } else { LvCtrlPnl.Height = 0; }
        }

        private void LblRunTool_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvRunTool.Height == 0 ) { LvRunTool.Height = 90; } else { LvRunTool.Height = 0; }
        }

        private void LblTaskMgr_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvTaskMgr.Height == 0 ) { LvTaskMgr.Height = 90; } else { LvTaskMgr.Height = 0; }
        }

        private void LblCmd_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvCmd.Height == 0 ) { LvCmd.Height = 90; } else { LvCmd.Height = 0; }
        }

        private void LblPS_Click(object sender, EventArgs e)
        {
            //int n = 0;//给个名单内名字的个数吧..
            if (LvPS.Height == 0 ) { LvPS.Height = 90; } else { LvPS.Height = 0; }
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
            if (BtnConsole.Height == 0)
            {
                BtnConsole.Height = BtnRegustry.Height =
                    BtnPlanningTask.Height = BtnCtrlPnl.Height =
                    BtnRunTool.Height = BtnTaskMgr.Height =
                    BtnCmd.Height = BtnPS.Height =BtnProcCtrl.Height= 30;
            }
            else
            {
                BtnConsole.Height = BtnRegustry.Height =
                    BtnPlanningTask.Height = BtnCtrlPnl.Height =
                    BtnRunTool.Height = BtnTaskMgr.Height =
                    BtnCmd.Height = BtnPS.Height =BtnProcCtrl.Height= 0;
            }
        }

      

        //
        //方法-列表的宽度计算
        //

        private void Colwidth(ListView listview)
        {
            foreach (ColumnHeader item in listview.Columns)
            {
                switch (item.Text)
                {
                    case "默认状态":
                        item.Width = listview.Width / 2 - 5;
                        break;

                    case "当前状态":
                        item.Width = listview.Width / 2 - 5;
                        break;

                    default:
                        item.Width = -2;
                        break;
                }
            }
        }

        //
        //checkbutton-状态列表的收缩
        //
        private void BtnBListYorN_Load(object sender, EventArgs e)
        {
            if (BtnBListYorN.Checked == false)
            {
                PnlBList.Height = 0;
            }
        }

        private void BtnWListYorN_Load(object sender, EventArgs e)
        {
            if (BtnWListYorN.Checked == false)
            {
                PnlWList.Height = 0;
            }
        }
       
        private void BtnWListYorNStatus_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnWListYorN.Checked == false)
            {
                PnlWList.Height = 0;
            }
            else
            {
                PnlWList.Height = 90;
            }
        }

        private void BtnBListYorNStatus_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnBListYorN.Checked == false)
            {
                PnlBList.Height = 0;
            }
            else
            {
                PnlBList.Height = 90;
            }
        }
        //
        //状态显示跟随开关改变
        //
        private void BtnRegustriyYorN_Load(object sender, EventArgs e)
        {
            if (BtnRegustriyYorN.Checked == false)
            {
                LvRegustry.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvRegustry.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnConsoleYorN_Load(object sender, EventArgs e)
        {
            if (BtnConsoleYorN.Checked == false)
            {
                LvConsole.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvConsole.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnPlanningTaskYorN_Load(object sender, EventArgs e)
        {
            if (BtnPlanningTaskYorN.Checked == false)
            {

                LvPlanningTask.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvPlanningTask.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnCtrlPnlYorN_Load(object sender, EventArgs e)
        {
            if (BtnCtrlPnlYorN.Checked == false)
            {

                LvCtrlPnl.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvCtrlPnl.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnRunToolYorN_Load(object sender, EventArgs e)
        {
            if (BtnRunToolYorN.Checked == false)
            {

                LvRunTool.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvRunTool.Items[1].SubItems[1].Text = "启用中";
            }
        }
                
        private void BtnTaskMgrYorN_Load(object sender, EventArgs e)
        {
            if (BtnTaskMgrYorN.Checked == false)
            {

                LvTaskMgr.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvTaskMgr.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnCmdYorN_Load(object sender, EventArgs e)
        {
            if (BtnCmdYorN.Checked == false)
            {
                LvCmd.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvCmd.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnPSYorN_Load(object sender, EventArgs e)
        {
            if (BtnPSYorN.Checked == false)
            {

                LvPS.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvPS.Items[1].SubItems[1].Text = "启用中";
            }
        }      

        private void BtnConsoleYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnConsoleYorN.Checked == false)
            {

                LvConsole.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvConsole.Items[1].SubItems[1].Text = "启用中";
            }
        
        }

        private void BtnRegustriyYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnRegustriyYorN.Checked == false)
            {

                LvRegustry.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvRegustry.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnPlanningTaskYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnPlanningTaskYorN.Checked == false)
            {
                LvPlanningTask.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvPlanningTask.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnCtrlPnlYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnCtrlPnlYorN.Checked == false)
            {

                LvCtrlPnl.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvCtrlPnl.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnRunToolYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnRunToolYorN.Checked == false)
            {

                LvRunTool.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvRunTool.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnTaskMgrYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnTaskMgrYorN.Checked == false)
            {

                LvTaskMgr.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvTaskMgr.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnCmdYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnCmdYorN.Checked == false)
            {
                LvCmd.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvCmd.Items[1].SubItems[1].Text = "启用中";
            }
        }

        private void BtnPSYorN_MouseUp(object sender, MouseEventArgs e)
        {
            if (BtnPSYorN.Checked == false)
            {

                LvPS.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                LvPS.Items[1].SubItems[1].Text = "启用中";
            }
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
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
             BtnConsole.BackColor =System.Drawing.Color.LightSkyBlue;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            BtnConsole.BackColor = System.Drawing.Color.White;
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            BtnConsole.BackColor = System.Drawing.Color.DeepSkyBlue;
        }
        //
        private void BtnRegustry_MouseDown(object sender, MouseEventArgs e)
        {
            BtnRegustry.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnRegustry_MouseEnter(object sender, EventArgs e)
        {
            BtnRegustry.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnRegustry_MouseLeave(object sender, EventArgs e)
        {
            BtnRegustry.BackColor = System.Drawing.Color.White;
        }

      

        private void BtnPlanningTask_MouseDown(object sender, MouseEventArgs e)
        {
            BtnPlanningTask.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnPlanningTask_MouseEnter(object sender, EventArgs e)
        {
            BtnPlanningTask.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnPlanningTask_MouseLeave(object sender, EventArgs e)
        {
            BtnPlanningTask.BackColor = System.Drawing.Color.White;
        }

       

        private void BtnCtrlPnl_MouseEnter(object sender, EventArgs e)
        {
            BtnCtrlPnl.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnCtrlPnl_MouseDown(object sender, MouseEventArgs e)
        {
            BtnCtrlPnl.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

               private void BtnCtrlPnl_MouseLeave(object sender, EventArgs e)
        {
            BtnCtrlPnl.BackColor = System.Drawing.Color.White;
        }
        //
        private void BtnRunTool_MouseDown(object sender, MouseEventArgs e)
        {

            BtnRunTool.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnRunTool_MouseEnter(object sender, EventArgs e)
        {

            BtnRunTool.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnRunTool_MouseLeave(object sender, EventArgs e)
        {
            BtnRunTool.BackColor = System.Drawing.Color.White;
        }
        
        private void BtnTaskMgr_MouseDown(object sender, MouseEventArgs e)
        {
            BtnTaskMgr.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnTaskMgr_MouseEnter(object sender, EventArgs e)
        {
            BtnTaskMgr.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnTaskMgr_MouseLeave(object sender, EventArgs e)
        {
            BtnTaskMgr.BackColor = System.Drawing.Color.White;
        }

               private void BtnCmd_MouseDown(object sender, MouseEventArgs e)
        {
            BtnCmd.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnCmd_MouseEnter(object sender, EventArgs e)
        {
            BtnCmd.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnCmd_MouseLeave(object sender, EventArgs e)
        {
            BtnCmd.BackColor = System.Drawing.Color.White;
        }

        private void BtnPS_MouseDown(object sender, MouseEventArgs e)
        {
            BtnPS.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnPS_MouseEnter(object sender, EventArgs e)
        {
            BtnPS.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnPS_MouseLeave(object sender, EventArgs e)
        {
            BtnPS.BackColor = System.Drawing.Color.White;
        }

        private void BtnProcCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            BtnProcCtrl.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnProcCtrl_MouseEnter(object sender, EventArgs e)
        {
            BtnProcCtrl.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnProcCtrl_MouseLeave(object sender, EventArgs e)
        {
            BtnProcCtrl.BackColor = System.Drawing.Color.White;
        }

        private void BtnIm_MouseDown(object sender, MouseEventArgs e)
        {
            BtnIm.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnIm_MouseEnter(object sender, EventArgs e)
        {
            BtnIm.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnIm_MouseLeave(object sender, EventArgs e)
        {
            BtnIm.BackColor = System.Drawing.Color.White;
        }

        private void BtnEx_MouseDown(object sender, MouseEventArgs e)
        {
            BtnEx.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void BtnEx_MouseEnter(object sender, EventArgs e)
        {
            BtnEx.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void BtnEx_MouseLeave(object sender, EventArgs e)
        {
            BtnEx.BackColor = System.Drawing.Color.White;
        }

        private void LblOptimization_MouseDown(object sender, MouseEventArgs e)
        {
            LblOptimization.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void LblOptimization_MouseEnter(object sender, EventArgs e)
        {
            LblOptimization.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void LblOptimization_MouseLeave(object sender, EventArgs e)
        {
            LblOptimization.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void LblStatus_MouseDown(object sender, MouseEventArgs e)
        {
            LblStatus.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void LblStatus_MouseEnter(object sender, EventArgs e)
        {
            LblStatus.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        private void LblStatus_MouseLeave(object sender, EventArgs e)
        {
            LblStatus.BackColor = System.Drawing.Color.DodgerBlue;
        }

    }
}