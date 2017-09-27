using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1_Tsezar
{
    public partial class MainForm : Form
    {
        private TsezarSwift ts = null;
        private string EnctyptedText = "";
        Random rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }


        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            //  progressBar1.Value = 0;
            ts = new TsezarSwift(EncryptTextBox.Text, (int)(keyValueInput.Value));
            EnctyptedText = ts.Encryp();
            //  progressBar1.Step = 100/ EnctyptedText.Length;
            //  foreach (var item in EnctyptedText)
            //  {
            //      progressBar1.PerformStep();
            //      Thread.Sleep(rnd.Next(0,100));
            //  }
            textBox1.Text = EnctyptedText;
        }

        private void Decryptbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ts != null)
                {
                    //   progressBar1.Value = 0;
                    //   foreach (var item in ts.Decrypt(this.EnctyptedText, (int)decryptKeyValue.Value))
                    //   {
                    //       progressBar1.PerformStep();
                    //       DecryptTextBox.Text +=item;
                    //       Thread.Sleep(rnd.Next(0, 100));
                    //   }

                   textBox2.Text=ts.Decrypt(EnctyptedText, (int)decryptKeyValue.Value);
                    
                }
                else
                {
                    throw new NullReferenceException("Перше зашифруйте дані");
                }
            }catch(NullReferenceException nRE)
            {
                MessageBox.Show(nRE.Message);
            }
        }
    }
}
