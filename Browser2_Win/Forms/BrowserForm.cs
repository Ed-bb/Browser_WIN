using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Linq;

namespace Browser2_Win.Forms
{
    public partial class BrowserForm : Form
    {
        #region Public Constructors

        public BrowserForm()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            browserControl1.SourceChanged += BrowserControlTab_SourceChanged;
            // set darkmode if the system is in dark mode
            //if (BrowserLib_Standard.Utilities.SystemThemeHelper.IsSystemInDarkMode())
            //{
            //    var webView2Settings = browserControl1.CoreWebView2.Settings;
            //    webView2Settings.AreDefaultContextMenusEnabled = false;
            //    webView2Settings.AreDevToolsEnabled = false;
            //    webView2Settings.AreDefaultScriptDialogsEnabled = false;
            //    webView2Settings.IsStatusBarEnabled = false;
            //    webView2Settings.IsZoomControlEnabled = false;
            //    webView2Settings.IsBuiltInErrorPageEnabled = false;
            //    webView2Settings.UserAgent += " Browser2_Win_DarkMode";
            //}
        }

        #endregion Public Constructors

        #region Private Methods

        private void AddNewBrowserTab()
        {
            var browserControl = new Controls.BrowserControl();

            var newTab = new TabPage("New Tab")
            {
                Margin = new Padding(0),
                Controls =
                {
                    browserControl
                }
            };

            browserControl.Dock = DockStyle.Fill;
            browserControl.SourceChanged += BrowserControlTab_SourceChanged;

            tabControlBrowsers.TabPages.Add(newTab);
            tabControlBrowsers.SelectedTab = newTab;
        }

        private void BrowserControlTab_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            var browser = (WebView2)sender;
            string docTitle = string.IsNullOrWhiteSpace(browser.CoreWebView2.DocumentTitle) ? browser.Source.Host : browser.CoreWebView2.DocumentTitle;
            ((TabPage)browser.Parent.Parent).Text = docTitle.Length > 10 ? docTitle.Substring(0, 10) + "..." : docTitle;
            ((TabPage)browser.Parent.Parent).ToolTipText = docTitle;
        }

        private void ContextMenuItemAddTab_Click(object sender, EventArgs e)
        {
            AddNewBrowserTab();
        }

        private void tabControlBrowsers_DoubleClick(object sender, EventArgs e)
        {
            AddNewBrowserTab();
        }

        private void tabControlBrowsers_MouseDown(object sender, MouseEventArgs e)
        {
            var test = new List<object>();
            if (e.Button == MouseButtons.Right)
            {
                var cm = new ContextMenuStrip();
                cm.Items.Add(text: "Add Tab", onClick: new EventHandler(ContextMenuItemAddTab_Click), image: null);
                //cm.Items.Add(text: "Remove Tab", onClick: new EventHandler(ContextMenuItemRemoveTab_Click), image: null);
                cm.Items.Add(text: "Remove Tab", onClick: (sender, e1) =>
                {
                    for (int i = 0; i < tabControlBrowsers.TabCount; i++)
                    {
                        // get their rectangle area and check if it contains the mouse cursor
                        Rectangle r = tabControlBrowsers.GetTabRect(i);
                        if (r.Contains(e.Location))
                        {
                            tabControlBrowsers.TabPages.RemoveAt(i);
                            // show the context menu here
                            //System.Diagnostics.Debug.WriteLine("TabPressed: " + i);
                        }
                    }
                }, image: null);
                tabControlBrowsers.ContextMenuStrip = cm;
                cm.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
            }
        }

        #endregion Private Methods
    }
}