using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_Формы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileRead = new OpenFileDialog();
            FileRead.Filter = "текстовые файлы |*.txt";
            if (FileRead.ShowDialog() == DialogResult.OK)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                string text = File.ReadAllText(FileRead.FileName);
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);

                }
                timer.Stop();

                this.textBox2.Text = timer.Elapsed.ToString();
                this.textBox1.Text = list.Count.ToString();

            }
            else
            {
                MessageBox.Show("Необхоимо выбрать файл");
            }

        }

        private void button2_Click(object sender, EventArgs e)
       
        {
            string word = this.textBox3.Text.Trim();
            if(!string.IsNullOrWhiteSpace(word) && list.Count>0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch timer = new Stopwatch();
                timer.Start();
                foreach(string str in list)
                {
                    if(str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                     
                }
                timer.Stop();
                this.textBox4.Text = timer.Elapsed.ToString();
                this.listBox1.BeginUpdate();
                this.listBox1.Items.Clear();
                foreach(string str in tempList)
                {
                    this.listBox1.Items.Add(str);
                }
                this.listBox1.EndUpdate();
            }
            else
            {
                MessageBox.Show("Выберите файл и ввеите ключевое слово!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть форрму?","Уважаемый пользователь,",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result ==DialogResult.No )
            {
                e.Cancel = true;
            }

        }
    }
}
