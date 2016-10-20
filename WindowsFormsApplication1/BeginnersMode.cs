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
    public partial class BeginnersMode : Form
    {
        public BeginnersMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var RCPLL = new RCPLL();
            RCPLL.ShowDialog();
        }
    }
}
