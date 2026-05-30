namespace Browser_WIN
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private Uri GetCleanUrl()
        {
            var rawUrl = textBoxURL.Text;
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


        private void LoadPage()
        {
            Uri uri = GetCleanUrl();

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

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            if (webView2_Main.CanGoForward)
            {
                webView2_Main.GoForward();
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            if (webView2_Main.CanGoBack)
            {
                webView2_Main.GoBack();
            }
        }
    }
}
