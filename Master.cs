using System.Windows.Forms;

namespace SmartBuilder
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
            Properties.Settings settings = SmartBuilder.Properties.Settings.Default;
        }

    }
}
