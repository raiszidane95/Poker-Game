namespace PokerGame;

public class Card
{
    public Suit Suit;
    public Number Number;

    public Card(Suit suit, Number number)
    {
        this.Suit = suit;
        this.Number = number;
    }
}
public enum Suit { Heart, Diamond, Spades, Club }
public enum Number { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }