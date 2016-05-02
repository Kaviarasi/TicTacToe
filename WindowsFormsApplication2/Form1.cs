using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        /* to maintain the turn. toggles after every move */
        public int flg;
        /* atmost 9 moves are feasible. */
        public int cnt = 0;
        /* to check whether game is over */
        public bool over = false;
        /* to check the respective cell is already filled by any player*/
        public bool b1 = true, b2 = true, b3 = true, b4 = true, b5 = true, b6 = true, b7 = true, b8 = true, b9 = true;
        public Form1()
        {
            flg = 0; /* X will start the game*/
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (b5 && !over && cnt<9)
            {
                cnt++;
                if (flg == 0)
                    button5.Text = "X";
                else
                    button5.Text = "O";
                flg = ~flg;
                if ((button1.Text == button5.Text && button5.Text == button9.Text) ||
    (button3.Text == button5.Text && button5.Text == button7.Text) ||
    (button4.Text == button5.Text && button5.Text == button6.Text) ||
                (button2.Text == button5.Text && button5.Text == button8.Text))
                {
                    over = true;
                    if (button5.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b5 = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (b1 && !over && cnt<9)
            {
                cnt++;
                if (flg == 0)
                    button1.Text = "X";
                else
                    button1.Text = "O";
                flg = ~flg;
                if ((button1.Text == button2.Text && button1.Text == button3.Text) ||
                    (button1.Text == button4.Text && button4.Text == button7.Text) ||
                    (button1.Text == button5.Text && button5.Text == button9.Text))
                {
                    over = true;
                    if (button1.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b1 = false;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b2 && !over && cnt<9)
            {
                cnt++;
                if (flg == 0)
                    button2.Text = "X";
                else
                    button2.Text = "O";
                flg = ~flg;
                if ((button1.Text == button2.Text && button2.Text == button3.Text) 
                    || (button5.Text == button2.Text && button2.Text == button8.Text))
                {
                    over = true;
                    if (button2.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b2 = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b3 && !over && cnt < 9)
            {
                cnt++;
                if (flg == 0)
                    button3.Text = "X";
                else
                    button3.Text = "O";
                flg = ~flg;
                if ((button1.Text == button2.Text && button1.Text == button3.Text) ||
        (button3.Text == button6.Text && button6.Text == button9.Text) ||
        (button3.Text == button5.Text && button5.Text == button7.Text))
                {
                    over = true;
                    if (button3.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b3 = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (b4 && !over && cnt<9)
            {
                cnt++;

                if (flg == 0)
                    button4.Text = "X";
                else
                    button4.Text = "O";
                flg = ~flg;
                if ((button5.Text == button4.Text && button4.Text == button6.Text) || (button1.Text == button4.Text && button4.Text == button7.Text))
                {
                    over = true;
                    if (button4.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b4 = false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b6 && !over && cnt < 9)
            {
                cnt++;
                if (flg == 0)
                    button6.Text = "X";
                else
                    button6.Text = "O";
                flg = ~flg;
                if ((button4.Text == button6.Text && button6.Text == button5.Text) || (button3.Text == button6.Text && button6.Text == button9.Text))
                {
                    over = true;
                    if (button6.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b6 = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (b9 && !over && cnt < 9)
            {
                cnt++;
                if (flg == 0)
                    button9.Text = "X";
                else
                    button9.Text = "O";
                flg = ~flg;
                if ((button9.Text == button6.Text && button6.Text == button3.Text) ||
        (button7.Text == button8.Text && button8.Text == button9.Text) ||
        (button1.Text == button5.Text && button5.Text == button9.Text))
                {
                    over = true;
                    if (button9.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b9 = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (b8 && !over && cnt < 9)
            {
                cnt++;
                if (flg == 0)
                    button8.Text = "X";
                else
                    button8.Text = "O";
                flg = ~flg;
                if ((button6.Text == button7.Text && button7.Text == button8.Text) || (button5.Text == button2.Text && button2.Text == button8.Text))
                {
                    over = true;
                    if (button7.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b8 = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (b7 && !over && cnt < 9)
            {
                cnt++;
                if (flg == 0)
                    button7.Text = "X";
                else
                    button7.Text = "O";
                flg = ~flg;
                if ((button7.Text == button8.Text && button8.Text == button9.Text) || 
                    (button1.Text == button7.Text && button7.Text == button4.Text) ||
                    (button5.Text == button7.Text && button7.Text == button3.Text))
                {
                    over = true;
                    if (button7.Text == "O")
                        textBox2.Text = "Player 2 Wins!!";
                    else
                        textBox2.Text = "Player 1 Wins!!";
                }
                b7 = false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
        cnt = 0;
        over = false;
        b1 = true; b2 = true; 
            b3 = true; b4 = true;
            b5 = true; b6 = true; b7 = true; b8 = true; b9 = true;
            flg = 0;
        
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
