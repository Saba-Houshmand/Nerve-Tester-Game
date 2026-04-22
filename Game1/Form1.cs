using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        public bool game = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (game == true)
            {
                MessageBox.Show(textBox1.Text + ", you lost!", ":(");
                game = false;//Game is end
                GameRun.Text = "Press Start!";
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                game = true;//Game is start
                GameRun.Text = "Keep Steady!";
            }
            else
                MessageBox.Show("First, enter your name please!",":/");
        }

        private void End_MouseEnter(object sender, EventArgs e)
        {
            if (game == true)
            {
                MessageBox.Show(textBox1.Text + ", you won!", "=D");
                game = false;//Game is end
                GameRun.Text = "Press Start!";
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameRun_Click(object sender, EventArgs e)
        {

        }
    }
}
