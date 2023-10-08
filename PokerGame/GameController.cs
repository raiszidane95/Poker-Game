namespace PokerGame;

public class GameController
{
    private int _currentTurn;
    private Stages _currentStage;
    public readonly int _totalBet;
    public readonly int smallBlind = 5;
    public readonly int BigBlind = 10;

    Stages stages;
    private List<Card> _tableCard = new();
    private Deck? _deck = new Deck();
    // Player player1 = new Player();

    public readonly List<IPlayer> players = new();

    public Dictionary<IPlayer, List<Card>?> _playerHandCard;
    public GameController()
    {   
        AddPlayerToList();
        _playerHandCard = new Dictionary<IPlayer, List<Card>?>();
        foreach (IPlayer player in players)
        {
            _playerHandCard[player] = new List<Card>();
        }
        DealPlayerCard(players);
    }

    public void StartGame() // game Start
    {
        // Todo adalah saat game pertama kali dimulai
        // ini tahap awal unutuk pembagian kartu awal
        
        _currentStage = Stages.PreFlop;
        while (_currentStage != Stages.Showdown) // ini tahap preflop
        {
            for (int i = 0; i < players.Count; i++)
            {
                
            }
            _currentStage++;
        }
    }
    public void AddPlayerToList()
    {
        Player player1 = new Player("Ariston", 1);
        Player player2 = new Player("Rais", 2);
        Player player3 = new Player("Zidane", 3);
        Player player4 = new Player("Aris", 4);

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);
        players.Add(player4);
    }
    
    public void DealPlayerCard(List<IPlayer> players)
    {
        foreach (IPlayer player in players)
        {
            for (int i = 0; i < 2; i++) 
            {
                Card holeCard = _deck.listCardDeck[0];
                AddHoleCard(player, holeCard);
                _deck.listCardDeck.RemoveAt(0); 
            }
        }
    }

    public List<Card> GetTableCards()
    {
        return _tableCard;
    }

    private void AddTableCard()
    {
        Card holeCard = _deck.listCardDeck[0];
        _tableCard.Add(holeCard);
        _deck.listCardDeck.RemoveAt(0);
    }
    public void  DealTableCard()
    {
        if (_tableCard.Count <= 1 )
        {
            for (int i = 0; i < 3; i++)
            {
                AddTableCard();
            } 
        }
        else
        {
            AddTableCard();
        }
    }
    public void AddHoleCard(IPlayer player, Card card)
    {
        if (_playerHandCard.ContainsKey(player))
        {
            _playerHandCard[player].Add(card);
        }
        else
        {
            _playerHandCard[player] = new List<Card> { card };
        }
    }
    public List<Card> GetDeckCard()
    {
        return _deck!.listCardDeck!;
    }

    public List<IPlayer> GetListPlayer()
    {
        return players;
    }
    public List<Card> GetPlayerCard(IPlayer player)
    {
        _playerHandCard.TryGetValue(player, out List<Card> playerCard);
        return playerCard;
    }
    public int GetCurrentBet(IPlayer player)
    {
        return 0;
    }
    public int GetCurrentTurn(Player player)
    {
        return player.GetId();
    }
    public void Action(PlayerAction action)
    {
        // TODO
        // if (action == PlayerAction.Fold)
        // {
        // }
    }

    public Evaluator Evaluate(List<Card> cards)
    {
        return new Evaluator();
    }

}

