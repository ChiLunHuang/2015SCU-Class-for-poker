using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150310_A2_03356013
{
    public class Card
    {

        private int face; // face of card ("Ace", "Deuce", ...)
        private int suit; // suit of card ("Hearts", "Diamonds", ...)

        // two-parameter constructor initializes card's face and suit
       
        public Card(int cardFace, int cardSuit)
        {
            face = cardFace; // initialize face of card
            suit = cardSuit; // initialize suit of card
            
          
        } // end two-parameter Card constructor

        // return string representation of Card
  

        public int getFace()
        {


        return face;

}
        public int getSuit()
        {


        return suit;

}
    
    }
}
