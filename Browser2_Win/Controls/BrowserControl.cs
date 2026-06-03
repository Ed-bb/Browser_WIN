using BrowserLib_Standard.Utilities;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Browser2_Win.Controls
{
    public partial class BrowserControl : UserControl
    {
        #region Public Constructors

        public BrowserControl()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
            webView2_Main.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            webView2_Main.EnsureCoreWebView2Async(null);
        }

        public BrowserControl(EventHandler<CoreWebView2SourceChangedEventArgs> sourceChangedHandler)
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
            webView2_Main.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            webView2_Main.EnsureCoreWebView2Async();
            SourceChanged += sourceChangedHandler;
        }

        public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
        {
            add
            {
                if (value is not null)
                {
                    webView2_Main.SourceChanged += value;
                }
            }

            remove
            {
                webView2_Main.SourceChanged -= value;
            }
        }

    //    private readonly List<EventHandler<CoreWebView2SourceChangedEventArgs>> _pendingSourceChangedHandlers
    //= new List<EventHandler<CoreWebView2SourceChangedEventArgs>>();

        //public event EventHandler<CoreWebView2SourceChangedEventArgs> SourceChanged
        //{
        //    add
        //    {
        //        if (value is null) return;
        //        var core = webView2_Main.CoreWebView2;
        //        webView2_Main.SourceChanged += value;
        //        if (core is not null)
        //        {
        //            core.SourceChanged += value;
        //        }
        //        else
        //        {
        //            lock (_pendingSourceChangedHandlers)
        //            {
        //                _pendingSourceChangedHandlers.Add(value);
        //            }
        //        }
        //    }
        //    remove
        //    {
        //        if (value is null) return;
        //        var core = webView2_Main.CoreWebView2;
        //        if (core is not null)
        //        {
        //            core.SourceChanged -= value;
        //        }
        //        else
        //        {
        //            lock (_pendingSourceChangedHandlers)
        //            {
        //                _pendingSourceChangedHandlers.Remove(value);
        //            }
        //        }
        //    }
        //}

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Uri browserUrl
        {
            get => webView2_Main.Source;
            set => webView2_Main.Source = value;
        }

        #endregion Public Constructors

        #region Private Methods

        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            // Update the TextBox with the new URL
            textBoxURL.Text = webView2_Main.Source.ToString();
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, EventArgs e)
        {
            // SourceChanged fires as soon as the URL changes
            webView2_Main.SourceChanged += CoreWebView2_SourceChanged;

            //var core = webView2_Main.CoreWebView2;
            //if (core is null) return;
            //lock (_pendingSourceChangedHandlers)
            //{
            //    foreach (var h in _pendingSourceChangedHandlers)
            //    {
            //        core.SourceChanged += h;
            //    }
            //    _pendingSourceChangedHandlers.Clear();
            //}
        }

        private void LoadPage()
        {
            Uri uri = BrowserHelpers.GetCleanUrl(textBoxURL.Text);

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

        #endregion Private Methods
    }
}