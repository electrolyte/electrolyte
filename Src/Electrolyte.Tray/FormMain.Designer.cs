namespace Electrolyte.Tray
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.SysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SysTrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SysTrayIconMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayIconMenu_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SysTrayIconMenu_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SysTrayIconMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayIconMenu_OnlineHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayIconMenu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayIconMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Modules = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_OnlineHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SysTrayIconMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysTrayIcon
            // 
            this.SysTrayIcon.ContextMenuStrip = this.SysTrayIconMenu;
            this.SysTrayIcon.Text = "Electrolyte";
            this.SysTrayIcon.Visible = true;
            // 
            // SysTrayIconMenu
            // 
            this.SysTrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SysTrayIconMenu_Open,
            this.SysTrayIconMenu_Separator1,
            this.SysTrayIconMenu_Separator2,
            this.SysTrayIconMenu_About,
            this.SysTrayIconMenu_OnlineHelp,
            this.SysTrayIconMenu_Options,
            this.SysTrayIconMenu_Exit});
            this.SysTrayIconMenu.Name = "SysTrayIconMenu";
            this.SysTrayIconMenu.Size = new System.Drawing.Size(171, 148);
            // 
            // SysTrayIconMenu_Open
            // 
            this.SysTrayIconMenu_Open.Name = "SysTrayIconMenu_Open";
            this.SysTrayIconMenu_Open.Size = new System.Drawing.Size(170, 22);
            this.SysTrayIconMenu_Open.Text = "Open Electrolyte...";
            this.SysTrayIconMenu_Open.Click += new System.EventHandler(this.SysTrayIconMenu_Open_Click);
            // 
            // SysTrayIconMenu_Separator1
            // 
            this.SysTrayIconMenu_Separator1.Name = "SysTrayIconMenu_Separator1";
            this.SysTrayIconMenu_Separator1.Size = new System.Drawing.Size(167, 6);
            // 
            // SysTrayIconMenu_Separator2
            // 
            this.SysTrayIconMenu_Separator2.Name = "SysTrayIconMenu_Separator2";
            this.SysTrayIconMenu_Separator2.Size = new System.Drawing.Size(167, 6);
            // 
            // SysTrayIconMenu_About
            // 
            this.SysTrayIconMenu_About.Name = "SysTrayIconMenu_About";
            this.SysTrayIconMenu_About.Size = new System.Drawing.Size(170, 22);
            this.SysTrayIconMenu_About.Text = "About...";
            this.SysTrayIconMenu_About.Click += new System.EventHandler(this.SysTrayIconMenu_About_Click);
            // 
            // SysTrayIconMenu_OnlineHelp
            // 
            this.SysTrayIconMenu_OnlineHelp.Name = "SysTrayIconMenu_OnlineHelp";
            this.SysTrayIconMenu_OnlineHelp.Size = new System.Drawing.Size(170, 22);
            this.SysTrayIconMenu_OnlineHelp.Text = "Online Help";
            this.SysTrayIconMenu_OnlineHelp.Click += new System.EventHandler(this.SysTrayIconMenu_OnlineHelp_Click);
            // 
            // SysTrayIconMenu_Options
            // 
            this.SysTrayIconMenu_Options.Name = "SysTrayIconMenu_Options";
            this.SysTrayIconMenu_Options.Size = new System.Drawing.Size(170, 22);
            this.SysTrayIconMenu_Options.Text = "Options...";
            this.SysTrayIconMenu_Options.Click += new System.EventHandler(this.SysTrayIconMenu_Options_Click);
            // 
            // SysTrayIconMenu_Exit
            // 
            this.SysTrayIconMenu_Exit.Name = "SysTrayIconMenu_Exit";
            this.SysTrayIconMenu_Exit.Size = new System.Drawing.Size(170, 22);
            this.SysTrayIconMenu_Exit.Text = "Exit";
            this.SysTrayIconMenu_Exit.Click += new System.EventHandler(this.SysTrayIconMenu_Exit_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_File,
            this.MenuStrip_Modules,
            this.MenuStrip_Help});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // MenuStrip_File
            // 
            this.MenuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Options,
            this.MenuStrip_Exit});
            this.MenuStrip_File.Name = "MenuStrip_File";
            this.MenuStrip_File.Size = new System.Drawing.Size(37, 20);
            this.MenuStrip_File.Text = "File";
            // 
            // MenuStrip_Options
            // 
            this.MenuStrip_Options.Name = "MenuStrip_Options";
            this.MenuStrip_Options.Size = new System.Drawing.Size(152, 22);
            this.MenuStrip_Options.Text = "Options...";
            this.MenuStrip_Options.Click += new System.EventHandler(this.MenuStrip_Options_Click);
            // 
            // MenuStrip_Exit
            // 
            this.MenuStrip_Exit.Name = "MenuStrip_Exit";
            this.MenuStrip_Exit.Size = new System.Drawing.Size(152, 22);
            this.MenuStrip_Exit.Text = "Exit";
            // 
            // MenuStrip_Modules
            // 
            this.MenuStrip_Modules.Name = "MenuStrip_Modules";
            this.MenuStrip_Modules.Size = new System.Drawing.Size(65, 20);
            this.MenuStrip_Modules.Text = "Modules";
            // 
            // MenuStrip_Help
            // 
            this.MenuStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_OnlineHelp,
            this.MenuStrip_HelpAbout});
            this.MenuStrip_Help.Name = "MenuStrip_Help";
            this.MenuStrip_Help.Size = new System.Drawing.Size(44, 20);
            this.MenuStrip_Help.Text = "Help";
            // 
            // MenuStrip_OnlineHelp
            // 
            this.MenuStrip_OnlineHelp.Name = "MenuStrip_OnlineHelp";
            this.MenuStrip_OnlineHelp.Size = new System.Drawing.Size(137, 22);
            this.MenuStrip_OnlineHelp.Text = "Online Help";
            this.MenuStrip_OnlineHelp.Click += new System.EventHandler(this.MenuStrip_OnlineHelp_Click);
            // 
            // MenuStrip_HelpAbout
            // 
            this.MenuStrip_HelpAbout.Name = "MenuStrip_HelpAbout";
            this.MenuStrip_HelpAbout.Size = new System.Drawing.Size(137, 22);
            this.MenuStrip_HelpAbout.Text = "About...";
            this.MenuStrip_HelpAbout.Click += new System.EventHandler(this.MenuStrip_HelpAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Electrolyte";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.SysTrayIconMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SysTrayIcon;
        private System.Windows.Forms.ContextMenuStrip SysTrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem SysTrayIconMenu_Open;
        private System.Windows.Forms.ToolStripSeparator SysTrayIconMenu_Separator1;
        private System.Windows.Forms.ToolStripMenuItem SysTrayIconMenu_Exit;
        private System.Windows.Forms.ToolStripSeparator SysTrayIconMenu_Separator2;
        private System.Windows.Forms.ToolStripMenuItem SysTrayIconMenu_About;
        private System.Windows.Forms.ToolStripMenuItem SysTrayIconMenu_OnlineHelp;
        private System.Windows.Forms.ToolStripMenuItem SysTrayIconMenu_Options;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_File;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Modules;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_OnlineHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_HelpAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Options;
    }
}

