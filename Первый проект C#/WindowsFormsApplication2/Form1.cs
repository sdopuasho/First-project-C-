using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            MessageBox.Show("Привет, " + textBox1.Text + ". Твой возраст: " + textBox2.Text + ". Твой ID в VK: " + textBox3.Text + ". Твой ID в Facebook: " + textBox4.Text + ". Сообщение, которое ты хочешь вывести: ' " + textBox5.Text + "'");
        }
    }
}
