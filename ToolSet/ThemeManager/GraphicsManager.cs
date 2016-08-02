
using System.Drawing;
using System.Windows.Forms;

namespace SmartBuilder
{
    class GraphicsManager
    {
        public static void DrawLine(Control frm, Color color, int x, int y, int x1, int y1, int thickness)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = frm.CreateGraphics();
            Pen myPen = new Pen(color, thickness);
            graphicsObj.DrawLine(myPen, x, y, x1, y1);
        }

        public static void DrawLineInHeader(Control control,Color color,int thickness)
        {
            int y = control.Height;
            GraphicsManager.DrawLine(control, color, 0, 0, control.Width, 0, thickness);
        }

        public static void DrawLineInFooter(Control control,Color color,int thickness)
        {
            int y = control.Height;
            GraphicsManager.DrawLine(control, color, 0, y, control.Width, y, thickness);
        }

    }
}
