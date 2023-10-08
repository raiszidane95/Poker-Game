using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace PokerGame;

public class Player : IPlayer
{
    private int _Id;
    private string? _name;
    private int _chips;

    private bool _isFolded = false;

    public Player(string name, int id)
    {
        _name = name;
        _Id = id;
        _chips = 1000;
    }

    public int GetId()
    {
        return _Id;
    }

    public string GetName()
    {
        return _name!;
    }

    public void SetPlayerId(int playerId)
    {
        _Id = playerId;
    }

    public void SetPlayerName(string playerName)
    {
        _name = playerName;
    }

    public void Fold(bool folded)
    {
        _isFolded = true;
    }

    public int Bet(int amount)
    {
        _chips -= amount;
        return amount;
    }

    public int Bet()
    {
        _chips -= 100;
        return 100;
    }

    public int call()
    {
        // TODO next
        return 0;
    }

    public void Check()
    {
        // Todo next 
    }

    public int GetPlayerChips()
    {
        return _chips;
    }

    public void SetPlayerChips(int chips)
    {
        _chips = chips;
    }
}
