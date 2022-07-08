using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        string path = @"d:\\test1.txt";
        List<string> file = new List<string>();//лист строк
        public Form1()
        {
            InitializeComponent();

        }

       //чтение текста файла и преобразование в лист строк
        private void ReadDataFile()
        {
            this.file.Clear();
            StreamReader reader = new StreamReader(path);
            
            string line = reader.ReadLine();
            while (line != null)
            {
                this.file.Add(line);
                line = reader.ReadLine();
            }
            
            reader.Close();
            
        }

        private void button_read_start_Click(object sender, EventArgs e)
        {
            ReadDataFile();
            richTextBox1.Clear();
            for (int i = 0; i < file.Count; i++)
            {
                richTextBox1.AppendText(file[i] + "\n");
            }
        }
        //вывод текста файла на экран
        private void button_read_end_Click(object sender, EventArgs e)
        {
            ReadDataFile();
            richTextBox1.Clear();
            for(int i = file.Count - 1; i >= 0; i--)
            {
                richTextBox1.AppendText(file[i] + "\n");
            }
            
        }

        //очистка файла
        private void button_clear_file_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, "");
        }

        //добавление нового текста в файл
        private void button_add_to_file_Click(object sender, EventArgs e)
        {
            string[] str_arr = richTextBox2.Lines;

            StreamWriter writer = new StreamWriter(path, true);
            
            
            for(int i = 0; i<str_arr.Length; i++)
            {
                writer.WriteLine(str_arr[i]);
            }

            writer.Close();
            
            
        }
    }
}
