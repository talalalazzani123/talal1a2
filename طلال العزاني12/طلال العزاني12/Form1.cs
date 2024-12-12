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
    public partial class Form1 : Form
    {
        TextBox[] oneDarrTextbox;//تعريف مصفوفة تكست بوكس
                                 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += numoric;

            this.AutoSize = true;
            this.AutoScroll = true;


        }
        private void numoric(object sender, KeyPressEventArgs e) 
        {
            if(e.KeyChar<48||e.KeyChar>57)
            {
                e.Handled = true;
            }
            if(e.KeyChar==8)
                e.Handled=false;

        }
        void normal()
        {
            oneDarrTextbox=new TextBox[Convert.ToInt32(textBox1.Text)];
            for(int i=0;i<oneDarrTextbox.Length;i++)
            {
                oneDarrTextbox[i]=new TextBox();
                oneDarrTextbox[i].Size = new Size(60, 20);
                oneDarrTextbox[i].Top = i * oneDarrTextbox[i].Height;
                oneDarrTextbox[i].Left = 10;

                //اضافتها مرئيا
                Controls.Add(oneDarrTextbox[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //normal
            if (textBox1.Text.Trim() != "")
            {
                if (oneDarrTextbox != null)
                {
                    for (int i = 0; i < oneDarrTextbox.Length; i++)
                    {
                        oneDarrTextbox[i].Dispose();
                    }

                }
                oneDarrTextbox = new TextBox[Convert.ToInt32(textBox1.Text)];
                for (int i = 0; i < oneDarrTextbox.Length; i++)
                {
                    oneDarrTextbox[i] = new TextBox();
                    oneDarrTextbox[i].Size = new Size(60, 20);

                    if (radioButton2.Checked)
                    {
                        oneDarrTextbox[i].Top = i * oneDarrTextbox[i].Height;
                        oneDarrTextbox[i].Left = 10;
                    }
                    else if (radioButton1.Checked)
                    {
                        oneDarrTextbox[i].Left = i * oneDarrTextbox[i].Width;
                        oneDarrTextbox[i].Top = 10;
                    }
                    Controls.Add(oneDarrTextbox[i]);
                }

            }
            else
                MessageBox.Show("الرجاء تحديد الطول");
        }
    }
}
