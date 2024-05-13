using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWinform
{
    public partial class Form2 : Form
    {
        private Form1 form1;


        public Form2(Form1 form1)
        {
            TopMost = true;

            this.form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Enabled = true;
            form1.RestartGame();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
