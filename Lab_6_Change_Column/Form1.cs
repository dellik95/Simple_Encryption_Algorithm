using System;
using System.Windows.Forms;

namespace Lab_6_Change_Column
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCDEFGHIKLMNOPQRSTUWVXYZ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (textBox2.Text.Length / textBox1.Text.Length) + 1;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (dataGridView1.ColumnCount != textBox1.Text.Length)
                {
                    dataGridView1.Columns.Add("", "");
                }

                dataGridView1.Columns[i].HeaderCell.Value = textBox1.Text[i].ToString();
                dataGridView1.Columns[i].Width = 20;
            }
            int iter = 0;
            foreach (DataGridViewRow rows in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cells in rows.Cells)
                {
                    if (iter != textBox2.Text.Length)
                    {
                        cells.Value = textBox2.Text[iter++];
                    }
                    else
                    {
                        cells.Value = " ";
                    }
                }
            }

            if (radioButton2.Checked)
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (dataGridView1.Columns[j].HeaderText == textBox1.Text[i].ToString())
                            {

                                textBox3.Text += dataGridView1.Rows[k].Cells[j].Value;
                            }
                        }
                    }
                }
            }
            if (radioButton1.Checked)
            {
                string Key = "";
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    Key += alphabet.IndexOf(textBox1.Text[i]);
                }
                for (int i = 0; i < Key.Length; i++)
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (dataGridView1.Columns[j].HeaderText == alphabet[Convert.ToInt32(Key[i].ToString())].ToString())
                            {
                                textBox3.Text += dataGridView1.Rows[k].Cells[j].Value;
                            }
                        }
                    }
                }
            }
        }
    }
}
