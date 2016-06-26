using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartBuilder
{
    [ToolboxBitmap(typeof(Label))]
    public partial class AdonaiLabel : Label, IAdonaiComponent
    {
        public void ResetTheme()
        {
            this.BackColor = AdonaiThemeManager.TabControl.MainTheme(mainThemeStyle);
            this.ForeColor = AdonaiThemeManager.TabControl.FontForeColor(secondaryTheme);
            this.Invalidate();
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                if (base.Font != value)
                    base.Font = value;
            }
        }


        public AdonaiLabel()
        {
            InitializeComponent(); ResetTheme();
            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
        }



        private MainThemeStyle mainThemeStyle = MainThemeStyle.Default;
        [Browsable(true)]
        [Description("Set the Active Main Theme")]
        [Category(AdonaiThemeDefault.PropertyCategory.Appearance)]
        [DefaultValue(MainThemeStyle.Default)]
        public MainThemeStyle MainTheme
        {
            get
            {
                if (mainThemeStyle == MainThemeStyle.Default)
                { return AdonaiThemeDefault.DefaultMainThemeStyle; }

                return mainThemeStyle;
            }
            set
            {
                if (value != mainThemeStyle)
                { mainThemeStyle = value; }
                ResetTheme();
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }


        private SecondaryThemeStyle secondaryTheme = SecondaryThemeStyle.Default;
        [Description("Set the Active Secondary Theme")]
        [Category(AdonaiThemeDefault.PropertyCategory.Appearance)]
        [DefaultValue(SecondaryThemeStyle.Default)]
        public SecondaryThemeStyle SecondaryTheme
        {
            get
            {
                if (secondaryTheme == SecondaryThemeStyle.Default)
                {
                    return AdonaiThemeDefault.DefaultSecondaryStyle;
                }
                return secondaryTheme;
            }
            set
            {
                if (value != secondaryTheme)
                { secondaryTheme = value; }
                ResetTheme();
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }
    }
}
