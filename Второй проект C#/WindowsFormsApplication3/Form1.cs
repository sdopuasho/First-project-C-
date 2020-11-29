using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    
    public partial class Form1 : Form
    {
        
        string s = "";
        string a, b;
        int r , i, j;
        public Form1()
        {
            InitializeComponent();
        }
        Random ra = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            s = textBox1.Text;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                textBox2.Text += s[i];
                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            for ( i = 0, j = a.Length - 1; i < a.Length-1;  i++, j--)
            {
                if(a[i] == b[i])
                {
                    r = 1;
                }
                else
                {
                    r = ra.Next(2, 20);
                }
            }
            if (r == 1) 
            {
                MessageBox.Show("Строки эквиваленты");
            }
            else
            {
                MessageBox.Show("Строки не эквиваленты");
            }
        }
    }
}
