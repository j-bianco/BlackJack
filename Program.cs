using System;
using System.Collections.Generic;

namespace BlackJack2
{
    class Program
    {
        static void Main(string[] args)
        {
        // Setting Variables
            Console.WriteLine("Welcome to the Blackack Tables!");
            Player player = new Player();
            Player dealer = new Player();
            player.Wallet = 1000;
            int bet = 0;

        // Start the Betting and Run the Game
            while (player.Wallet > 0)
            {
        //Reshuffling the Deck
            Deck deck = new Deck();
            deck.Initialize();
            deck.Shuffle();
            player.hand = new Hand();
            dealer.hand = new Hand();

        // How much to Bet?
            Console.WriteLine("");
            Console.WriteLine($"You have ${player.Wallet} in your wallet.");
            Console.Write("How much do you want to wager? ");
            bet =int.Parse(Console.ReadLine());
            player.Wallet -= bet;

            player.hand.CardsInHand.Add(deck.DealCard());
            player.hand.CardsInHand.Add(deck.DealCard());
            Console.WriteLine("");
            Console.WriteLine("Player's Hand:");
            player.hand.Print();
            Console.WriteLine($"Player's Value is: {player.hand.GetValue()}");
            Console.WriteLine("");

            dealer.hand.CardsInHand.Add(deck.DealCard());
            dealer.hand.CardsInHand.Add(deck.DealCard());
            Console.WriteLine("Dealer's Card:");
            // Console.WriteLine($"{dealer.hand.CardsInHand[0].Name} of {dealer.hand.CardsInHand[0].Suit}");
            Console.WriteLine("___");
            Console.WriteLine($"|{dealer.hand.CardsInHand[0].Face}|");
            Console.WriteLine("|__|");
            Console.WriteLine("");

            string input = "";
            
            while ((player.hand.GetValue() < 22 && input != "stay"))
            {
                Console.WriteLine("Do you want to hit or stay?");
                input = Console.ReadLine();
                switch(input)
                {
                    case "hit":
                        player.hand.CardsInHand.Add(deck.DealCard());
                        Console.WriteLine("");
                        Console.WriteLine("Player's Hand:");
                        player.hand.Print();
                        Console.WriteLine($"Player's Value is: {player.hand.GetValue()}");
                        Console.WriteLine("");  
                    break;
                } //End of Hit or Stay Switch
            } // End of Single Hand While Loop

            while (dealer.hand.GetValue() < 17)
            {
                dealer.hand.CardsInHand.Add(deck.DealCard());
            }
                Console.WriteLine("");
                Console.WriteLine("Dealer's Hand:");
                dealer.hand.Print();
                Console.WriteLine($"Dealer's Value is: {dealer.hand.GetValue()}");
                Console.WriteLine("");  
            
            if (player.hand.GetValue() > 21)
                {
                    Console.WriteLine("You have Busted! You lose.");
                }
                else if (dealer.hand.GetValue() > 21) 
                {
                    Console.WriteLine("The Dealer has busted! You win!");
                    player.Wallet += bet * 2;
                }
                else if(player.hand.GetValue() > dealer.hand.GetValue())
                {
                    Console.WriteLine("You beat the Dealer! You win!");
                    player.Wallet += bet * 2;
                }
                else if(player.hand.GetValue() < dealer.hand.GetValue())
                {
                    Console.WriteLine("The Dealer beat you! You Lose!");
                }
                else if(player.hand.GetValue() == dealer.hand.GetValue())
                {
                    Console.WriteLine("Your hand equals the Dealer's! You have pushed.");
                    player.Wallet += bet;
                }
            } //end of bet While Loop
            Console.WriteLine("You have run out of money! Quick, run away before the bouncers catch you!");
        } // end of Main Function
    } // end of class Program
} // end of nameSpace
