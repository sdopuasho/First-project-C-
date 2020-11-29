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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 8, i, j;
            Color first = Color.Red; // цвет
            Color second = Color.Green; // цвет
            Button[,] S = new Button[n, n]; // массив кнопок
            Random ra = new Random(); // рандом 
            {
                for (i = 0; i < n; ++i)
                    for (j = 0; j < n; ++j)
                    {
                        S[i, j] = new Button();
                        if (j % 2 == 0)
                            S[i, j].Location = new Point(ra.Next(0, 800), 20);
                        else
                            S[i, j].Location = new Point(ra.Next(0, 800), 800);
                        S[i, j].Size = new Size(ra.Next(0, 200), ra.Next(0, 200));
                        if (S[i, j].Size.Width < 100 || S[i, j].Size.Height < 100)
                            S[i, j].BackColor = first;
                        else
                            S[i, j].BackColor = second;
                        Controls.Add(S[i, j]);
                    }
                }
            }
        }
    }
