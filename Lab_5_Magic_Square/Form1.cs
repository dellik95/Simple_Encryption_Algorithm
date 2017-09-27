using System;
using System.Windows.Forms;

namespace Lab_5_Magic_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);


            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            dataGridView2.ColumnCount = n;
            dataGridView2.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 1 + ((i + j - 1 + (n - 1) / 2) % n) * n + ((i + 2 * j + 2) % n);
                }
                dataGridView1.Columns[i].Width = 20;
                dataGridView2.Columns[i].Width = 20;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int MagicConstant = (n * ((int)Math.Pow(n, 2) + 1)) / 2;


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int next = 0;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    next += Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
                if (next != MagicConstant)
                {
                    MessageBox.Show($"Число {next} не задовільцяє умову (n(n^2+1)/2) = {MagicConstant}");
                }

            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int next = 0;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    next += Convert.ToInt32(dataGridView1.Rows[j].Cells[i].Value);
                }
                if (next != MagicConstant)
                {
                    MessageBox.Show($"Число {next} не задовільцяє умову (n(n^2+1)/2) = {MagicConstant}");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(textBox1.Text);


            char[] encryptMessage = new char[n * n];
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                encryptMessage[i] = textBox2.Text[i];
            }

            int count = 0;
            for (int i = 0; i < encryptMessage.Length; i++)
            {
                count++;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[j].Cells[k].Value) == count)
                        {
                            dataGridView2.Rows[j].Cells[k].Value = encryptMessage[i];
                        }
                    }
                }
            }

            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                for (int k = 0; k < dataGridView1.RowCount; k++)
                {

                    textBox3.Text += (char)(dataGridView2.Rows[j].Cells[k].Value) == 0 ? "_" : dataGridView2.Rows[j].Cells[k].Value;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Math.Pow(Convert.ToInt32(textBox1.Text),2); i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                    {
                        if (Convert.ToInt32(dataGridView1.Rows[j].Cells[k].Value)==i)
                        {
                            textBox4.Text += dataGridView2.Rows[j].Cells[k].Value;
                        }
                    }
                }
            }
        }
    }
}
