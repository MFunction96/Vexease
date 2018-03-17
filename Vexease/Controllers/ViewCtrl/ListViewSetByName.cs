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
    public class ListViewSetByName
    {
        /// <inheritdoc />
        public ListViewSetByName(TASK_TYPE_FLAGS taskType,string lbl)
        {
            DataContext.GetTaskList(taskType);
            Listctrl = new ListCtrl(taskType);
            _lbl = lbl;
        }

        /// <summary>
        /// <para>信息框label</para>
        /// </summary>
        private readonly string _lbl;
        private ListCtrl Listctrl { get; }

        /// <summary>
        /// <para>新列表</para>
        /// </summary>
        private readonly List<string> _newList =new List<string>();
        /// <summary>
        /// <para>是否添加</para>
        /// </summary>
        public bool Flag;

        /// <summary>
        /// Listview加载
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="taskType"></param>
        public void ListLoad(ListView listView, TASK_TYPE_FLAGS taskType)
        {
            listView.Items.Clear();
            foreach (var item in DataContext.GetTaskList(taskType))
            {
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
            if (newitem.ShowDialog()==DialogResult.OK)
                if (Ddd(listView, newitem.NewText))
                    listView.Items.Add(newitem.NewText);
        }
        /// <summary>
        /// 编辑项
        /// </summary>
        /// <param name="listView"></param>
        public void EditItem(ListView listView)
        {
            if (listView.SelectedItems.Count<1)
            {
                MessageBox.Show(Resources.ListViewSetByPath_EditItem_NoSelect, Resources.ListViewSetByName_Warning);
                return;
            }
            var iNdex = listView.SelectedItems[0].Index;
            var edititem =new SetForm("编辑进程项",_lbl);
            if (edititem.ShowDialog()==DialogResult.OK)
                if (Ddd(listView, edititem.NewText))
                {
                    listView.Items[iNdex].Text=edititem.NewText;
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
        /// <param name="listView"></param>
        public void SetCompare(ListView listView)
        {
            var addstring = new StringBuilder();
            var delstring = new StringBuilder();
            var index = 0;
            Flag = false;
            for (var i = 0; i < listView.Items.Count; i++)//将修改后的名单传给newlisr
            {
                _newList?.Add(listView.Items[i].Text);
            }

            var a = Listctrl.Compare(_newList);
            //若是没有修改就返回
            if (a.Item1 == null && a.Item2 == null) return;

            if (a.Item1 != null)
            {
                foreach (var item in a.Item1)
                {
                    if (index == 0) addstring.Append("已添加进程名称：\n" + item);
                    else addstring.Append(item);
                    index++;
                }

                index = 0;
            }

            if (a.Item2 != null)
            {
                foreach (var item in a.Item2)
                {
                    if (index == 0) delstring.Append("\n已删除的进程名称：\n" + item);
                    else delstring.Append(item);
                    index++;
                }
            }

            //消息框要携带  标题 信息 两个listview 和确认取消按钮
            
                var modificationForm = MessageBox.Show(Resources.WListSetFormCtrl_SetCompare_01 + Resources.ListViewSetByName_SetCompare_LF +
                                                       addstring + delstring +
                                                       Resources.ListViewSetByName_SetCompare_LF 
                                                       + Resources.WListSetFormCtrl_SetCompare_03,
                    Resources.WListSetFormCtrl_SetCompare_确认修改, MessageBoxButtons.OKCancel);
                if (modificationForm != DialogResult.OK) return;
                Listctrl.Apply(_newList);
                Flag = true;
            
           
        }
    }
}