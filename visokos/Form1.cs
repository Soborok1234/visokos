using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GodVis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace visokos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            a = double.Parse(textBox1.Text);


            Class1 area = new Class1();
            double result = area.GetArea(a);

            if (result == 0) 
            {
                label1.Text = "Год Високосный";
            }
             else
            {
                label1.Text = "Год не Високосный";
            }
        }
    }
}
