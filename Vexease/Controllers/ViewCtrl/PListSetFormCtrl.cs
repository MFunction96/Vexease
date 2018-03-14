﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Vexease.Controllers.List;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Properties;

namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// 白名单设置界面控制器
    /// </summary>
    public class PListSetFormCtrl
    {
        private ListCtrl ListctrlB { get; }
        private ListCtrl ListctrlW { get; }
        const TASK_TYPE_FLAGS TaskTypeB = TASK_TYPE_FLAGS.DISALLOW_TASK_NAME;
        const TASK_TYPE_FLAGS TaskTypeW = TASK_TYPE_FLAGS.DISALLOW_TASK_NAME;
        private readonly string[] _bListN = DataContext.GetTaskList(TaskTypeB);
        private readonly string[] _wListN = DataContext.GetTaskList(TaskTypeW);
        private List<string> _newList = new List<string>();
        /// <summary>
        /// 是否修改成功的flag
        /// </summary>
        public bool Flag;

        /// <summary>
        /// 构造函数
        /// </summary>
        public PListSetFormCtrl()
        {
            ListctrlB = new ListCtrl(TaskTypeB);
            ListctrlW = new ListCtrl(TaskTypeW);
        }

        /// <summary>
        /// 白名单（名称）列表加载
        /// </summary>
        /// <param name="listView"></param>
        public void WListCtrlLoad(ListView listView)
        {
            var i = 0;
            while (_bListN != null && i < _bListN.Length)
            {
                if (_bListN[i] != null)
                    listView.Items.Add(_bListN[i]);
                i++;
            }
        }

        /// <summary>
        /// 新建黑名单项
        /// </summary>
        public void NewInsertForm(ListView listView)
        {
            var newInfo = Interaction.InputBox("进程名称：", "新建用户变量");
            if (Ddd(listView, newInfo))
                listView.Items.Add(newInfo);
        }

        /// <summary>
        /// 编辑黑名单项
        /// </summary>
        /// <param name="listView"></param>
        public void EditInsertForm(ListView listView)
        {
            var iNdex = listView.SelectedIndices;
            var info = Interaction.InputBox("进程名称：", "编辑用户变量");
            if (Ddd(listView, info))
                listView.Items[iNdex[0]].Text = info;
        }

        /// <summary>
        /// 删除黑名单项
        /// </summary>
        /// <param name="listView"></param>
        public void Del(ListView listView)
        {
            if (listView.SelectedItems.Count <= 0) return;
            var iNdex = listView.SelectedItems[0].Index;
            listView.Items[iNdex].Remove();
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
        /***************点击确认之后****************/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        public void SetCompare(ListView listView)
        {
            Flag = false;
            for (var i = 0; i < listView.Items.Count; i++)//将修改后的名单传给newlisr
            {
                _newList?.Add(listView.Items[i].Text);
            }

            var a = ListctrlB.Compare(_newList);
            //若是没有修改就返回
            if (a.Item1 == null && a.Item2 == null) return;
            var addstring = new StringBuilder();
            var delstring = new StringBuilder();
            if (a.Item1 != null)
                for (var j = 0; j < a.Item1.Count(); j++)
                {
                    addstring.Append(a.Item1.ElementAt(j) + "/n");
                }

            if (a.Item2 != null)
                for (var j = 0; j < a.Item2.Count(); j++)
                {
                    delstring.Append(a.Item2.ElementAt(j) + "/n");
                }

            //消息框要携带  标题 信息 两个listview 和确认取消按钮
            var modificationForm = MessageBox.Show(Resources.WListSetFormCtrl_SetCompare_01 + addstring + Resources.WListSetFormCtrl_SetCompare_02 + delstring + Resources.WListSetFormCtrl_SetCompare_03,
                Resources.WListSetFormCtrl_SetCompare_确认修改, MessageBoxButtons.OKCancel);
            if (modificationForm != DialogResult.OK) return;
            ListctrlB.Apply(_newList);
            Flag = true;
        }
    }
}