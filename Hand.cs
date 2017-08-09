using System;
using System.Collections.Generic;

namespace BlackJack2
{

  class Hand
  {
      public List<Card> CardsInHand;

      public Hand()
      {
        this.CardsInHand = new List<Card>();
      }

      public void Print()
      {
        Console.WriteLine("--------------");
        foreach (Card card in this.CardsInHand)
        {
          card.Print();
        }
      } // end of Print

      public int GetValue()
      {
        int value = 0;
        foreach(Card card in CardsInHand)
        {
          value += card.Value;
        }
        return value;
      }
  } //end of Class Hand
}// End of NameSpace