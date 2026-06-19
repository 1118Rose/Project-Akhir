using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_Akhir.Helpers
{
    public class UIHelper
    {
        public static void RoundPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.StartFigure();

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(panel.Width - diameter, 0, diameter, diameter, 270, 90);
            path.AddArc(panel.Width - diameter, panel.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(0, panel.Height - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
