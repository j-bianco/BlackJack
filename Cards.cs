using System;

namespace BlackJack2
{
  public class Card
  {
      public string Name;
      public string Suit;
      public string Face;
      public int Value;

      public Card(string name, string suit, string face, int value)
      {
        this.Name = name;
        this.Suit = suit;
        this.Face = face;
        this.Value = value;
      } // end of Polymorphism
      public void Print()
      {
        // Console.WriteLine($"{this.Name} of {this.Suit}");
        Console.WriteLine("___");
        Console.WriteLine($"|{this.Face}|");
        Console.WriteLine("|__|");
      } // end of Print

      public Card(string suit, int value)
      {
        this.Suit = suit;
        this.Value = value;

        if (value > 1 && value <10)
        {
          this.Name = value.ToString();
          this.Face = value.ToString() + " ";          
        }
        else 
        {
          this.Value = 10;

          switch(value)
          {
            case 10:
              this.Name = "10";
              this.Face = "10";
              break;

            case 11:
              this.Name = "Jack";
              this.Face = "J ";
              break;
            
            case 12:
              this.Name = "Queen";
              this.Face = "Q ";
              break;
            case 13:
              this.Name = "King";
              this.Face = "K ";
              break;
              case 1:
                this.Name = "Ace";
                this.Face = "A ";
                break;
          } //end of Switch
        } //end of If/Else
      } //end of Face Constructor

  } // end of class
} //end of namespace
