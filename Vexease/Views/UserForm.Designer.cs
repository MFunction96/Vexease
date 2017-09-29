namespace Vexease.Views
{
    partial class UserForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "控制台状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "注册表状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "计划任务状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "控制面板状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "运行工具状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "任务管理器状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "命令提示符状态",
            "禁用",
            "已启用"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "PowerShell状态",
            "禁用",
            "已启用"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.BtnSwitchToAdmMode = new System.Windows.Forms.Button();
            this.LvUser = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDflt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnSwitchToAdmMode
            // 
            this.BtnSwitchToAdmMode.Location = new System.Drawing.Point(306, 311);
            this.BtnSwitchToAdmMode.Name = "BtnSwitchToAdmMode";
            this.BtnSwitchToAdmMode.Size = new System.Drawing.Size(154, 30);
            this.BtnSwitchToAdmMode.TabIndex = 1;
            this.BtnSwitchToAdmMode.Text = "切换至管理员模式";
            this.BtnSwitchToAdmMode.UseVisualStyleBackColor = true;
            this.BtnSwitchToAdmMode.Click += new System.EventHandler(this.BtnSwitchToAdmMode_Click);
            // 
            // LvUser
            // 
            this.LvUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.ColDflt,
            this.ColNow});
            this.LvUser.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.LvUser.Location = new System.Drawing.Point(61, 60);
            this.LvUser.Name = "LvUser";
            this.LvUser.Size = new System.Drawing.Size(659, 229);
            this.LvUser.TabIndex = 2;
            this.LvUser.UseCompatibleStateImageBehavior = false;
            this.LvUser.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "名称";
            this.ColName.Width = 175;
            // 
            // ColDflt
            // 
            this.ColDflt.Text = "默认状态";
            // 
            // ColNow
            // 
            this.ColNow.Text = "当前状态";
            this.ColNow.Width = 141;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.LvUser);
            this.Controls.Add(this.BtnSwitchToAdmMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "用户模式";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSwitchToAdmMode;
        private System.Windows.Forms.ListView LvUser;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader ColDflt;
        private System.Windows.Forms.ColumnHeader ColNow;
    }
}