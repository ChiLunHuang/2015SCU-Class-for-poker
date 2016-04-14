using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150310_A2_03356013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }
        DeckOfCards myDeckOfCards = new DeckOfCards();
        public void button1_Click(object sender, EventArgs e)
        {

            myDeckOfCards.Shuffle(); // place Cards in random order

            // display all 52 Cards in the order in which they are dealt
            for (int i = 0; i < 5; ++i)
            {
                //選擇卡片5張
                myDeckOfCards.DealCard();

            } // end for
            //排序
            myDeckOfCards.getSort();
            
            //textBox1.Visible = true;//需要結果可解開

            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        pictureBox1.Image = myDeckOfCards.checkforImage();
                        break;
                    case 1:
                        pictureBox2.Image = myDeckOfCards.checkforImage();
                        break;
                    case 2:
                        pictureBox3.Image = myDeckOfCards.checkforImage();
                        break;
                    case 3:
                        pictureBox4.Image = myDeckOfCards.checkforImage();
                        break;
                    default:
                        pictureBox5.Image = myDeckOfCards.checkforImage();
                        break;
                }


            }


            textBox1.Text += myDeckOfCards.checkforCard() + "\r\n";
            label1.Text = myDeckOfCards.checkforCard();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        } // end Main



    }
}
