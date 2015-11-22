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

namespace Kriptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AlfphaButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "алфавит.txt";
            Proc.Start();
        }

        private void ShifButton_Click(object sender, EventArgs e)
        {
            if (DecryptRadioButton.Checked)
            {
                string OT = "";
                OT = CezarTextBox.Text;
                try
                {
                    int Key = Convert.ToInt32(KeyTextBox.Text);
                    if (Key <= 0)
                    {
                        Console.Text += "Error: Ключ должен быть положительным\n";
                    }
                    else
                    {
                        if (OT != "")
                        {
                            char[] ss = { '\n', ' ' };
                            string text = File.ReadAllText("алфавит.txt");
                            string[] alphabet = text.Split(ss);
                            char[] alphabetChar = new char[alphabet.Length];


                            for (int i = 0; i < alphabet.Length; i++)
                            {
                                alphabetChar[i] = alphabet[i][0];
                            }

                            char[] OTChar = OT.ToCharArray();
                            char[] result = new char[OTChar.Length];

                            Console.Text += "Текст: " + OT + "\n";
                            Console.Text += "Ключ: " + Key + "\n";
                            CezarTextBox.Text = "";
                            KeyTextBox.Text = "";

                            for (int i = 0; i < OTChar.Length; i++)
                            {
                                int j = Array.IndexOf(alphabetChar, OTChar[i]);
                                if (j > 0)
                                {
                                    j = (j + Key) % alphabetChar.Length;
                                    result[i] = alphabetChar[j];
                                }
                                else
                                {
                                    Console.Text += "Error: Такого символа нет в алфавите " + OTChar[i] + "\n";
                                    return;
                                }
                                OTChar[i] = ' ';
                            }
                            string resultString = new string(result);
                            Console.Text += "Зашифрованное сообщение: " + resultString + "\n";
                            Console.Text += "-------------------------------Конец шифровки-------------------------------\n";
                        }
                        else
                        {
                            Console.Text += "Error: Введите текст для расшифровки\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Text += "Error: Ключ должен быть целым числом\n";
                }
            }
            else
            {
                string OT = "";
                OT = OTDecryTextBox.Text;
                try
                {
                    int Key = Convert.ToInt32(KeyDecryTextBox.Text);
                    if (Key <= 0)
                    {
                        Console.Text += "Error: Ключ должен быть положительным\n";
                    }
                    else
                    {
                        if (OT != "")
                        {
                            char[] ss = { '\n', ' ' };
                            string text = File.ReadAllText("алфавит.txt");
                            string[] alphabet = text.Split(ss);
                            char[] alphabetChar = new char[alphabet.Length];


                            for (int i = 0; i < alphabet.Length; i++)
                            {
                                alphabetChar[i] = alphabet[i][0];
                            }

                            char[] OTChar = OT.ToCharArray();
                            char[] result = new char[OTChar.Length];

                            Console.Text += "Текст: " + OT + "\n";
                            Console.Text += "Ключ: " + Key + "\n";
                            CezarTextBox.Text = "";
                            KeyTextBox.Text = "";

                            for (int i = 0; i < OTChar.Length; i++)
                            {
                                int j = Array.IndexOf(alphabetChar, OTChar[i]);
                                if (j > 0)
                                {
                                    j = (j - Key) % alphabetChar.Length;
                                    result[i] = alphabetChar[j];
                                }
                                else
                                {
                                    Console.Text += "Error: Такого символа нет в алфавите " + OTChar[i] + "\n";
                                    return;
                                }
                                OTChar[i] = ' ';
                            }
                            string resultString = new string(result);
                            Console.Text += "Зашифрованное сообщение: " + resultString + "\n";
                            Console.Text += "-------------------------------Конец Расшифровки-------------------------------\n";
                        }
                        else
                        {
                            Console.Text += "Error: Введите текст для расшифровки\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Text += "Error: Ключ должен быть целым числом\n";
                }
            }
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {
            Console.SelectionStart = Console.Text.Length;
            Console.ScrollToCaret();
        }

        private void DecryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DecryptRadioButton.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void CryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CryptRadioButton.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
    }
}
