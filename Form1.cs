using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (guna2ProgressBar1.Value >= 100) {
                    Form2 mainWin = new Form2();
                    mainWin.Show();
                    this.Hide();
                    timer1.Stop();
                    
                }
                else
                {
                    guna2ProgressBar1.Value += rand.Next(2, 20); //increase second number to make load faster
                }
            }
            catch (Exception) {
            }

        }
    }
}
