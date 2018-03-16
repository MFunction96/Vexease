using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Vexease.Controllers.List;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Properties;
using Vexease.Views;

namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// 
    /// </summary>
    public class ListViewSetByPath
    {
        /// <inheritdoc />
        /// 
        public ListViewSetByPath(string lbl)
        {
            _originlistB = DataContext.GetTaskList(TaskTypeB);
            _originlistW = DataContext.GetTaskList(TaskTypeW);
            ListctrlB = new ListCtrl(TaskTypeB);
            ListctrlW =new ListCtrl(TaskTypeW);
            _lbl = lbl;
        }

        private const TASK_TYPE_FLAGS TaskTypeB = TASK_TYPE_FLAGS.DISALLOW_TASK_PATH;
        private const TASK_TYPE_FLAGS TaskTypeW = TASK_TYPE_FLAGS.RESTRICT_TASK_PATH;
        /// <summary>
        /// <para>信息框label</para>
        /// </summary>
        private readonly string _lbl;
        private ListCtrl ListctrlB { get; }
        private ListCtrl ListctrlW { get; }
        /// <summary>
        /// <para>初始列表</para>
        /// </summary>
        private readonly IEnumerable<string> _originlistB;
        /// <summary>
        /// <para>初始列表</para>
        /// </summary>
        private readonly IEnumerable<string> _originlistW;
        /// <summary>
        /// <para>LvBListByPath新列表</para>
        /// </summary>
        private readonly List<string> _newListB = new List<string>();
        /// <summary>
        /// <para>LvWListByPath新列表</para>
        /// </summary>
        private readonly List<string> _newListW = new List<string>();
        /// <summary>
        /// <para>是否添加</para>
        /// </summary>
        public bool Flag;
        /// <summary>
        /// LvBListByPath加载
        /// </summary>
        /// <param name="listView"></param>
        public void ListLoadB(ListView listView)
        {

            foreach (var item in _originlistB)
            {
                if (Ddd(listView, item))
                    listView.Items.Add(item);
            }
        }
        /// <summary>
        /// LvWListByPath加载
        /// </summary>
        /// <param name="listView"></param>
        public void ListLoadW(ListView listView)
        {

            foreach (var item in _originlistW)
            {
                if (Ddd(listView, item))
                    listView.Items.Add(item);
            }
        }
        /// <summary>
        /// 重复数据删除(Data De-Duplication, 简称DDD)
        /// </summary>
        /// <param name="listView">白名单列表</param>
        /// <param name="str">新添加的项</param>
        public bool Ddd(ListView listView, string str)
        {
            for (var i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Text == str)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// 新建项
        /// </summary>
        /// <param name="listView"></param>
        public void NewItem(ListView listView)
        {
            var newitem = new SetForm("新建进程项", _lbl);
            if (newitem.ShowDialog() == DialogResult.OK)
                if (Ddd(listView, newitem.NewText))
                    listView.Items.Add(newitem.NewText);
        }
        /// <summary>
        /// 编辑项
        /// </summary>
        /// <param name="listView"></param>
        public void EditItem(ListView listView)
        {
            if (listView.SelectedItems.Count < 1)
            {
                MessageBox.Show("您未选择任何项。", "错误");
                return;
            }
            var iNdex = listView.SelectedItems[0].Index;
            var edititem = new SetForm("编辑进程项", _lbl);
            if (edititem.ShowDialog() == DialogResult.OK)
                if (Ddd(listView, edititem.NewText))
                {
                    listView.Items[iNdex].Text = edititem.NewText;
                }

        }
        /// <summary>
        /// 删除项
        /// </summary>
        /// <param name="listView"></param>
        public void DelItem(ListView listView)
        {
            if (listView.SelectedItems.Count <= 0) return;
            var iNdex = listView.SelectedItems[0].Index;
            listView.Items[iNdex].Remove();
        }
        /****——————————————————————****/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listViewB"></param>
        /// <param name="listViewW"></param>
        public void SetCompare(ListView listViewB,ListView listViewW)
        {
            var bchange = ListctrlB.Compare(_newListB);
            var wchange = ListctrlW.Compare(_newListW);
            var baddstring = new StringBuilder();
            var bdelstring = new StringBuilder();
            var waddstring = new StringBuilder();
            var wdelstring = new StringBuilder();
            var index = 0;
            Flag = false;
            for (var i = 0; i < listViewB.Items.Count; i++)//将修改后的名单传给newlisr
            {
                _newListB?.Add(listViewB.Items[i].Text);
            }
            for (var i = 0; i < listViewW.Items.Count; i++)//将修改后的名单传给newlisr
            {
                _newListW?.Add(listViewW.Items[i].Text);
            }
            //若是没有修改就返回
            if (bchange.Item1 == null && bchange.Item2 == null&& wchange.Item1 == null && wchange.Item2 == null) return;
            if (bchange.Item1 != null)
            {
                foreach (var item in bchange.Item1)
                {
                    if(index==0)baddstring.Append("已添加黑名单进程路径：\n" + item);
                    else baddstring.Append(item+"\n");
                    index++;
                }
                index = 0;
            }

            if (bchange.Item2 != null)
            {
                foreach (var item in bchange.Item2)
                {
                    if(index==0) bdelstring.Append("\n已删除黑名单进程路径：\n" + item);
                    else bdelstring.Append(item+"\n");
                    index++;
                }
                index = 0;
            }

            if (wchange.Item1 != null)
            {
                foreach (var item in wchange.Item1)
                {
                    if (index==0)
                    waddstring.Append("\n已添加白名单进程路径：\n" + item);
                    else waddstring.Append(item+"\n");
                    index++;
                }
                index = 0;
            }

            if (wchange.Item2 != null)
            {
                foreach (var item in wchange.Item2)
                {
                    if (index == 0) wdelstring.Append("\n已删除白名单路径：\n" + item);
                    else wdelstring.Append(item+"\n");
                    index++;
                }
            }
            //消息框要携带  标题 信息 两个listview 和确认取消按钮
            
            var modificationForm = MessageBox.Show(Resources.WListSetFormCtrl_SetCompare_01 + 
                                                   baddstring +  bdelstring + waddstring + wdelstring+
                                                   Resources.ListViewSetByName_SetCompare_LF+
                                                   Resources.WListSetFormCtrl_SetCompare_03,
                    Resources.WListSetFormCtrl_SetCompare_确认修改, MessageBoxButtons.OKCancel);
            if (modificationForm != DialogResult.OK) return;
            ListctrlB.Apply(_newListB);
            ListctrlW.Apply(_newListW);
            Flag = true;
        }
    }
}