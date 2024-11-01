using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace домашнее_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            


        }

        string link = @"C:\Users\vlad-PC\Desktop\Курсовая работа.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            File.Create(link).Dispose();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(link);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = (File.ReadAllText(link).Replace("а", "1 ").Replace("б", "2 ").Replace("в", "3 ").Replace("г", "4 ").Replace("д", "5 ").Replace("е", "6 ").Replace("ё", "7 ").Replace("ж", "8 ").Replace("з", "9 ").Replace("и", "10 ").Replace("й", "11 ").Replace("к", "12 ").Replace("л", "13 ").Replace("м", "14 ").Replace("н", "15 ").Replace("о", "16 ").Replace("п", "17 ").Replace("р", "18 ").Replace("с", "19 ").Replace("т", "20 ").Replace("у", "21 ").Replace("ф", "22 ").Replace("х", "23 ").Replace("ц", "24 ").Replace("ч", "25 ").Replace("ш", "26 ").Replace("щ", "27 ").Replace("ъ", "28 ").Replace("ы", "29 ").Replace("ь", "30 ").Replace("э", "31 ").Replace("ю", "32 ").Replace("я", "33 "));
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\vlad-PC\Desktop\Курсовая работа.txt", textBox1.Text);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text.Replace("а", "1 ").Replace("б", "2 ").Replace("в", "3 ").Replace("г", "4 ").Replace("д", "5 ").Replace("е", "6 ").Replace("ё", "7 ").Replace("ж", "8 ").Replace("з", "9 ").Replace("и", "10 ").Replace("й", "11 ").Replace("к", "12 ").Replace("л", "13 ").Replace("м", "14 ").Replace("н", "15 ").Replace("о", "16 ").Replace("п", "17 ").Replace("р", "18 ").Replace("с", "19 ").Replace("т", "20 ").Replace("у", "21 ").Replace("ф", "22 ").Replace("х", "23").Replace("ц", "24 ").Replace("ч", "25 ").Replace("ш", "26 ").Replace("щ", "27").Replace("ъ", "28 ").Replace("ы", "29 ").Replace("ь", "30 ").Replace("э", "31 ").Replace("ю", "32 ").Replace("я", "33 ");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Открытие диалогового окна для выбора файла
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Чтение содержимого файла
                        string encryptedText = File.ReadAllText(openFileDialog.FileName);
                        // Дешифрование текста
                        string decryptedText = Decrypt(encryptedText);
                        // Вывод результата в текстовое поле
                        textBox1.Text = decryptedText;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                    }
                }
            }
        }

        private string Decrypt(string input)
        {
            // Реализация дешифрования A1Z33 для русского алфавита
            string[] numbers = input.Split(' ');
            StringBuilder decryptedText = new StringBuilder();

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int num) && num >= 1 && num <= 33)
                {
                    // Преобразование числа в букву (А=1, Б=2, ..., Я=33)
                    decryptedText.Append((char)(num + 1040 - 1)); // 1040 = 'А' в Unicode
                }
                decryptedText.Append(" ");
            }

            return decryptedText.ToString().Trim();
        }







        //textBox2.Text = textBox3.Text.Replace("1 ", "а").Replace("2 ", "б").Replace("3 ", "в").Replace("4 ", "г").Replace("5 ", "л").Replace("6 ", "е").Replace("7 ", "ё").Replace("8 ", "ж").Replace("9 ", "з").Replace("10 ", "и").Replace("11 ", "й").Replace("12 ", "к").Replace("13 ", "л").Replace("14 ", "м").Replace("15 ", "н").Replace("16 ", "о").Replace("17 ", "п").Replace("18 ", "р").Replace("19 ", "с").Replace("20 ", "т").Replace("21 ", "у").Replace("22 ", "ф").Replace("23 ", "х").Replace("24 ", "ц").Replace("25", "ч").Replace("26 ", "ш").Replace("27 ", "щ").Replace("28 ", "ъ").Replace("29 ", "ы").Replace("30 ", "ь").Replace("31 ", "э").Replace("32 ", "ю ").Replace("33 ", "я");
    }
    }

