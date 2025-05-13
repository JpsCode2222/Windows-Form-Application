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
        private object errorProvider1;

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
            radioButton2.Checked = true;
            timer1.Start();

            // Add data to datgrid
            dataGridView1.Rows.Add("Jayad", "Pathan", 80, "Ahmednagar", "2002-12-22");
            dataGridView1.Rows.Add("Jayad", "Pathan", 80, "Ahmednagar", "2002-12-22");
            dataGridView1.Rows.Add("Jayad", "Pathan", 80, "Ahmednagar", "2002-12-22");
            dataGridView1.Rows.Add("Jayad", "Pathan", 80, "Ahmednagar", "2002-12-22");
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

        private void selectRadioButton(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label4.Text = "radioButton1 is Checked";
            }
            else if (radioButton2.Checked)
            {
                label4.Text = "radioButton2 is Checked";
            }
            else if (radioButton3.Checked)
            {
                label4.Text = "radioButton3 is Checked";
            }
            else
            {
                label4.Text = "radioButton4 is Checked";
            }
        }

        private void startDownloadProgress(object sender, EventArgs e)
        {
            for (int i = 0; i<= 100; i++)
            {
                progressBar1.Value = i;
                progressBar2.Value = i;
                progressBar3.Value = i;
                System.Threading.Thread.Sleep(100);
            }
        }

        private void openDailogMessageBox(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit", "Inforamtion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void signUp(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            var errorProvider1 = new ErrorProvider();
            var errorProvider2 = new ErrorProvider();

            if (loginUsername.Text.Equals(user) && loginPassword.Text.Equals(user))
            {
                MessageBox.Show("Login Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            else
            {
                
                if (loginUsername.Text != user)
                {
                    errorProvider1.SetError(loginUsername, "incorrect username");
                }
                else
                {
                    errorProvider1.Clear();  
                }


                if (loginPassword.Text != pass)
                {
                    errorProvider2.SetError(loginPassword, "incorrect username");
                }
                else{
                    errorProvider2.Clear();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar2.Value <= 100)
            {
                progressBar2.Value += 1;
            }
            if(progressBar2.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void removeSelectedDataFromDataGridView(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //dataGridView1.Rows.RemoveAt(1);
        }

        private void navigate(object sender, EventArgs e)
        {
            webBrowser1.Navigate(searchTxt.Text);
        }

        private void back(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refresh(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void onNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            searchTxt.Text = webBrowser1.Url.ToString();
        }

        private void loadTxtFileData(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*) | *.*";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtFile.Text = openFileDialog1.FileName; 
                txtFile.Text = System.IO.File.ReadAllText(openFileDialog1.FileName); 
            }
        }
    }
}
