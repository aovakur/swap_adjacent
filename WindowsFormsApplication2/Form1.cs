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
        public string line1, line2;
        public char a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            line1 = textBox1.Text;

            if ((line1.Length % 2) == 0)
                for (int i = 0; i < line1.Length; i = i + 2)
                {
                    {
                        StringBuilder someString = new StringBuilder(line1);
                        a = someString[i];
                        someString[i] = line1[i + 1];
                        someString[i + 1] = a;
                        line1 = someString.ToString();

                        textBox2.Text = Convert.ToString(line1);
                    }
                }
            else
            {
                for (int i = 0; i < line1.Length-1; i = i + 2)
                {
                    {
                        StringBuilder someString = new StringBuilder(line1);
                        a = someString[i];
                        someString[i] = line1[i + 1];
                        someString[i + 1] = a;
                        line1 = someString.ToString();
                        textBox2.Text = Convert.ToString(line1);
                    }
                }

            }
                
        }
    }
}

