namespace Vexease.View
{
    partial class AdmForm
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
            System.Windows.Forms.ToolStripMenuItem MenuFileImport;
            this.MenuStripAdm = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetIP = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHlepView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.FlwLytPnlUser = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            MenuFileImport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripAdm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripAdm
            // 
            this.MenuStripAdm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSet,
            this.MenuHelp});
            this.MenuStripAdm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAdm.Name = "MenuStripAdm";
            this.MenuStripAdm.Size = new System.Drawing.Size(982, 28);
            this.MenuStripAdm.TabIndex = 0;
            this.MenuStripAdm.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MenuFileImport,
            this.MenuFileExport});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(51, 24);
            this.MenuFile.Text = "文件";
            // 
            // MenuFileImport
            // 
            MenuFileImport.Name = "MenuFileImport";
            MenuFileImport.Size = new System.Drawing.Size(181, 26);
            MenuFileImport.Text = "导入";
            // 
            // MenuFileExport
            // 
            this.MenuFileExport.Name = "MenuFileExport";
            this.MenuFileExport.Size = new System.Drawing.Size(181, 26);
            this.MenuFileExport.Text = "导出";
            // 
            // MenuSet
            // 
            this.MenuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSetIP});
            this.MenuSet.Name = "MenuSet";
            this.MenuSet.Size = new System.Drawing.Size(51, 24);
            this.MenuSet.Text = "设置";
            // 
            // MenuSetIP
            // 
            this.MenuSetIP.Name = "MenuSetIP";
            this.MenuSetIP.Size = new System.Drawing.Size(181, 26);
            this.MenuSetIP.Text = "设置IP地址";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHlepView,
            this.MenuHelpAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(51, 24);
            this.MenuHelp.Text = "帮助";
            // 
            // MenuHlepView
            // 
            this.MenuHlepView.Name = "MenuHlepView";
            this.MenuHlepView.Size = new System.Drawing.Size(181, 26);
            this.MenuHlepView.Text = "查看帮助文档";
            // 
            // MenuHelpAbout
            // 
            this.MenuHelpAbout.Name = "MenuHelpAbout";
            this.MenuHelpAbout.Size = new System.Drawing.Size(181, 26);
            this.MenuHelpAbout.Text = "关于Vexease";
            // 
            // FlwLytPnlUser
            // 
            this.FlwLytPnlUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FlwLytPnlUser.Location = new System.Drawing.Point(0, 0);
            this.FlwLytPnlUser.Name = "FlwLytPnlUser";
            this.FlwLytPnlUser.Size = new System.Drawing.Size(985, 103);
            this.FlwLytPnlUser.TabIndex = 1;
            this.FlwLytPnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.FlwLytPnlUser_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FlwLytPnlUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 725);
            this.panel1.TabIndex = 2;
            // 
            // AdmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStripAdm);
            this.MainMenuStrip = this.MenuStripAdm;
            this.Name = "AdmForm";
            this.Text = "管理员界面";
            this.MenuStripAdm.ResumeLayout(false);
            this.MenuStripAdm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripAdm;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileExport;
        private System.Windows.Forms.ToolStripMenuItem MenuSet;
        private System.Windows.Forms.ToolStripMenuItem MenuSetIP;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuHlepView;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpAbout;
        private System.Windows.Forms.FlowLayoutPanel FlwLytPnlUser;
        private System.Windows.Forms.Panel panel1;
    }
}