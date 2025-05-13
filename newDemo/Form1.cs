using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newDemo
{
    public partial class Form1 : Form
    {
        private int counter = 5;
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

        private void addNewItem(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Item " + counter);
            counter++;
        }

        private void removeItem(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(comboBox1.SelectedItem);
            //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Add New text on FormLoad";
        }
    }
}
