using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;//if turn==true,Harry's turn else Voldemosrt's turn
        int count_turn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            try
            {
                if (turn)
                {
                    //MessageBox.Show("abc","xyz");
                    //MessageBox.Show(button.Name, "xyz");
                    button.BackgroundImage = Image.FromFile(@"C:\Users\GSP-LAP-009\source\repos\TicTacToe\harry_potter.png");
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Enabled = false;
                    turn = false;
                }
                else
                {
                    //MessageBox.Show(button.Name, "xyz");
                    button.BackgroundImage = Image.FromFile(@"C:\Users\GSP-LAP-009\source\repos\TicTacToe\lord_voldemort.jpg");
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Enabled = false;
                    turn = true;
                }

                count_turn++;
                if (count_turn == 9)
                {
                    draw();
                }
                else
                {

                    check_winner();
                    //MessageBox.Show("abc","xyz");
                }

            }
            catch (Exception)
            {
                Console.Write("Error Occurs in try");

            }
        }
        bool winner = false;
        public void check_winner()
        {
            try
            {
                if ((A1.BackgroundImage?.Size == A2.BackgroundImage?.Size) && (A2.BackgroundImage?.Size == A3.BackgroundImage?.Size) && (!A1.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }

                else if ((B1.BackgroundImage?.Size == B2.BackgroundImage?.Size) && (B2.BackgroundImage?.Size == B3.BackgroundImage?.Size) && (!B1.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }



                else if ((C1.BackgroundImage?.Size == C2.BackgroundImage?.Size) && (C2.BackgroundImage?.Size == C3.BackgroundImage?.Size) && (!C1.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }
                else if ((A1.BackgroundImage?.Size == B1.BackgroundImage?.Size) && (B1.BackgroundImage?.Size == C1.BackgroundImage?.Size) && (!A1.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }

                else if ((A2.BackgroundImage?.Size == B2.BackgroundImage?.Size) && (B2.BackgroundImage?.Size == C2.BackgroundImage?.Size) && (!A2.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }

                else if ((A3.BackgroundImage?.Size == B3.BackgroundImage?.Size) && (B3.BackgroundImage?.Size == C3.BackgroundImage?.Size) && (!A3.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }

                else if ((A1.BackgroundImage?.Size == B2.BackgroundImage?.Size) && (B2.BackgroundImage?.Size == C3.BackgroundImage?.Size) && (!A1.Enabled))
                {
                    //MessageBox.Show("abc", "xyz");
                    winner = true;
                    this_is_the_winner();
                }

                else if ((A3.BackgroundImage?.Size == B2.BackgroundImage?.Size) && (B2.BackgroundImage?.Size == C1.BackgroundImage?.Size) && (!A3.Enabled))
                {

                    winner = true;
                    this_is_the_winner();
                }
            }
            catch { }


        }
        public void this_is_the_winner()
        {
            disable_button();
            if (!turn)
            {
                MessageBox.Show("Harry Potter is the Winner", "Results of Tic Tac Toe");
            }
            else if (turn)
            {
                MessageBox.Show("Lord Voldemort is the Winner", "Results of Tic Tac Toe");
            }
        }

        public void disable_button()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }


        }
        public void draw()
        {
            MessageBox.Show("Draw Game", "Results of Tic Tac Toe");

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Dispose(false);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is created by Khushbu Shah \n Email:khusbu.shah@somaiya.edu", "About Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
