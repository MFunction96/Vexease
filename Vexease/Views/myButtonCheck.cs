using System;

using System.Drawing;

using System.Windows.Forms;
using static System.Windows.Forms.ControlStyles;

namespace Vexease.Views
{
    public enum CheckStyle
    {
        Style1 = 0,
        Style2 = 1,
        Style3 = 2,
        Style4 = 3,
        Style5 = 4,
        Style6 = 5
    };

    public sealed partial class MyButtonCheck : UserControl
    {
        public MyButtonCheck()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            SetStyle(AllPaintingInWmPaint, value: true);
            SetStyle(DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(Selectable, true);
            SetStyle(SupportsTransparentBackColor, true);
            SetStyle(UserPaint, true);
            BackColor = Color.Transparent;

            Cursor = Cursors.Hand;
            Size = new Size(87, 27);
        }

        private bool _isCheck;

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked
        {
            set { _isCheck = value; Invalidate(); }
            get => _isCheck;
        }

        private CheckStyle _checkStyle = CheckStyle.Style1;

        /// <summary>
        /// 样式
        /// </summary>
        public CheckStyle CheckStyleX
        {
            set { _checkStyle = value; Invalidate(); }
            get => _checkStyle;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitMapOn = null;
            Bitmap bitMapOff = null;

            if (_checkStyle == CheckStyle.Style1)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn2;
            }
            else if (_checkStyle == CheckStyle.Style2)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn2;
            }
            else if (_checkStyle == CheckStyle.Style3)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn2;
            }
            else if (_checkStyle == CheckStyle.Style4)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn2;
            }
            else if (_checkStyle == CheckStyle.Style5)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn2;
            }
            else if (_checkStyle == CheckStyle.Style6)
            {
                bitMapOn = Properties.Resources.btn1;
                bitMapOff = Properties.Resources.btn1;
            }

            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, Size.Width, Size.Height);

            if (_isCheck)
            {
                if (bitMapOn != null) g.DrawImage(bitMapOn, rec);
            }
            else
            {
                if (bitMapOff != null) g.DrawImage(bitMapOff, rec);
            }
        }

        private void MyButtonCheck_Click(object sender, EventArgs e)
        {
            _isCheck = !_isCheck;
            Invalidate();
        }

        private void MyButtonCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
