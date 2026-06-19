using System.Windows.Forms;

namespace Project_Akhir.Helpers
{
    public class FormResizer
    {
        private Size formOriginalSize;

        public void SaveInitialSize(Form form)
        {
            formOriginalSize = form.Size;
        }

        public void ResizeControls(Form form)
        {
            float xRatio = (float)form.Width / formOriginalSize.Width;
            float yRatio = (float)form.Height / formOriginalSize.Height;

            ResizeControl(form.Controls, xRatio, yRatio);
        }

        private void ResizeControl(Control.ControlCollection controls,
                                   float xRatio,
                                   float yRatio)
        {
            foreach (Control c in controls)
            {
                c.Left = (int)(c.Left * xRatio);
                c.Top = (int)(c.Top * yRatio);
                c.Width = (int)(c.Width * xRatio);
                c.Height = (int)(c.Height * yRatio);

                c.Font = new Font(
                    c.Font.FontFamily,
                    c.Font.Size * Math.Min(xRatio, yRatio),
                    c.Font.Style);

                if (c.Controls.Count > 0)
                    ResizeControl(c.Controls, xRatio, yRatio);
            }
        }
    }
}
