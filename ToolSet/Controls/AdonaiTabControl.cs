using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartBuilder
{
    public class AdonaiTabControl : TabControl, IExtenderProvider, IAdonaiComponent
    {
        #region Fields

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
                {
                    return AdonaiThemeDefault.DefaultMainThemeStyle;
                }
                return mainThemeStyle;
            }
            set
            {
                if (value != mainThemeStyle)
                { mainThemeStyle = value; }
                ResetTheme();
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
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }


        Color activeColor;
        [Browsable(true)]
        [Description("Set the Active Tabs BackColor")]
        [Category(AdonaiThemeDefault.PropertyCategory.Appearance)]
        public Color ActiveColor
        {
            get
            {
                if (activeColor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Color.White;
                    else
                        return activeColor;
                }
                return activeColor;
            }
            set
            {
                if (activeColor.Equals(value)) return;
                activeColor = value;
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }


        Color hoverColor;
        [Browsable(true)]
        [Description("Set the Tabs HoverColor")]
        [Category(AdonaiThemeDefault.PropertyCategory.Appearance)]
        public Color HoverColor
        {
            get
            {
                if (hoverColor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Color.FromArgb(20, 153, 126);
                    else
                        return hoverColor;
                }
                return hoverColor;
            }
            set
            {
                if (hoverColor.Equals(value)) return;
                hoverColor = value;
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }


        Color backColor;
        [Browsable(true)]
        [Description("Set the Tabs BackColor")]
        [Category(AdonaiThemeDefault.PropertyCategory.Appearance)]
        public override Color BackColor
        {
            get
            {
                if (backColor.Equals(Color.Empty))
                {
                    if (Parent == null)
                        return Control.DefaultBackColor;
                    else
                        return Color.White;
                }
                return backColor;
            }
            set
            {
                if (backColor.Equals(value)) return;
                backColor = value;
                Invalidate();
                base.OnBackColorChanged(EventArgs.Empty);
            }
        }

        public void ResetTheme()
        {
            backColor = AdonaiThemeManager.TabControl.SecondaryTheme(secondaryTheme);
            hoverColor = AdonaiThemeManager.TabControl.HoverTheme(secondaryTheme);
            this.Invalidate();

        }



        private int _hotTabIndex = -1;
        private int HotTabIndex
        {
            get { return _hotTabIndex; }
            set
            {
                if (_hotTabIndex != value)
                {
                    _hotTabIndex = value;
                    this.Invalidate();
                }
            }
        }

        #endregion

        public AdonaiTabControl()
            : base()
        {

            activeColor = AdonaiThemeColor.White;
            ResetTheme();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

        }


        #region Overridden Methods
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.OnFontChanged(EventArgs.Empty);
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            IntPtr hFont = this.Font.ToHfont();
            SendMessage(this.Handle, WM_SETFONT, hFont, new IntPtr(-1));
            SendMessage(this.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero);
            this.UpdateStyles();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            TCHITTESTINFO HTI = new TCHITTESTINFO(e.X, e.Y);
            HotTabIndex = SendMessage(this.Handle, TCM_HITTEST, IntPtr.Zero, ref HTI);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            HotTabIndex = -1;
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);

            for (int id = 0; id < this.TabCount; id++)
                DrawTabBackground(pevent.Graphics, id);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int id = 0; id < this.TabCount; id++)
                DrawTabContent(e.Graphics, id);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == TCM_SETPADDING)
                m.LParam = MAKELPARAM(this.Padding.X + FontHeight / 2, this.Padding.Y);

            base.WndProc(ref m);
        }
        #endregion Overridden Methods

        #region Private Methods

        private IntPtr MAKELPARAM(int lo, int hi)
        { return new IntPtr((hi << 16) | (lo & 0xFFFF)); }

        private void DrawTabBackground(Graphics graphics, int id)
        {
            Rectangle activeRectangle = GetTabRect(id);
            Rectangle selectedRectangle = new Rectangle(activeRectangle.X - 2, activeRectangle.Y - 2, activeRectangle.Width + 4, activeRectangle.Height + 4);

            if (id == SelectedIndex)
            {
                graphics.FillRectangle(new SolidBrush(activeColor), selectedRectangle);
            }
            else if (id == HotTabIndex)
            {
                //Tab Header OuterRectangle BackColor
                graphics.FillRectangle(new SolidBrush(hoverColor), selectedRectangle);
                //Uncomment to draw 1px border around
                //  rc.Width--;
                //  rc.Height--;

                //Tab Header OuterRectangle BorderColor
                graphics.DrawRectangle(new Pen(hoverColor), activeRectangle);
            }
        }

        private void DrawTabContent(Graphics graphics, int id)
        {
            bool selectedOrHot = id == this.SelectedIndex || id == this.HotTabIndex;
            bool vertical = this.Alignment >= TabAlignment.Left;

            Rectangle tabRect = GetTabRect(id);
            Rectangle contentRect = vertical ? new Rectangle(0, 0, tabRect.Height, tabRect.Width) : new Rectangle(Point.Empty, tabRect.Size);

            Rectangle textrect = contentRect;

            Color frColor = id == SelectedIndex ? Color.FromArgb(67, 66, 65) : activeColor;
            Color bkColor = id == SelectedIndex ? activeColor : this.BackColor;

            //TabHeader Inner Rectangle BackColor
            if (id == HotTabIndex && id != SelectedIndex)
            { bkColor = hoverColor; }


            using (Bitmap bm = new Bitmap(contentRect.Width, contentRect.Height))
            {
                using (Graphics bmGraphics = Graphics.FromImage(bm))
                {
                    TextRenderer.DrawText(bmGraphics, this.TabPages[id].Text, new Font("Segoe UI Symbol", 11.0F, FontStyle.Regular), textrect, frColor, bkColor);
                }

                if (vertical)
                {
                    if (this.Alignment == TabAlignment.Left)
                        bm.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    else
                        bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                graphics.DrawImage(bm, tabRect);

            }
        }

        #endregion



        #region Interop

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, IntPtr wParam, ref TCHITTESTINFO lParam);

        [StructLayout(LayoutKind.Sequential)]
        private struct TCHITTESTINFO
        {
            public Point pt;
            public TCHITTESTFLAGS flags;
            public TCHITTESTINFO(int x, int y)
            {
                pt = new Point(x, y);
                flags = TCHITTESTFLAGS.TCHT_NOWHERE;
            }
        }

        [Flags()]
        private enum TCHITTESTFLAGS
        {
            TCHT_NOWHERE = 1,
            TCHT_ONITEMICON = 2,
            TCHT_ONITEMLABEL = 4,
            TCHT_ONITEM = TCHT_ONITEMICON | TCHT_ONITEMLABEL
        }

        private const int WM_NULL = 0x0;
        private const int WM_SETFONT = 0x30;
        private const int WM_FONTCHANGE = 0x1D;
        private const int WM_MOUSEDOWN = 0x201;

        private const int TCM_FIRST = 0x1300;

        private const int TCM_HITTEST = TCM_FIRST + 13;
        private const int TCM_SETPADDING = TCM_FIRST + 43;

        private const Int32 TCM_ADJUSTRECT = (TCM_FIRST + 40);

        #endregion


        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ItemSize = new Size(0, 30);
            this.SizeMode = TabSizeMode.FillToRight;
            this.ResumeLayout(false);
        }


        public bool CanExtend(object extendee)
        {
            return extendee is Control && !(extendee is IAdonaiComponent);
        }



    }
}
