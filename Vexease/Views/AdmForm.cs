using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
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
       
        private AdmFormCtrl Controller { get; }
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
        /// 管理员界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdmForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; //最大化不可用
            MinimizeBox = false; //最小化不可用
            FormBorderStyle =FormBorderStyle.FixedSingle; //不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            //隐藏标签,改成设置Itemsize为（1,1）了
            /*TabCtrlAdm.Region = new Region(new RectangleF(PageCtrlPnl.Left,
              PageCtrlPnl.Top, PageCtrlPnl.Width, PageCtrlPnl.Height));*/
            PnlWListTN.Width = PageAbout.Width - 100;
            foreach (var pair in Controller.LvDictionary)
            {
                var value = pair.Value;
                var c = Controls.Find(value, true);
                Controller.Colwidth2((ListView) c[0]);
            }
            Controller.WListCtrlLoad(LvWListN);
            Controller.BListCtrlLoad(LvBListN);
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
            Application.DoEvents();
            Controller.CloseTips(this);
            NotifyIcon.Dispose();
            base.OnClosing(e);
        }

        
        

        /// <summary>
        /// Tab转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Title_Click(object sender, EventArgs e)
        {
            Controller.TabChange(TabCtrlAdm, sender);
        }
        
        /// <summary>
        /// 名单收放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            if (!(sender is Label lbl)) return;
            Controller.LblLvDictionary.TryGetValue(lbl.Name, out var n);
            var c = Controls.Find(n ?? throw new InvalidOperationException(), true);
            Controller.ContracAndAmplifica(c[0]);
        }

       /// <summary>
       /// 项目成员跳转Git
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void LblCreater1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/MFunction96");
        }
        /// <summary>
        ///  项目成员跳转Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblCreater2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/hlys");
        }
        /// <summary>
        ///  项目成员跳转Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblCreater3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/ChrisYoung96");
        }

        /******************左侧栏点击颜色变化*********************/
        private void BtnColor_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Control;
            Controller.ColorChange(button, "D");
        }

        private void MenuPwdChange_Click(object sender, EventArgs e)
        {
            var pwdchangeform = new PwdChangeForm(this);
            pwdchangeform.Show();
        }

        private void BtnColor_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Control;
            Controller.ColorChange(button, "L");
        }

        private void BtnColor_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Control;
            Controller.ColorChange(button, "E");
        }

        private void LblColor_MouseLeave(object sender, EventArgs e)
        {
            var lbLabel = sender as Label;
            Controller.ColorChange(lbLabel, "L");
        }      
      
        /******************页面跳转*********************/
        private void BtnBListSet_Click(object sender, EventArgs e)
        {
            var bListSetForm = new BandWListSetForm(this);
            bListSetForm.Show();
        }

        private void MenuSetIP_Click(object sender, EventArgs e)
        {
            var setIpForm = new SetIpForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };

            setIpForm.Show();
        }

        private void BtnIm_Click(object sender, EventArgs e)
        {
            var importform = new ImportForm();
            importform.Show();
        }

        private void MenuFileExport_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportForm();
            exportForm.Show();
        }

        private void BtnWListSet_Click(object sender, EventArgs e)
        {
            var wlistset = new WListSetForm(this);
            wlistset.Show();
        }

        private void BtnListSetP_Click(object sender, EventArgs e)
        {
            var listByPath = new ListByPathSetForm();
            listByPath.Show();
        }
       
        /****************** 事  件 *********************/
        /// <summary>
        /// 双击大标题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblStatus_DoubleClick(object sender, EventArgs e)
        {
            Controller.DoubleCliclLbl(BtnConsole, BtnRegustry, BtnSys, BtnCtrlPnl, BtnRunTool, BtnTaskMgr, BtnCmd,
                BtnPS, BtnProcCtrl);
        }

        /// <summary>
        /// 刷新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProcRe_Click(object sender, EventArgs e)
        {
            Controller.WListCtrlLoad(LvWListN);
            Controller.BListCtrlLoad(LvBListN);

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
        /// 状态显示更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYorN_Load(object sender, EventArgs e)
        {
            if(!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name,out var methodN);
            Controller.LoadYorN(btnYorN,methodN);
            Controller.LblLvDictionary.TryGetValue(btnYorN.Name, out var listN);
            var c = Controls.Find(listN ?? throw new InvalidOperationException(), true);
            var listview = (ListView) c[0];
            Controller.StatusChange(btnYorN,listview,methodN);
            Controller.ContracAndAmplifica(listview);
        }
        /// <summary>
        /// BtnYorN响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYorN_Click(object sender, EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var methodN);
            Controller.ClickYorN(methodN);
            Controller.LblLvDictionary.TryGetValue(btnYorN.Name, out var listN);
            var c = Controls.Find(listN ?? throw new InvalidOperationException(), true);
            var listview = (ListView)c[0];
            Controller.StatusChange(btnYorN, listview, methodN);
            Controller.ContracAndAmplifica(listview);
        }
        /// <summary>
        /// 进程名称状态显示更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYorNName_Load(object sender, EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var methodN);
            Controller.LblLvDictionary.TryGetValue(btnYorN.Name, out var listN);
            var c = Controls.Find(listN ?? throw new InvalidOperationException(), true);
            var panelN = (Panel)c[0];
            Controller.ContracAndAmplifica(btnYorN, panelN, methodN);

        }
        /// <summary>
        /// 进程名称BtnYorN响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYorNName_Click(object sender, EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var methodN);
            Controller.ClickYorN(methodN);
           // Controller.LoadYorN(btnYorN,methodN);
            Controller.LblLvDictionary.TryGetValue(btnYorN.Name, out var listN);
            var c = Controls.Find(listN ?? throw new InvalidOperationException(), true);
            var panelN = (Panel) c[0];
           Controller.ContracAndAmplifica(btnYorN,panelN,methodN);
            
        }
        private void BtnYorNPath_Load(object sender, EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var methodN);
            Controller.LoadYorN(btnYorN, methodN);
        }
        private void BtnYorNPath_Click(object sender, EventArgs e)
        {
            if (!(sender is BtnYorN btnYorN)) return;
            Controller.YorNLimitDictionary.TryGetValue(btnYorN.Name, out var methodN);
            Controller.ClickYorN(methodN);
          
        }

        private void BtnReFrash(object sender, EventArgs e)
        {
            if(!(sender is Button btn)) return;
           Controller.Fresh(btn);
            foreach (var item in Controller.YorNDictionary)
            {
                Controller.LblLvDictionary.TryGetValue(item.Key, out var listN);
                var btnYn = Controls.Find(item.Key, true);
                var btnYorN = (BtnYorN)btnYn[0];
                var c = Controls.Find(listN ?? throw new InvalidOperationException(), true);
                var listV = (ListView) c[0];
                Controller.LoadYorN(btnYorN,item.Value);
                Controller.StatusChange(btnYorN,listV,item.Value);
            }

        }
    }

}