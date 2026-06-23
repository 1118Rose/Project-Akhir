using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_Akhir
{
    public static class UIHelper
    {
        public static void RoundPanel(Panel panel, int radius = 15)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }
    }
}
