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
        private void hToolStripMenuItemH_Click(object sender, EventArgs e)
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

        private void tToolStripMenuItemT_Click(object sender, EventArgs e)
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

        private void zToolStripMenuItemZ_Click(object sender, EventArgs e)
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

        private void yToolStripMenuItemY_Click(object sender, EventArgs e)
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

        private void eToolStripMenuItemE_Click(object sender, EventArgs e)
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

        private void vToolStripMenuItemV_Click(object sender, EventArgs e)
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

        private void fToolStripMenuItemF_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemA_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemB_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemUa_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemUb_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemNa_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemNb_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemRa_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemRb_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemGa_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemGb_Click(object sender, EventArgs e)
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

        private void cToolStripMenuItemGc_Click(object sender, EventArgs e)
        {
            var p = RCDB.PLL.Single(asdf => asdf.Title == "G(c)");

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

        private void dToolStripMenuItemGd_Click(object sender, EventArgs e)
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

        private void aToolStripMenuItemJa_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItemJb_Click(object sender, EventArgs e)
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
    }
}
