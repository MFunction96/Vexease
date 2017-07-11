namespace CommunalComputerManager.Views
{
    partial class RequestEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(559, 444);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 30);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "取消";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(295, 445);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 30);
            this.Button4.TabIndex = 12;
            this.Button4.Text = "确定";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(641, 77);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 30);
            this.Button3.TabIndex = 11;
            this.Button3.Text = "设为默认";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // CheckedListBox1
            // 
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Items.AddRange(new object[] {
            "禁用控制台",
            "禁用注册表",
            "禁用计划任务",
            "禁用控制面板",
            "禁用运行工具",
            "禁用命令提示符",
            "禁用任务管理器",
            "禁用POWESHELL"});
            this.CheckedListBox1.Location = new System.Drawing.Point(160, 122);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.Size = new System.Drawing.Size(649, 304);
            this.CheckedListBox1.TabIndex = 10;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(747, 77);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 30);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "删除";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(560, 77);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 30);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "新建";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "默认配置"});
            this.ComboBox1.Location = new System.Drawing.Point(160, 78);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(374, 23);
            this.ComboBox1.TabIndex = 7;
            // 
            // RequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.CheckedListBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ComboBox1);
            this.Name = "RequestEdit";
            this.Text = "RequestEdit";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.CheckedListBox CheckedListBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox ComboBox1;
    }
}