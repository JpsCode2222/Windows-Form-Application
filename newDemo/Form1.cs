using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitOnChange(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Application.Exit();
            }
        }

        private void btnColorChange(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}
