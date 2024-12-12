using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace واجب_11_برمجة_مرئية
{
    internal class circalButton:Button
    {
        public circalButton()
        {
            this.Text = "A";

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, Width - 1, Height - 1);
            GraphicsPath g= new GraphicsPath();
            g.AddEllipse(0, 0, Width - 1, Height - 1);
            Region=new Region(g);
        }

    }
}
