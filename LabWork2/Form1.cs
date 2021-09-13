using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1,825*10^2";
            textBox2.Text = "18,225";
            textBox3.Text = "0,512";
            textBox5.Text = "1,2131";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = Double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            // Считывание значения Z
            double d = double.Parse(textBox5.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine + "ψ = " + d.ToString();
            // Вычисляем арифметическое выражение
            double a = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1.0 / 3.0));
            double b = a + (y - x); 
            double c = b * (Math.Cos(y - (z / (y - x)))) / 1 + Math.Pow(y - x, 2);
            //double u = u = c;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат U = " + c.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
