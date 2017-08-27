using CCWin;
using System;
using System.Windows.Forms;
using Vexease.Models.Enums;

namespace Vexease.Views
{
    //不同方式一个是拖进去，一个是看路径
    //0.0不对的话，欢迎返工
    public partial class BandWList : CCSkinMain
    {
        
        public TASK_TYPE_FLAGS ProcessFlag { get; }

        public BandWList(TASK_TYPE_FLAGS processFlag)
        {
            InitializeComponent();
            ProcessFlag = processFlag;
        }

        private void BandWList_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var modifying = new Modifying_bandwist();
            modifying.Show();
            Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            ProcessInfo.Text = BrowseProcess();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private string BrowseProcess()
        {
            if ((uint)ProcessFlag >> 1 > 0)
            {
                var dialog = new FolderBrowserDialog
                {
                    Description = "请选择进程路径",
                    ShowNewFolderButton = true,
                    RootFolder = Environment.SpecialFolder.CommonPrograms
                };
                dialog.ShowDialog();
                return dialog.SelectedPath;
            }
            else
            {
                var dialog = new OpenFileDialog
                {
                    Multiselect = false,
                    Title = "请选择进程文件",
                    Filter = "进程文件|.exe"
                };
                dialog.ShowDialog();
                return dialog.SafeFileName;
            }
        }
    }
}
