using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldGuessingGameWindowsApplication
{
    public partial class Form1 : Form
    {
        private string guessWord = "Computer";

        public Form1()
        {
            InitializeComponent();
            HideWord();
        }

        private void HideWord()
        {
            string Hideword = "C??????r";
            txtbox2.Text = Hideword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = txtbox1.Text;

            if (guess.Equals(guessWord))
            {
                txtbox2.Text = guessWord;
                MessageBox.Show("Amazing! You've guessed the word" + "\n" + "The word is " + guessWord);
            }
            else
            {
                listBox1.Items.Add(guess);
                MessageBox.Show("Keep guessing, You can do it");
            }
        }
    }
}