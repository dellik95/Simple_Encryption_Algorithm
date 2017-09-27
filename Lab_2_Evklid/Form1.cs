using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Evklid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            if (radioButton1.Checked)
            {
                textBox3.Text = NODDevide(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString();
            }
            else
            {
                textBox3.Text = NOD(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString();
            }
           


        }

        int NODDevide(int left, int right)
        {
            while (left!=0&&right!=0)
            {
                if (left>right)
                {
                    left %= right;
                }
                else
                {
                    right %= left;
                }
            }
            return left + right;
        }

        public int NOD(int left,int right)
        {
            while (left != right)
            {
                if (left > right)
                {
                    left -= right;
                }
                else
                {
                    right -= left;
                }
            }
            return left;
        }
    }
}
