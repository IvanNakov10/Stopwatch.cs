using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stopwatch1;


namespace Stopwatch___random_team_stuff
{
    public partial class Form1 : Form
    {
        Stopwatch1.Stopwatch sw = new Stopwatch1.Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Rand = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Rand = int.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Rand = int.Parse(textBox1.Text);
        }
    }
}
