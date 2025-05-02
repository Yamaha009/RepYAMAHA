using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Игра
{
    public partial class Form1 : Form
    {
        int flag1;
        int x1, x2;
        
         public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
                flag1 = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
            flag1 = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag1 != 0) // Если дан старт :
            {
                Random a = new Random();
                int count = a.Next(8);
                x1 += count;
                label1.Text = Convert.ToString(x1);
                pictureBox1.Left = x1;
                count = a.Next(8);
                x2 += count;
                label2.Text = Convert.ToString(x2);
                pictureBox2.Left = x2;
            }
            if ((x1 >= 889) || (x2 >= 870))
            {
                flag1 = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "биба";
            textBox2.Text = "боба";
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
        }
    }
}
