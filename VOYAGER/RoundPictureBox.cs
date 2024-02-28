using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOYAGER
{
    class RoundPicturech : PictureBox // Inheriting al pictureBox Components
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath(); // Any kind of Path in 2D Space
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height); //.AddEllipse is such a method that will make a ellipse with variable sizes that denotes by user
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pe);
        }
    }
}
