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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                 richTextBox1.Text = File.ReadAllText(openFile.FileName);
                textBox1.Text = openFile.FileName;     
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFile.FileName;
                richTextBox2.Text = File.ReadAllText(openFile.FileName);        
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // заносим файл Genesis в массив строк
            string path1 = textBox1.Text;
                    string[] fFile = File.ReadAllLines(path1);
           
            // заносим файл WinCC в массив строк
            string path2 = textBox2.Text;     
            string[] sFile = File.ReadAllLines(path2);
          
            int Fline_1 = fFile.Length;
            int k = 0;
            int Fline_2 = sFile.Length;
            int mas = 0;
           
            // считаем кол-во строк с тегами Genesis
            for (int i = 0; i < Fline_1; i++)
            {
                if (fFile[i].Contains("AK"))
                {
                    mas = mas + 1;
                }
               
            }
           // создаем и заполняем массив тегами из Genesis
            string[] arr = new string[mas];
            for (int o = 0; o < mas; o++)
            {
                for (int p = k; p < Fline_1; p++)
                {
                    if (fFile[p].Contains("AK"))
                    {
                        arr[o] = fFile[p];
                        k = p + 1;
                        break;
                    }
                }
               
            }
 //int qwe = 0;
      
            // начинаем сравнивать теги файла WinCC с тегами файла Genesis
            for (int i = 0; i <10000; i++)
            {

                if (sFile[i].Contains("ak.") || sFile[i].Contains("тэг"))
                {
                    // копируем строку с тегом WinCC в пустую строку для сравнения
                    string text1 = sFile[i];
                 
                 //   text1 = text1.ToLower();                 
                    //text1 = text1.Replace(" ", "");
                      text1 = text1.Substring(text1.Length - 48);
                 
                   // richTextBox4.Text += text1 + Environment.NewLine;     
                    richTextBox4.Text += sFile[i] + Environment.NewLine;
                    double max = 0;
                   int k1 = 0;
                 //   double count4 = 0;
                    for (int j = 0; j < mas; j++)
                    {
                        
                        if (arr[j].Contains("AK."))
                        {
                            // копируем строку с тегом Genesis в пустую строку для сравнения
                            string text2 = arr[j];
              
                      //      text2 = text2.ToLower();                          
                           // text2 = text2.Replace(" ", ""); 
                           text2 = text2.Substring(text2.Length - 48); 
                           
                           // richTextBox4.Text += text2 + Environment.NewLine;

                            // апеременные для подсчета каждого символа в строках
                            double count1 = 0; // для тега WinCC
                            double count2 = 0; // для тега Genesis
                            double count3 = 0; // подсчет общих символов в обеих строках
                            char PreCh = '\\';
                            double t1 = text1.Length;
                            double t2 = text2.Length;
                           
                            // сравнение строк посимвольно
                            foreach (char ch in text1)
                            {
                                foreach (char cha in text1)

                                    if (cha != PreCh && cha == ch)
                                        count1++;

                                foreach (char cha2 in text2)

                                    if (cha2 != PreCh && cha2 == ch)
                                        count2++;
                                if (count1 <= count2)
                                {
                                    count3 = count3 + count1;
                                }
                                else
                                {
                                    count3 = count3 + count2;
                                }
                                if (count1 != 0)
                                {

                                    count1 = 0;
                                    // PreCh = ch;
                                }
                                if (count2 != 0)
                                {
                                    //count1 = 0;
                                    count2 = 0;
                                    PreCh = ch;

                                    int l = 0;
                                    var tmp = text2[l].ToString();
                                    text2 = text2.Replace(tmp, "");
                                    //text2 = text2.Insert(i, tmp);
                                    l++;
                                    if (text2.Length - 1 < l)
                                    {
                                        break;
                                    }

                                }
                                Application.DoEvents();

                            }
                            double z = 0;
                            z = count3 / (t1 + t2 - count3); // коэф-ент схожести строк. От 0 до 1
                         //   count4 = count3;
                           // int k1 = 0;
                            if (max < z && z < 1.0)
                            {
                                max = z;
                                k1 = j;
                               
                            }                          
                        }        
                        if (j == mas - 1)  //&& max > 0.95
                        {
                            // qwe = qwe + 1;
                            // richTextBox4.Text += qwe;    
                           // string test = arr[k1].Substring(arr[k1].Length - 48);
                            richTextBox4.Text += arr[k1] + Environment.NewLine;  
                            //richTextBox4.Text += max + Environment.NewLine;
                        //    richTextBox4.Text += count4 + Environment.NewLine;
                            richTextBox4.Text += "-------------------" + Environment.NewLine;
                           
                            sFile[i] = sFile[i].Replace(sFile[i], arr[k1]);                       
                            arr[k1] = arr[k1].Replace(arr[k1], "11");
                                         
                            max = 0;
                            k1 = 0;
                        }
                    }

                    //-----------------------------------------------------------

                    //-------------------------------------------------------------
                   
                }
               
            if (i == 9999)
                { 
                   richTextBox3.Lines = sFile; 
                }  
                Application.DoEvents();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "Test files|*.txt";
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
                {
                    sw.WriteLine(richTextBox3.Text);
                    sw.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
