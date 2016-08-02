using SmartBuilder.ToolSet.Utilities;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartBuilder.ToolSet.Controls
{
    public partial class UtilityContainer : UserControl
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

        Label oldTextContainer;
        public UtilityContainer()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            LoadMenu();
            ReloadStage(MenuItems.GetItems().First());
        }


        private void LoadMenu()
        {

            List<KeyValuePair<int, string>> lstItems = MenuItems.GetItems();

            foreach (var item in lstItems)
            {
                AdonaiDynamiteButton dynamix = new AdonaiDynamiteButton(item, ReloadStage);
                flpMenu.Controls.Add(dynamix);

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        { GraphicsManager.DrawLineInHeader(spcPlayGround.Panel1, Color.LightGray, 1); }


        public void ReloadStage(object sender)
        {
            
            var item = (KeyValuePair<int, string>)sender;

            if (lblHeader.Text == item.Value) return;
            oldTextContainer = new Label();
            TransitionManager.TextTransition_StaticColor(item.Value, item.Value, lblHeader, oldTextContainer);

            Control controlToAdd = null;
            switch (item.Key)
            {
                case 1:
                    controlToAdd = new SQLFormatter();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

            if (controlToAdd != null)
            {
                controlToAdd.Dock = DockStyle.Fill;
                spcPlayGround.Panel2.Controls.Clear();
                spcPlayGround.Panel2.Controls.Add(controlToAdd);
            }
        }

    }
}
