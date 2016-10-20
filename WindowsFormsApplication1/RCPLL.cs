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
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class RCPLL : Form
    {
        public RCPLL()
        {
            InitializeComponent();
        }

#region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
#endregion
        #region Algs
        //Use this one for format
        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "H");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);
            

            foreach (var a in p.Algorithms)
            {
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip + Environment.NewLine);


            }
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "T");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);
            }
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "Z");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
               
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);
            }
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "Y");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)           
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "E");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "V");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "F");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "A(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "A(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "U(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "U(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "N(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void bToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "N(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "R(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);

            }
        }

        private void bToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "R(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);
            

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void bToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(d)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void aToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "J(a)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }

        private void bToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "J(b)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + p.ImgPath);
            textBox3.AppendText(p.ProTip + Environment.NewLine + Environment.NewLine);

            foreach (var a in p.Algorithms)
            {
                
                textBox1.AppendText(a.Type + Environment.NewLine);
                textBox1.AppendText(a.AlgDisplay + Environment.NewLine + Environment.NewLine);
                textBox2.AppendText(a.ProTip);

            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            var CreditForm = new CreditsForm();
            CreditForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var BeginnersMode = new BeginnersMode();
            BeginnersMode.ShowDialog();
        }

        private void zToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
