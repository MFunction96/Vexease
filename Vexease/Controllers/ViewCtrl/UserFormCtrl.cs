using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Data;
using Vexease.Properties;
using Vexease.Views;

namespace Vexease.Controllers.ViewCtrl
{
   public  class UserFormCtrl
    {
      ///<summary>
      ///关闭页面
      /// </summary>
      public static void CloseForm(Form form)
        {
            var onclosingForm = new OnClosingForm();
            onclosingForm.ShowDialog();
            Application.DoEvents();
            if (onclosingForm.RdoMin.Checked == true)
            {
                form.Hide();
                onclosingForm.Close();
            }
            else if (onclosingForm.RdoClose.Checked == true)
            {
                Environment.Exit(0);//彻底关掉！
            }
        }
    }
}
