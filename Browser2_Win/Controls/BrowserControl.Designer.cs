namespace Browser2_Win.Controls
{
    partial class BrowserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserControl));
            webView2_Main = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            toolStripButtonBack = new ToolStripButton();
            toolStripButtonForward = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonGo = new ToolStripButton();
            textBoxURL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView2_Main).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView2_Main
            // 
            webView2_Main.AllowExternalDrop = true;
            webView2_Main.CreationProperties = null;
            webView2_Main.DefaultBackgroundColor = Color.White;
            webView2_Main.Dock = DockStyle.Fill;
            webView2_Main.Location = new Point(0, 54);
            webView2_Main.Name = "webView2_Main";
            webView2_Main.Size = new Size(755, 466);
            webView2_Main.TabIndex = 4;
            webView2_Main.ZoomFactor = 1D;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonBack, toolStripButtonForward, toolStripSeparator1, toolStripButtonGo });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(755, 27);
            toolStrip1.TabIndex = 6;
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
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
            // textBoxURL
            // 
            textBoxURL.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxURL.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxURL.BorderStyle = BorderStyle.FixedSingle;
            textBoxURL.Dock = DockStyle.Top;
            textBoxURL.Location = new Point(0, 0);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.PlaceholderText = "httpt://";
            textBoxURL.Size = new Size(755, 27);
            textBoxURL.TabIndex = 5;
            textBoxURL.KeyDown += textBoxURL_KeyDown;
            // 
            // BrowserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(webView2_Main);
            Controls.Add(toolStrip1);
            Controls.Add(textBoxURL);
            Name = "BrowserControl";
            Size = new Size(755, 520);
            ((System.ComponentModel.ISupportInitialize)webView2_Main).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2_Main;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonBack;
        private ToolStripButton toolStripButtonForward;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonGo;
        private TextBox textBoxURL;
    }
}
