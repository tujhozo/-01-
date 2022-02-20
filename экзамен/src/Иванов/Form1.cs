using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();

            if (webBrowser1 != null)
            {

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                name = openFileDialog1.FileName;
                webBrowser1.Navigate(name);
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
           
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 2 задание
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            if ((y > -3 * x + 3) && ((x > 0) && (y > 3 || y < 6)) && ((x > 0 && y < 6) && (x < 6 && y > 0)) && ((y > 0) && (x > 3 || x < 6)))
            {
                toolStripStatusLabel1.Text = "Точка входит";
            }
            else if ((y == -3 * x + 3) || ((x == 0) && (y >= 3 || y <= 6)) || (y == -x + 6) || ((y == 0) && (x >= 3 || x <= 6)))
            {
                toolStripStatusLabel1.Text = "Точка на границе";
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
