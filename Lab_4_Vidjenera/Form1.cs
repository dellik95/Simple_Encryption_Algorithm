using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab_4_Vidjenera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializedGrid(dataGridView1);

        }

        static char[] shift(char[] inputAlphabet, int shiftcount)
        {
            char tmp;
            for (int i = 0; i < shiftcount; i++)
            {
                tmp = inputAlphabet[0];
                for (int j = 1; j < inputAlphabet.Length; j++)
                {
                    inputAlphabet[j - 1] = inputAlphabet[j];
                }
                inputAlphabet[inputAlphabet.Length - 1] = tmp;
            }
            return inputAlphabet;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string xCoord = "";
            string yCoord = "";
            if (textBox1.Text.Length == textBox2.Text.Length)
            {
                for (int j = 0; j < textBox1.Text.Length; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[0].Cells.Count; i++)
                    {
                        if ((char)dataGridView1.Rows[0].Cells[i].Value == textBox1.Text[j].ToString().ToUpper().ToCharArray()[0])
                        {
                            xCoord += i + " ";
                        }
                    }
                }
                for (int j = 0; j < textBox1.Text.Length; j++)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((char)dataGridView1.Rows[i].Cells[0].Value == textBox2.Text[j].ToString().ToUpper().ToCharArray()[0])
                        {
                            yCoord += i + " ";
                        }
                    }
                }
                for (int i = 0; i < xCoord.Split(' ').Length - 1; i++)
                {
                    textBox3.Text += dataGridView1.Rows[Int32.Parse(xCoord.Split(' ')[i])].Cells[Int32.Parse(yCoord.Split(' ')[i])].Value;
                   }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xCoord = "";
            string yCoord = "";
            if (textBox3.Text.Length == textBox2.Text.Length)
            {
                for (int j = 0; j < textBox2.Text.Length; j++)
                {
                    for (int i = 0; i < dataGridView1.Rows[0].Cells.Count; i++)
                    {
                        if ((char)dataGridView1.Rows[0].Cells[i].Value == textBox2.Text[j].ToString().ToUpper().ToCharArray()[0])
                        {
                            xCoord += i + " ";
                        }
                    }
                }
                for (int j = 0; j < xCoord.Split(' ').Length - 1; j++)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((char)dataGridView1.Rows[i].Cells[Int32.Parse(xCoord.Split(' ')[j].ToString())].Value == textBox3.Text[j].ToString().ToUpper().ToCharArray()[0])
                        {
                            yCoord += i + " ";
                        }
                    }
                }
                for (int i = 0; i < xCoord.Split(' ').Length - 1; i++)
                {
                    textBox4.Text += dataGridView1.Rows[0].Cells[Int32.Parse(yCoord.Split(' ')[i])].Value;
                }
            }
        }

        static void InitializedGrid(DataGridView dataGridView1)
        {
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUWVXYZ".ToCharArray();
            dataGridView1.ColumnCount = alphabet.Length;
            dataGridView1.RowCount = alphabet.Length;

            for (int i = 0; i < alphabet.Length; i++)
            {
                dataGridView1.Columns[i].Width = 20;
            }
            int inp = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                char[] temp = shift(alphabet, inp);
                for (int j = 0; j < alphabet.Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = temp[j];
                }
                inp = 1;
            }
        }
    }
}
