using PokerGame;

class Program
{
       
    static void Main()
    {
        GameController gameController = new GameController();
        var players = gameController.players;

        Console.WriteLine("--POKER GAME--");

        foreach (var item in gameController.GetDeckCard()) // gameController.GetTableCard() -> getting deck card that has been intitialized and shuffle
        {
            Console.WriteLine($"{item.Suit} {item.Number}");
        }

        var playerCard = gameController.GetPlayerCard(players[0]);
        Console.WriteLine($"\nlist card player {players[0].GetName()}");
        foreach (var item in playerCard)
        {
            Console.WriteLine($"{item.Number} {item.Suit}");
        }
        gameController.DealTableCard();

        var tableCards = gameController.GetTableCards();

        Console.WriteLine("\nTable Card");
        foreach (var card in tableCards)
        {
            Console.WriteLine($"{card.Suit} {card.Number}");
        }

        var x = Console.ReadKey();
        if (x.Key == ConsoleKey.Spacebar)
        {
            gameController.DealTableCard();
        }
        Console.WriteLine("\n Table Card setelah ditambahkan");
        foreach (var card in tableCards)
        {
            Console.WriteLine($"{card.Suit} {card.Number}");
        }
        
        var river = Console.ReadKey();
        if (river.Key == ConsoleKey.Spacebar)
        {
            gameController.DealTableCard();
        }
        Console.WriteLine("\n Table Card setelah ditambahkan");
        foreach (var card in tableCards)
        {
            Console.WriteLine($"{card.Suit} {card.Number}");
        }

        Console.WriteLine();
        foreach (var item in gameController.GetDeckCard()) // gameController.GetTableCard() -> getting deck card that has been intitialized and shuffle
        {
            Console.WriteLine($"{item.Suit} {item.Number}");
        }
        
        Console.WriteLine($"\nlength deck now : {gameController.GetDeckCard().Count()}");
    }
}