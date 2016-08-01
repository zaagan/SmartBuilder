using System;
using System.ComponentModel;
using System.Windows.Forms;
using SmartBuilder.ToolSet.Utilities;

namespace SmartBuilder.Controls
{
    public partial class TitleControl : UserControl
    {


        [Category("Adonai")]
        [Description("Represents the Header`s Visible Title")]
        public string AdonaiShownTitle
        {
            get { return lblShown.Text; }
            set { lblShown.Text = value; }
        }

        [Category("Adonai")]
        [Description("Represents the Header`s Hidden Title")]
        public string AdonaiHiddenTitle
        {
            get { return lblHidden.Text; }
            set { lblHidden.Text = value; }
        }

        private Control m_ActivePicture = null;
        private Control m_InactivePicture = null;
        private Random m_Random = new Random();
        public TitleControl()
        {
            InitializeComponent();
            m_ActivePicture = pnlShown;
            m_InactivePicture = pnlHidden;
        }

        public void RelocateControl()
        { TransitionManager.RelocateControls_LtoRtoL(this.Width, pnlHidden, pnlShown); }
    }
}
