using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrushGame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            if (button1.ClientRectangle.Contains(button1.PointToClient(Control.MousePosition)))
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I love you too <333");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ignored
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int rHeight = rnd.Next(1, 480);
            int rWidth = rnd.Next(1, 260); 

            button1.Location = new Point(rHeight, rWidth);

        }

        private readonly Random _random = new Random();
     
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
