using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModels;
using BeginnersMode;

namespace BeginnersMode
{
    public partial class BeginnersMode : Form
    {
        public BeginnersMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var RCPLL = new BeginnersMode();
            RCPLL.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "A(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "A(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "U(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "U(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "J(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "J(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "R(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "R(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(c)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(d)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "N(a)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "N(b)");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "H");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "Z");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "T");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "Y");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "E");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "V");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "F");

            textBox1.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
