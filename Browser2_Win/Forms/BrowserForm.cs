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
        }

        #endregion Public Constructors

        #region Private Methods

        private void AddNewBrowserTab()
        {
            tabControlBrowsers.TabPages.Add(new TabPage("New Tab") { Controls = { new Controls.BrowserControl() { Dock = DockStyle.Fill } } });
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

                //tabControlBrowsers.TabPages.Remove((TabPage)tabControlBrowsers.GetChildAtPoint(e.Location));
                //tabControlBrowsers.TabPages.Cast<TabPage>().Where(x => x.ClientRectangle.Contains(e.Location)).FirstOrDefault()?.Dispose();
                //tabControlBrowsers.TabPages.RemoveAt(tabControlBrowsers.SelectedIndex);
                //.AsQueryable().Where(x => x.Bounds.Contains(e.Location)).;

                var cm = new ContextMenuStrip();
                cm.Items.Add(text: "Add Tab", onClick: new EventHandler(ContextMenuItemAddTab_Click), image: null);
                cm.Items.Add(text: "Remove Tab", onClick: new EventHandler(ContextMenuItemRemoveTab_Click), image: null);
                tabControlBrowsers.ContextMenuStrip = cm;
                cm.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
            }
        }

        private void ContextMenuItemRemoveTab_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ContextMenuItemAddTab_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion Private Methods
    }
}