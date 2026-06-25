namespace Browser3_Win.Forms
{
    partial class BrowserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newTabToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            tabsToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            tabControlBrowsers = new TabControl();
            tabPage1 = new TabPage();
            browserControl1 = new Browser3_Win.Controls.BrowserControl();
            toolTipForm = new ToolTip(components);
            menuStrip1.SuspendLayout();
            tabControlBrowsers.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(860, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newTabToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newTabToolStripMenuItem
            // 
            newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            newTabToolStripMenuItem.Size = new Size(149, 26);
            newTabToolStripMenuItem.Text = "New Tab";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tabsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // tabsToolStripMenuItem
            // 
            tabsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onToolStripMenuItem });
            tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            tabsToolStripMenuItem.Size = new Size(121, 26);
            tabsToolStripMenuItem.Text = "Tabs";
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(111, 26);
            onToolStripMenuItem.Text = "On";
            // 
            // tabControlBrowsers
            // 
            tabControlBrowsers.Controls.Add(tabPage1);
            tabControlBrowsers.Dock = DockStyle.Fill;
            tabControlBrowsers.Location = new Point(0, 28);
            tabControlBrowsers.Name = "tabControlBrowsers";
            tabControlBrowsers.SelectedIndex = 0;
            tabControlBrowsers.Size = new Size(860, 467);
            tabControlBrowsers.TabIndex = 2;
            tabControlBrowsers.DoubleClick += tabControlBrowsers_DoubleClick;
            tabControlBrowsers.MouseDown += tabControlBrowsers_MouseDown;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(browserControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(852, 434);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Tab";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.DoubleClick += tabControlBrowsers_DoubleClick;
            // 
            // browserControl1
            // 
            browserControl1.Dock = DockStyle.Fill;
            browserControl1.Location = new Point(3, 3);
            browserControl1.Name = "browserControl1";
            browserControl1.Size = new Size(846, 428);
            browserControl1.TabIndex = 0;
            // 
            // toolTipForm
            // 
            toolTipForm.ShowAlways = true;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 495);
            Controls.Add(tabControlBrowsers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BrowserForm";
            Text = "Browser.Win";
            DoubleClick += tabControlBrowsers_DoubleClick;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlBrowsers.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem tabsToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private TabControl tabControlBrowsers;
        private TabPage tabPage1;
        private Browser3_Win.Controls.BrowserControl browserControl1;
        private ToolStripMenuItem newTabToolStripMenuItem;
        private ToolTip toolTipForm;
    }
}
