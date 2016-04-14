
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150310_A2_03356013
{
    public class DeckOfCards
    {

        private Card[] deck; // array of Card objects
        private int currentCard; // index of next Card to be dealt (0-51)
        private const int NUMBER_OF_CARDS = 52; // constant number of Cards
        private Random randomNumbers; // random number generator
        private int[] cardSuit = new int[5];
        private int[] cardFace = new int[5];
        private int[] faces ={  13, 12, 11, 10, 9, 
         8, 7, 6, 5, 4, 3, 2 ,1};
        private int[] suits = { 0, 1, 2, 3 };
        private int currentImage;
        String str;

        // constructor fills deck of Cards
        public DeckOfCards()
        {


            deck = new Card[NUMBER_OF_CARDS]; // create array of Card objects

            currentCard = 0; // set currentCard so deck[ 0 ] is dealt first  
            randomNumbers = new Random(); // create random number generator

            // populate deck with Card objects
            for (int count = 0; count < deck.Length; ++count)
                deck[count] =
                   new Card(faces[count % 13], suits[count / 13]);
        } // end DeckOfCards constructor

        // shuffle deck of Cards with one-pass algorithm
        public void Shuffle()
        {
            // after shuffling, dealing should start at deck[ 0 ] again
            currentCard = -1; // reinitialize currentCard
            currentImage = 0;
            // for each Card, pick another random Card and swap them
            for (int first = 0; first < deck.Length; ++first)
            {
                // select a random number between 0 and 51 
                int second = randomNumbers.Next(NUMBER_OF_CARDS);

                // swap current Card with randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            } // end for
        } // end method Shuffle
        public void DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < 5)
            {
                currentCard++;

                cardSuit[currentCard] = deck[currentCard].getSuit();
                cardFace[currentCard] = deck[currentCard].getFace();
                // return cardFace[currentCard] + " of " + cardSuit[currentCard]; 

            }

        } // end method DealCard
        public string getSort()
        {   //排序
            for (int allcheck = 0; allcheck < cardSuit.Length; allcheck++)
            {
                for (int sort = 0; sort < cardSuit.Length - 1; sort++)
                {
                    if (cardFace[sort] < cardFace[sort + 1])
                    {
                        int temp = 0;
                        int temp1 = 0;


                        temp = cardFace[sort + 1];
                        cardFace[sort + 1] = cardFace[sort];
                        cardFace[sort] = temp;

                        temp1 = cardSuit[sort + 1];
                        cardSuit[sort + 1] = cardSuit[sort];
                        cardSuit[sort] = temp1;

                    }
                }
            }

            String sttr = "";
            for (int o = 0; o < cardSuit.Length; o++)
            {

                sttr += cardFace[o] + " of " + cardSuit[o] + "\r\n";

            }
            return sttr;
        }
        public Image checkforImage()
        {

            currentImage++;

            if (currentImage == 1)
            {
                str = cardSuit[currentImage - 1].ToString() + cardFace[currentImage - 1].ToString();
                return Image.FromFile(str + ".gif");
            }
            else if (currentImage == 2)
            {

                str = cardSuit[currentImage - 1].ToString() + cardFace[currentImage - 1].ToString();
                return Image.FromFile(str + ".gif");

            }
            else if (currentImage == 3)
            {

                str = cardSuit[currentImage - 1].ToString() + cardFace[currentImage - 1].ToString();
                return Image.FromFile(str + ".gif");

            }
            else if (currentImage == 4)
            {

                str = cardSuit[currentImage - 1].ToString() + cardFace[currentImage - 1].ToString();
                return Image.FromFile(str + ".gif");
            }
            else
            {

                str = cardSuit[currentImage - 1].ToString() + cardFace[currentImage - 1].ToString();
                return Image.FromFile(str + ".gif");
            }

        }
        public string checkforCard()
        {

            String answer = "";

            //先排序AKQJ10987654321

            // cardSuit[0]= 1 ;
            //  cardSuit[1] = 2;
            //  cardSuit[2] = 1;
            // cardSuit[3] = 3;
            // cardSuit[4] = 2;

            //  faces[0] = 11;
            //  faces[1] =3;
            //  faces[2] = 6;
            //  faces[3] = 6;
            //  faces[4] = 5;

            // 開始判斷牌組

            if ((cardSuit[0] == cardSuit[1] && cardSuit[1] == cardSuit[2] && cardSuit[2] == cardSuit[3] && cardSuit[3] == cardSuit[4]) && (cardFace[0] == 13 && cardFace[1] == 12 && cardFace[2] == 11 && cardFace[3] == 10 && faces[4] == 9))
            {
                answer = "Royal Straight";

            }
            else
            {


                if ((cardSuit[0] == cardSuit[1] && cardSuit[1] == cardSuit[2] && cardSuit[2] == cardSuit[3] && cardSuit[3] == cardSuit[4]) && ((cardFace[0] - cardFace[1]) == 1 && (cardFace[1] - cardFace[2]) == 1 && (cardFace[2] - cardFace[3]) == 1 && (cardFace[3] - cardFace[4]) == 1))
                {

                    answer = "Straight Flush";


                }
                else
                {


                    if ((cardFace[0] == cardFace[1] && cardFace[1] == cardFace[2] && cardFace[2] == cardFace[3]) | (cardFace[4] == cardFace[3] && cardFace[3] == cardFace[2] && cardFace[2] == cardFace[1]))
                    {


                        answer = "Four of a kind";
                    }
                    else
                    {

                        if (((cardFace[0] == cardFace[1] && cardFace[1] == cardFace[2]) && (cardFace[3] == cardFace[4])) | ((cardFace[4] == cardFace[3] && cardFace[3] == cardFace[2]) && (cardFace[1] == cardFace[0])))
                        {


                            answer = "Full house";
                        }
                        else
                        {


                            if ((cardSuit[0] == cardSuit[1] && cardSuit[1] == cardSuit[2] && cardSuit[2] == cardSuit[3] && cardSuit[3] == cardSuit[4]))
                            {

                                answer = "Flush";

                            }
                            else
                            {

                                if ((cardFace[0] - cardFace[1]) == 1 && (cardFace[1] - cardFace[2]) == 1 && (cardFace[2] - cardFace[3]) == 1 && (cardFace[3] - cardFace[4]) == 1)
                                {

                                    answer = "Straight";


                                }
                                else
                                {

                                    if ((cardFace[0] == cardFace[1] && cardFace[1] == cardFace[2]) | (cardFace[2] == cardFace[1] && cardFace[2] == cardFace[3]) | (cardFace[4] == cardFace[3] && cardFace[3] == cardFace[2]))
                                    {

                                        answer = "Three of a kind";


                                    }
                                    else
                                    {


                                        if ((cardFace[0] == cardFace[1] && cardFace[3] == cardFace[2]) | (cardFace[4] == cardFace[3] && cardFace[0] == cardFace[1]) | (cardFace[4] == cardFace[3] && cardFace[2] == cardFace[1]))
                                        {

                                            answer = "Two pair";


                                        }
                                        else
                                        {


                                            if ((cardFace[0] == cardFace[1]) | (cardFace[1] == cardFace[2] | (cardFace[2] == cardFace[3]) | (cardFace[3] == cardFace[4])))
                                            {

                                                answer = "One pair";


                                            }
                                            else
                                            {

                                                answer = "High card";

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return answer;


        }


    }

}
