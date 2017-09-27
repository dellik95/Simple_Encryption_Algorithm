using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_AtBash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTUWVXYZ";
            string inputMessage = textBox1.Text;
            string encryptedMessage = "";
            for (int i = 0; i < inputMessage.Length; i++)
            {
                if (alphabet.Contains<char>(inputMessage[i]))
                {
                    int index = alphabet.Length - alphabet.IndexOf(inputMessage[i])-1;
                    encryptedMessage += alphabet[index];
                }
            }
            textBox2.Text = encryptedMessage;
        }
    }
}
