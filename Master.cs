using SmartBuilder.ToolSet.Controls;
using SmartBuilder.ToolSet.Utilities;
using System;
using System.Windows.Forms;

namespace SmartBuilder
{
    public partial class Master : Form
    {

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        public Master()
        {
            InitializeComponent();
            Properties.Settings settings = SmartBuilder.Properties.Settings.Default;
            ctrlFastNote.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            LoadSideMenu();
            contentSwiper.btnTransit.Click += btnTransit_Click;
        }

        private void LoadSideMenu()
        {
            pnlLeftContainer.Controls.Clear();
            var sideControl = new UtilityContainer();
            sideControl.Dock = DockStyle.Fill;
            pnlLeftContainer.Controls.Add(sideControl);
        }
        public void btnTransit_Click(object sender, EventArgs e)
        {  TransitionManager.RelocateControls_RtoLtoR(ctrlFastNote, pnlLeftContainer);}


    }
}
