using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartBuilder.Controls
{
    public partial class TileController : UserControl
    {

        [Category("Adonai")]
        [Description("Represents the Visible Title")]
        public string AdonaiShownTitle
        {
            get { return titleControl1.AdonaiShownTitle; }
            set { titleControl1.AdonaiShownTitle = value; }
        }


        [Category("Adonai")]
        [Description("Represents the Hidden Title")]
        public string AdonaiHiddenTitle
        {
            get { return titleControl1.AdonaiHiddenTitle; }
            set { titleControl1.AdonaiHiddenTitle = value; }
        }



        [Category("Adonai")]
        [Description("Represents the Icon Type")]
        public FontAwesomeIcons.IconType IconType
        {
            get { return btnTransit.IconType; }
            set { btnTransit.IconType = value; }
        }

        [Category("Adonai")]
        [Description("Represents the InActive Color")]
        public Color InactiveColor
        {
            get { return btnTransit.InActiveColor; }
            set { btnTransit.InActiveColor = value; }
        }

        [Category("Adonai")]
        [Description("Represents the Active Color")]
        public Color ActiveColor
        {
            get { return btnTransit.ActiveColor; }
            set { btnTransit.ActiveColor = value; }
        }

        [Category("Adonai")]
        [Description("Represents the Back Color")]
        public Color BackColor
        {
            get { return btnTransit.BackColor; }
            set { btnTransit.BackColor = value; }
        }

        public TileController()
        {
            InitializeComponent();
        }

        public void btnTransit_Click(object sender, EventArgs e)
        { titleControl1.RelocateControl(); }




    }
}
