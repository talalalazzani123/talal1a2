using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace واجب_11_برمجة_مرئية
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().DrawLine(Pens.Red, new Point(125, 100), new Point(150, 150));
            panel1.CreateGraphics().DrawLine(Pens.Black, new Point(150, 150), new Point(100, 150));
            panel1.CreateGraphics().DrawLine(Pens.Blue, new Point(100, 125), new Point(125, 150));
            panel1.CreateGraphics().DrawLine(Pens.Green, new Point(125, 100), new Point(125, 150));

            panel1.CreateGraphics().DrawLines(Pens.Blue, new Point[] { new Point(100 + 50, 100 + 50), new Point(300 + 50, 100 + 50), new Point(200 + 50, 300 + 50), new Point(100 + 50, 100 + 50), });

        }
    }
}
