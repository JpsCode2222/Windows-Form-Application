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

        private void addDateTimeToLable(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
            label2.Text = dateTimePicker1.Value.ToString("yyyy-MMM-dd");
        }

        private void addPasswordToLable(object sender, EventArgs e)
        {
            label3.Text = password.Text;
        }

        private void checkPassword(object sender, EventArgs e)
        {
            if (password.Text == password2.Text) {
                MessageBox.Show("Password Match : " + password.Text);
            }
            else
            {
                MessageBox.Show("Error : Password not match");
            }
        }

        private void loadImage(object sender, EventArgs e)
        {
            //pictureBox1.Load("chart.png");
            //pictureBox1.Image = Image.FromFile("chart.png");
        }
    }
}
