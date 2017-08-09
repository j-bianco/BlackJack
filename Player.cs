using System;

namespace BlackJack2
{
  class Player
  {
      public int Wallet;
      public Hand hand;

      public Player()
      {
        hand = new Hand();
      }

      public void Print()
      {
        Console.WriteLine("Player Stats: ");
        Console.WriteLine("--------------");
        this.hand.Print();
      } //end of Print

  } //end of class Player
} //end of Namespace
