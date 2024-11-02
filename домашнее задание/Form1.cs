using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace домашнее_задание
{
    public partial class Form1 : Form
    {
        private string GeneralLinkToFile = @"C:\Users\vlad-PC\Desktop\Курсовая работа.txt";

        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonCreateDocumentClick(object sender, EventArgs e)
        {
            GeneralLinkToFile = GetLinkToFile();
        }
        private void ButtonMoveTextToWindowClick(object sender, EventArgs e)
        {
            TextBoxGeneral.Text = File.ReadAllText(GeneralLinkToFile);
        }
        private void ButtonEncryptTextClick(object sender, EventArgs e)
        {
            TextBoxGeneral.Text = Encrypt(TextBoxGeneral.Text);
        }
        private void ButtonDecryptTextClick(object sender, EventArgs e)
        {
            TextBoxGeneral.Text = Decrypt(TextBoxGeneral.Text);
        }
        private void ButtonMoveTextToFileClick(object sender, EventArgs e)
        {
            File.WriteAllText(GeneralLinkToFile, TextBoxGeneral.Text);
        }
        private string GetLinkToFile()
        {
            string link = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        link = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                    }
                }
            }
            return link;
        }
        private void ButtonDemoDecryptCkick(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxDemoStart.Text[0].ToString(), out int num))
            {
                TextBoxDemoFinish.Text = Decrypt(TextBoxDemoStart.Text);
            } 
            else
            {
                TextBoxDemoFinish.Text = Encrypt(TextBoxDemoStart.Text);
            }
        }
        private string Encrypt(string input)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char letter in input)
            {
                if (letter >= 'А' && letter <= 'Я') // Проверка на заглавные буквы
                {
                    int num = letter - 1040 + 1; // Преобразование буквы в число
                    encryptedText.Append(num + " ");
                }
                else if (letter >= 'а' && letter <= 'я') // Проверка на строчные буквы
                {
                    int num = letter - 1072 + 34; // Преобразование буквы в число
                    encryptedText.Append(num + " ");
                }
            }
            return encryptedText.ToString().Trim();
        }
        private string Decrypt(string input)
        {
            string[] numbers = input.Split(' ');
            StringBuilder decryptedText = new StringBuilder();

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    if (num >= 1 && num <= 33) // Проверка для заглавных букв
                    {
                        decryptedText.Append((char)(num + 1040 - 1)); // 1040 = 'А' в Unicode
                    }
                    else if (num >= 34 && num <= 66) // Проверка для строчных букв
                    {
                        decryptedText.Append((char)(num + 1072 - 34)); // 1072 = 'а' в Unicode
                    }
                }
                decryptedText.Append(" ");
            }
            string response = decryptedText.ToString().Trim().Replace(" ", "");
            return response;
        }
    }
}

