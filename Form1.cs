using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((radioButton1.Checked == false) & (radioButton2.Checked == false))
            {
                if (textBox1.Text != "")
                {
                    MessageBox.Show("单选没选");
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("都没选");
                }
            }
            else if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("输入框没选");
                }
                else {
                    MessageBox.Show("运行");
                }
            }
          
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
