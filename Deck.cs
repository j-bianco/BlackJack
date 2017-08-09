using System;
using System.Collections.Generic;

namespace BlackJack2
{
   class Deck
  {
    public List<Card> deck;

    public Deck()
    {
      this.deck = new List<Card>();
    }

    public void Initialize()
    {
      for (int i =1; i < 14; i++)
      {
        this.deck.Add(new Card("Spades", i));
      }

      for (int i =1; i < 14; i++)
      {
        this.deck.Add(new Card("Hearts", i));
      }

      for (int i =1; i < 14; i++)
      {
        this.deck.Add(new Card("Diamonds", i));
      }

      for (int i =1; i < 14; i++)
      {
        this.deck.Add(new Card("Clubs", i));
      }

    } //end of Initialize

    public void Print()
    {
      Console.WriteLine("");
      Console.WriteLine("Deck of Cards:");
      Console.WriteLine("----------");
      foreach(Card card in deck)
      {
        card.Print();
      }
    } //End of Print

    public void Shuffle()
    {
      Random r = new Random();
      for (int i = 0; i < 10000; i++)
      {
      int first = r.Next(0, 51);
      int second = r.Next(0, 51);
      Card tempCard = this.deck[first];
      this.deck[first] = this.deck[second];
      this.deck[second] = tempCard;
      } 
    } // end of Shuffle

    public Card DealCard()
    {
      Card c = this.deck[0];
      this.deck.RemoveAt(0);
      return c;
    } //end of DealCard

      
  } //end of class Deck
} //end of Namespace