using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Java_IT202NS_Lesson2Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1, value2, value3, value4, value5, value6, value7, value8, value9, value10,
                value11, value12, value13, value14, value15;

            double.TryParse(textBox6.Text, out value1);
            double.TryParse(textBox7.Text, out value2);
            double.TryParse(textBox8.Text, out value3);
            double.TryParse(textBox9.Text, out value4);
            double.TryParse(textBox10.Text, out value5);
            double.TryParse(textBox11.Text, out value6);
            double.TryParse(textBox12.Text, out value7);
            double.TryParse(textBox13.Text, out value8);
            double.TryParse(textBox14.Text, out value9);
            double.TryParse(textBox15.Text, out value10);
            double.TryParse(textBox16.Text, out value11);
            double.TryParse(textBox17.Text, out value12);
            double.TryParse(textBox18.Text, out value13);
            double.TryParse(textBox19.Text, out value14);
            double.TryParse(textBox20.Text, out value15);

            if (value1 > 0 || value2 > 0 || value3 > 0 || value4 > 0 || value5 > 0 || value6 > 0 || value7 > 0
                || value8 > 0 || value9 > 0 || value10 > 0 || value11 > 0 || value12 > 0
                || value13 > 0 || value14 > 0 || value15 > 0) ;
            {
                listBox1.Items.Add($"{value1}\n");
                listBox2.Items.Add($"{value2}\n");
                listBox3.Items.Add($"{value3}\n");
                listBox4.Items.Add($"{value4}\n");
                listBox5.Items.Add($"{value5}\n");
                listBox6.Items.Add($"{value8}\n");
                listBox7.Items.Add($"{value6}\n");
                listBox8.Items.Add($"{value7}\n");


                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                var MESS = MessageBox.Show("Confirm to add data into text??", "Changes", MessageBoxButtons.YesNo);
                if (MESS == DialogResult.Yes)
                {
                    textBox24.Text = (value11).ToString();
                    textBox23.Text = (value12).ToString();
                    textBox22.Text = (value10).ToString();
                    textBox21.Text = (value13).ToString();
                    textBox20.Text = (value14).ToString();
                    textBox27.Text = (value9).ToString();
                    textBox26.Text = (value15).ToString();
                }
                else
                {
                    MessageBox.Show("Data not added! Please enter valid numbers in all fields ");
                }

               
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog pics1 = new OpenFileDialog();
            pics1.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (pics1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(pics1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
