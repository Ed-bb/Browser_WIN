using Microsoft.Web.WebView2.Core;

namespace Browser_WIN.Forms
{
    public partial class BrowserForm : Form
    {
        #region Public Constructors

        public BrowserForm()
        {
            InitializeComponent();
            menuStrip1.Visible = false;
            toolStripProgressBar1.Visible = false;
            toolStripTextBoxUrl.Visible = false;
            webView2_Main.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            webView2_Main.EnsureCoreWebView2Async(null);
            this.Icon = Properties.Resources.BrowserIcon_V1;
        }

        #endregion Public Constructors

        #region Private Methods

        private static Uri GetCleanUrl(string urlString)
        {
            var rawUrl = urlString;
            Uri uri = null;

            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                uri = new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                // An invalid URI contains a dot and no spaces, try tacking http:// on the front.
                uri = new Uri("http://" + rawUrl);
            }
            else
            {
                // Otherwise treat it as a web search.
                uri = new Uri("https://google.com/search?q=" +
                    String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
            }

            return uri;
        }

        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            // Update the TextBox with the new URL
            textBoxURL.Text = webView2_Main.Source.ToString();
        }

        private void LoadPage()
        {
            Uri uri = GetCleanUrl(textBoxURL.Text);

            webView2_Main.Source = uri;
        }

        private void textBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadPage();
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            if (webView2_Main.CanGoBack)
            {
                webView2_Main.GoBack();
            }
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            if (webView2_Main.CanGoForward)
            {
                webView2_Main.GoForward();
            }
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, EventArgs e)
        {
            // SourceChanged fires as soon as the URL changes
            webView2_Main.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
        }

        #endregion Private Methods

        private void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}