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
        private string OTBrute = "";
        private string ZTBrute = "";

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
            
                char[] ss = { '\n', ' ' };
                string text = File.ReadAllText("алфавит.txt");
                string[] alphabet = text.Split(ss);
                char[] alphabetChar = new char[alphabet.Length];

                for (int i = 0; i < alphabet.Length; i++)
                {
                    alphabetChar[i] = alphabet[i][0];
                }
                if (DecryptRadioButton.Checked)
                {
                    try
                    {
                        string OT = "";
                        OT = CezarTextBox.Text;
                        if (OT != "")
                        {
                            char[] OTChar = OT.ToCharArray();
                            char[] result = new char[OTChar.Length];
                            int Key = Convert.ToInt32(KeyTextBox.Text);
                            if (Key <= 0)
                            {
                                Console.Text += "Error: Ключ должен быть положительным\n";
                            }
                            else
                            {
                                Console.Text += "Текст: " + OT + "\n";
                                Console.Text += "Ключ: " + Key + "\n";
                                CezarTextBox.Text = "";
                                KeyTextBox.Text = "";

                                for (int i = 0; i < OTChar.Length; i++)
                                {
                                    int j = Array.IndexOf(alphabetChar, OTChar[i]);
                                    if (j >= 0)
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
                        }
                        else
                        {
                            Console.Text += "Введите сообщение\n";
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.Text += "Error: Ключ должен быть целым числом\n";
                    }

                }

                if (CryptRadioButton.Checked)
                {
                    try
                    {
                        string OT = "";
                        OT = OTDecryTextBox.Text;

                        if (OT != "")
                        {
                            char[] OTChar = OT.ToCharArray();
                            char[] result = new char[OTChar.Length];
                            int Key = Convert.ToInt32(KeyDecryTextBox.Text);
                            if (Key <= 0)
                            {
                                Console.Text += "Error: Ключ должен быть положительным\n";
                            }
                            else
                            {
                                Console.Text += "Текст: " + OT + "\n";
                                Console.Text += "Ключ: " + Key + "\n";
                                CezarTextBox.Text = "";
                                KeyTextBox.Text = "";

                                for (int i = 0; i < OTChar.Length; i++)
                                {
                                    int j = Array.IndexOf(alphabetChar, OTChar[i]);
                                    if (j >= 0)
                                    {
                                        j = (j - Key) % alphabetChar.Length;
                                        if (j < 0)
                                        {
                                            j += alphabetChar.Length;
                                        }
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
                        }
                        else
                        {
                            Console.Text += "Error: Введите текст сообщения";
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Text += "Error: Ключ должен быть целым числом\n";
                    }

                }

                if (BruteForceRadioButton.Checked)
                {
                    OTBrute = textBox1.Text;
                    ZTBrute = textBox2.Text;
                    if (OTBrute != "")
                    {
                        if (ZTBrute != "")
                        {
                            char[] OTChar = OTBrute.ToCharArray();
                            char[] ZTChar = ZTBrute.ToCharArray();
                            char[] result = new char[OTChar.Length];
                            string res = null;
                            for (int h = 0; h < alphabetChar.Length && OTBrute != res ; h++)
                            {
                                Console.Text += "Итерация: " + h;
                                for (int i = 0; i < ZTBrute.Length; i++)
                                {
                                    int j = Array.IndexOf(alphabetChar, ZTChar[i]);
                                    if (j >= 0)
                                    {
                                        j = (j - h) % alphabetChar.Length;
                                        if (j < 0)
                                        {
                                            j += alphabetChar.Length;
                                        }
                                        result[i] = alphabetChar[j];
                                    }
                                    else
                                    {
                                        Console.Text += "Error: Такого символа нет в алфавите " + OTChar[i] + "\n";
                                        return;
                                    }
                                }
                                res = new string(result);
                                Console.Text += " Текст: " + res + "\n"; 
                            }

                            Console.Text += "Открытый текст: " + OTBrute + "\n";
                            Console.Text += "Зашифрованное сообщение: " + ZTBrute + "\n";
                            Console.Text += "Результат взлома: " + res + "\n\n";
                            Console.Text += "-------------------------------Конец Взлома-------------------------------\n";
                        }
                        else
                        {
                            Console.Text += "Введите зашифрованный текст";
                        }
                    }
                    else
                    {
                        Console.Text += "Введите открытый текст\n";
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
                KeyDecryTextBox.Text = "";
                OTDecryTextBox.Text = "";
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
                CezarTextBox.Text = "";
                KeyTextBox.Text = "";
                groupBox2.Enabled = false;
            }
        }

        private void BruteForceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(BruteForceRadioButton.Checked)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }

        private void DiffiButton_Click(object sender, EventArgs e)
        {
            long p = 0;
            long Xa = 0;
            long Xb = 0;
            bool OK = true;

            Console.Text += "-------------Алгоритм Диффи-Хелмана-------------\n";

            try
            {
                p = Convert.ToInt64(PtextBox.Text);
                if (!Diffi.isSimple(p))
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                Console.Text += "P должно быть простым числом \n";
                OK = !OK;
            }

            try
            {
                Xa = Convert.ToInt32(XaTextBox.Text);
            }
            catch (Exception ex)
            {
                Console.Text += "Xa должно быть целым числом \n";
                OK = !OK;
            }

            try
            {
                Xb = Convert.ToInt64(XbTextBox.Text);
            }
            catch (Exception ex)
            {
                Console.Text += "Xb должно быть целым числом \n";
                OK = !OK;
            }

            if (OK)
            {
                Diffi d = new Diffi(p, Xa, Xb);
                Console.Text += d.Perform() + "-------------Конец алгоритма-------------\n";
            }
        }

        private void ShamButton_Click(object sender, EventArgs e)
        {
            long m = 0;
            int n = 0;
            bool f = true;
            Console.Text += "-------------Шифр Шамира-------------\n";
            try
            {
                m = Convert.ToInt64(MShamTextBox.Text);
                n = Convert.ToInt32(NShamTextBox.Text);
            }
            catch (Exception ex)
            {
                Console.Text += "Введено неверное значение \n";
                f = !f;
            }

            if (f)
            {
                Shamir s = new Shamir(m, n);
                Console.Text += s.perform() + "-------------Конец передачи-------------\n";
            }
        }

        private void ElButton_Click(object sender, EventArgs e)
        {
            long m = 0;
            long p = 0;
            long g = 0;
            long cb = 0;
            long k = 0;
            bool f = true;
            Console.Text += "-------------Шифр Эль-Гамаля-------------\n";
            try
            {
                m = Convert.ToInt64(MElTextBox.Text);
                p = Convert.ToInt64(PElTextBox.Text);
                if (!Diffi.isSimple(p))
                {
                    Console.Text += "P должно быть простым \n";
                    f = !f;
                }
                g = Convert.ToInt64(GElTextBox.Text);
                cb = Convert.ToInt64(CbElTextBox.Text);
                k = Convert.ToInt64(KElTextBox.Text);
                
            }
            catch (Exception ex)
            {
                Console.Text += "Введено неверное значение \n";
                f = !f;
            }

            if (f)
            {
                ElGamal el = new ElGamal(p, m, g, cb, k);
                Console.Text += el.Perform() + "-------------Конец шифра-------------\n";
            }
        }

    }
}
