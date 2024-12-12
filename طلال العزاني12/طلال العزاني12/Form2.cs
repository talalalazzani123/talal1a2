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
    public partial class Form2 : Form
    {
        TextBox[,] twoDarrTextbox;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += numoric;
            textBox2.KeyPress += numoric;
            this.AutoSize = true;
            this.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.AutoScroll= true;
        }
        private void numoric(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
                e.Handled = false;
        }
        int row = 0, col = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                if (twoDarrTextbox != null)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col;)
                        {
                            twoDarrTextbox[i, j].Dispose();
                        }
                    }
                }
                row = Convert.ToInt32(textBox1.Text);
                col = Convert.ToInt32(textBox2.Text);
                twoDarrTextbox = new TextBox[row, col];
                /////////
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col;)
                    {
                        twoDarrTextbox[i, j] = new TextBox();
                        twoDarrTextbox[i, j].Size = new Size(30, 30);
                        twoDarrTextbox[i, j].Multiline = true;
                        twoDarrTextbox[i, j].Top = i * twoDarrTextbox[i, j].Height;
                        twoDarrTextbox[i, j].Left = j * twoDarrTextbox[i, j].Width;

                        twoDarrTextbox[i, j].KeyPress += oneonly;

                        panel1.Controls.Add(twoDarrTextbox[i, j]);
                    }
                }
            }
            else
                MessageBox.Show("الرجاء تحديد عدد الصفوف والاعمده");
        }
        private void oneonly(object sender, KeyPressEventArgs e)
        {
            TextBox t=new TextBox();
            bool flag = false;
            for(int i = 0; i < row;i++)
            {
                for(int j = 0; j < col;j++)
                {
                    if (((TextBox)sender) == twoDarrTextbox[i,j])
                    {
                        t=((TextBox)sender);
                        flag = true;
                        break;
                    }
                    if(flag)
                    {
                        break;
                    }
                }

            }
            if((e.KeyChar!='1')&&(e.KeyChar!=8)||(t.TextLength>0))
                e.Handled = true;

        }
    }
}
