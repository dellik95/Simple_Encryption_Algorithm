namespace Laba_1_Tsezar
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.keyValueInput = new System.Windows.Forms.NumericUpDown();
            this.decryptKeyValue = new System.Windows.Forms.NumericUpDown();
            this.Encryptbtn = new System.Windows.Forms.Button();
            this.Decryptbtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyValueInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptKeyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Повідомлення для шифрування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ шифрування";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ключ дешифрування";
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.Location = new System.Drawing.Point(264, 4);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(226, 22);
            this.EncryptTextBox.TabIndex = 4;
            // 
            // keyValueInput
            // 
            this.keyValueInput.Location = new System.Drawing.Point(264, 49);
            this.keyValueInput.Name = "keyValueInput";
            this.keyValueInput.Size = new System.Drawing.Size(120, 22);
            this.keyValueInput.TabIndex = 5;
            // 
            // decryptKeyValue
            // 
            this.decryptKeyValue.Location = new System.Drawing.Point(264, 127);
            this.decryptKeyValue.Name = "decryptKeyValue";
            this.decryptKeyValue.Size = new System.Drawing.Size(120, 22);
            this.decryptKeyValue.TabIndex = 7;
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.Location = new System.Drawing.Point(410, 45);
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.Size = new System.Drawing.Size(80, 25);
            this.Encryptbtn.TabIndex = 8;
            this.Encryptbtn.Text = "Encrypt";
            this.Encryptbtn.UseVisualStyleBackColor = true;
            this.Encryptbtn.Click += new System.EventHandler(this.Encryptbtn_Click);
            // 
            // Decryptbtn
            // 
            this.Decryptbtn.Location = new System.Drawing.Point(410, 125);
            this.Decryptbtn.Name = "Decryptbtn";
            this.Decryptbtn.Size = new System.Drawing.Size(81, 28);
            this.Decryptbtn.TabIndex = 9;
            this.Decryptbtn.Text = "Decrypt";
            this.Decryptbtn.UseVisualStyleBackColor = true;
            this.Decryptbtn.Click += new System.EventHandler(this.Decryptbtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(475, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Зашифороване повідомлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дешифороване повідомлення";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 236);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Decryptbtn);
            this.Controls.Add(this.Encryptbtn);
            this.Controls.Add(this.decryptKeyValue);
            this.Controls.Add(this.keyValueInput);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Lab 1/Lutskov O.O.";
            ((System.ComponentModel.ISupportInitialize)(this.keyValueInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptKeyValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private System.Windows.Forms.NumericUpDown keyValueInput;
        private System.Windows.Forms.NumericUpDown decryptKeyValue;
        private System.Windows.Forms.Button Encryptbtn;
        private System.Windows.Forms.Button Decryptbtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}

