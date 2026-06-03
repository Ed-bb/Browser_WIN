namespace Browser_WIN.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            webView2_Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            tabsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            textBoxURL = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripButtonBack = new ToolStripButton();
            toolStripButtonForward = new ToolStripButton();
            toolStripTextBoxUrl = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripButtonGo = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)webView2_Main).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView2_Main
            // 
            webView2_Main.AllowExternalDrop = true;
            webView2_Main.CreationProperties = null;
            webView2_Main.DefaultBackgroundColor = Color.White;
            webView2_Main.Dock = DockStyle.Fill;
            webView2_Main.Location = new Point(0, 82);
            webView2_Main.Name = "webView2_Main";
            webView2_Main.Size = new Size(860, 413);
            webView2_Main.TabIndex = 0;
            webView2_Main.ZoomFactor = 1D;
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, settingsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(145, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(145, 26);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(145, 26);
            closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tabsToolStripMenuItem, viewToolStripMenuItem1 });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // tabsToolStripMenuItem
            // 
            tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            tabsToolStripMenuItem.Size = new Size(124, 26);
            tabsToolStripMenuItem.Text = "Tabs";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(124, 26);
            viewToolStripMenuItem1.Text = "View";
            // 
            // textBoxURL
            // 
            textBoxURL.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxURL.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxURL.Dock = DockStyle.Top;
            textBoxURL.Location = new Point(0, 28);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.PlaceholderText = "httpt://";
            textBoxURL.Size = new Size(860, 27);
            textBoxURL.TabIndex = 2;
            textBoxURL.KeyDown += textBoxURL_KeyDown;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonBack, toolStripButtonForward, toolStripTextBoxUrl, toolStripSeparator1, toolStripProgressBar1, toolStripButtonGo });
            toolStrip1.Location = new Point(0, 55);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(860, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            toolStripButtonBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonBack.Image = (Image)resources.GetObject("toolStripButtonBack.Image");
            toolStripButtonBack.ImageTransparentColor = Color.Magenta;
            toolStripButtonBack.Name = "toolStripButtonBack";
            toolStripButtonBack.Size = new Size(44, 24);
            toolStripButtonBack.Text = "Back";
            toolStripButtonBack.Click += toolStripButtonBack_Click;
            // 
            // toolStripButtonForward
            // 
            toolStripButtonForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonForward.Image = (Image)resources.GetObject("toolStripButtonForward.Image");
            toolStripButtonForward.ImageTransparentColor = Color.Magenta;
            toolStripButtonForward.Name = "toolStripButtonForward";
            toolStripButtonForward.Size = new Size(67, 24);
            toolStripButtonForward.Text = "Forward";
            toolStripButtonForward.Click += toolStripButtonForward_Click;
            // 
            // toolStripTextBoxUrl
            // 
            toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            toolStripTextBoxUrl.Size = new Size(100, 27);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 24);
            // 
            // toolStripButtonGo
            // 
            toolStripButtonGo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonGo.Image = (Image)resources.GetObject("toolStripButtonGo.Image");
            toolStripButtonGo.ImageTransparentColor = Color.Magenta;
            toolStripButtonGo.Name = "toolStripButtonGo";
            toolStripButtonGo.Size = new Size(32, 24);
            toolStripButtonGo.Text = "Go";
            toolStripButtonGo.Click += toolStripButtonGo_Click;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 495);
            Controls.Add(webView2_Main);
            Controls.Add(toolStrip1);
            Controls.Add(textBoxURL);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BrowserForm";
            Text = "Browser.Win";
            FormClosing += BrowserForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)webView2_Main).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2_Main;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private TextBox textBoxURL;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonBack;
        private ToolStripButton toolStripButtonForward;
        private ToolStripTextBox toolStripTextBoxUrl;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripButton toolStripButtonGo;
        private ToolStripMenuItem tabsToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
    }
}
