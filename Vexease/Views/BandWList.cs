using CCWin;
using System;
using System.Windows.Forms;
using CCWin.SkinControl;
using Vexease.Controllers.ListCtrl;
using Vexease.Data;
using Vexease.Models.Enums;

namespace Vexease.Views
{
    //不同方式一个是拖进去，一个是看路径
    //0.0不对的话，欢迎返工
    public partial class BandWList : CCSkinMain
    {

        public TASK_TYPE_FLAGS TaskType { get; }

        public BandWList(TASK_TYPE_FLAGS taskType)
        {
            InitializeComponent();
            TaskType = taskType;
        }

        private void BandWList_Load(object sender, EventArgs e)
        {
            TaskListBox.Items.Clear();
            var tasks = DataContext.GetTaskList(TaskType);
            foreach (var task in tasks)
            {
                TaskListBox.Items.Add(new SkinListBoxItem(task.LpValue.ToString()));
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ListCtrl.AddTask(TaskInfo.Text, TaskType))
            {
                TaskListBox.Items.Add(new SkinListBoxItem(TaskInfo.Text));
            }
            else
            {
                MessageBox.Show("已有重复进程");
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var modifying = new Modifying_bandwist();
            modifying.Show();
            Close();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            var item = (SkinListBoxItem)TaskListBox.SelectedItem;
            ListCtrl.DelTask(item.Text, TaskType);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ListCtrl.Reset();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            TaskInfo.Text = BrowseTask();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private string BrowseTask()
        {
            if ((uint)TaskType >> 1 > 0)
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

        private void BtnModify_Click(object sender, EventArgs e)
        {
            var item = (SkinListBoxItem)TaskListBox.SelectedItem;
            ListCtrl.ModifyTask(item.Text, TaskInfo.Text, TaskType);
        }
    }
}
