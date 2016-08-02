using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartBuilder.ToolSet.Controls
{
    public partial class AdonaiDynamiteButton : UserControl
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

        Action<object> Reload;
        KeyValuePair<int, string> itemInfo;
        public AdonaiDynamiteButton(KeyValuePair<int, string> itemInfo, Action<object> Reload)
        {
            InitializeComponent();
            this.itemInfo = itemInfo;
            this.Reload = Reload;

            lblHeaderName.Text = itemInfo.Value;
        }


        private void adonaiPanel1_MouseHover(object sender, EventArgs e)
        { this.Focus(); }


        private void adonaiPanel1_MouseLeave(object sender, EventArgs e)
        { }

        private void lblHeaderName_Click(object sender, EventArgs e)
        {
            Reload(itemInfo);
            //Control controlToAdd = null;
            //string formTitle = lblHeaderName.Text;
            //switch (_objItemInfo.Key)
            //{
            //    case 1:
            //        if (controlToAdd == null)
            //            controlToAdd = new Code_Comparer();
            //        break;

            //    case 2:
            //        if (controlToAdd == null)
            //            controlToAdd = new GetterSetter();
            //        break;

            //    case 3:
            //        if (controlToAdd == null)
            //            controlToAdd = new ColorStyler();
            //        break;

            //    case 4:
            //        if (controlToAdd == null)
            //            controlToAdd = new YoutubeDownloaderControl();
            //        break;

            //    case 10:
            //        if (controlToAdd == null)
            //            controlToAdd = new NetworkController();
            //        break;

            //    default:
            //        MessageManager.GenerateRandomMessage(RandomMessageTypes.Unimplemeted);
            //        break;
            //}


            //if (controlToAdd != null)
            //{
            //    SummonedFormXCool summonedForm = new SummonedFormXCool();
            //    summonedForm.LoadContainer(controlToAdd);
            //    summonedForm.Text = formTitle;
            //    summonedForm.TitleBar.TitleBarCaption = formTitle;
            //    summonedForm.Show();

            //}
        }



    }
}
