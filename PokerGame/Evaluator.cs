using System.Diagnostics.Contracts;

namespace PokerGame;

public class Evaluator
{
    CardCombinator cardCombinator;
    private List<int>? cardPoints;

    public void CompareTo(Card card)
    {

    }
    public bool IsAnyFlush(List<Card> cards)
    {
        return false;
    }
    public bool IsAnyStright(List<Card> cards)
    {
        return false;
    }
    public bool IsAnyPair(List<Card> cards)
    {
        return false;
    }

}
