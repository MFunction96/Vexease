using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vexease.Views
{
    public partial class ListByPathSetForm : Form
    {
        public ListByPathSetForm()
        {
            //屏幕中间显示
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void WListSetForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
                                                          //隐藏标签,改成设置Itemsize为（1,1）了
                                                          /*TabCtrlAdm.Region = new Region(new RectangleF(PageCtrlPnl.Left,
                                                            PageCtrlPnl.Top, PageCtrlPnl.Width, PageCtrlPnl.Height));*/
            Colwidth(LvBListByPath);

        }
        //
        //
        //
        private void Colwidth(ListView listview)
        {
            foreach (ColumnHeader item in listview.Columns)
            {
                switch (item.Text)
                {
                    case "变量":
                        item.Width = 100;
                        break;

                    case "值":
                        item.Width = (listview.Width - 100)/2-1;
                        break;

                    default:
                        item.Width = -2;
                        break;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
