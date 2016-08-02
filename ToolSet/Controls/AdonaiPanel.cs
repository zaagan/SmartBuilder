using System.Drawing;
using System.Windows.Forms;

namespace SmartBuilder.ToolSet.Controls
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class AdonaiPanel : Panel
    {
        public AdonaiPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen myPen = new Pen(new SolidBrush(Color.FromArgb(68, 68, 68)), 0.5f);
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(myPen, 3, 3, ClientSize.Width - 6, ClientSize.Height - 6);

        }

    }



}
