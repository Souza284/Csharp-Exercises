public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter in the Player name: ");

        Player player = new();
        {
            player.namePlayer = Console.ReadLine();
            player.lifePlayer = 100;
        }

        Console.WriteLine("Enter in the Enemy name: ");

        Enemy enemy = new();
        {
            enemy.nameEnemy = Console.ReadLine();
            enemy.lifeEnemy = 100;
        }

        Console.Clear();

        while (player.lifePlayer > 0 && enemy.lifeEnemy > 0)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"{player.namePlayer} turn! What would you like to do? [a/h]: ");
            var playPlayer = Console.ReadLine();

            if (playPlayer == "a")
            {
                var rnd = new Random();
                int a = rnd.Next(1, 31);

                enemy.lifeEnemy -= a;

                Console.WriteLine(player.Attacking(enemy.nameEnemy!, a));
            }
            else
            {
                if (player.lifePlayer <= 100)
                {
                    var rndP = new Random();
                    int h = rndP.Next(1, 10);

                    player.healPlayer = h;
                    player.lifePlayer += h;

                    Console.WriteLine(player.Healing());
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---------------");
            Console.WriteLine($"{player.namePlayer} HP: {player.lifePlayer}\n{enemy.nameEnemy} HP: {enemy.lifeEnemy}");
            Console.WriteLine("---------------");

            Console.WriteLine(enemy.nameEnemy + "turn!");

            var rndE = new Random();
            var A = rndE.Next(1, 31);

            player.lifePlayer -= A;

            Console.WriteLine(enemy.Attacking(player.namePlayer!, A));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
            Console.WriteLine($"{player.namePlayer} HP: {player.lifePlayer}\n{enemy.nameEnemy} HP: {enemy.lifeEnemy}");
            Console.WriteLine("---------------");
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        
        if (player.lifePlayer > enemy.lifeEnemy)
        {
            Console.WriteLine(player.namePlayer + " WINS!");
        }
        else if (player.lifePlayer < enemy.lifeEnemy)
        {
            Console.WriteLine(enemy.nameEnemy + " WINS!");
        }
        else
        {
            Console.WriteLine("DRAW!");
        }
        Console.WriteLine("END GAME");
    }
}

public class Player
{
    public string? namePlayer;
    public int lifePlayer;
    public int healPlayer;
    public int attackPlayer;

    public string Attacking(string _nameEnemy, int attackPlayer)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        return namePlayer + " attacks " + _nameEnemy + " and deals " + attackPlayer + " damage!";
    }

    public string Healing()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        return namePlayer + " heals " + healPlayer;
    }
}

public class Enemy
{
    public string? nameEnemy;
    public int lifeEnemy;
    public int attackEnemy;

    public string Attacking(string _namePlayer, int attackEnemy)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        return nameEnemy + " attacks " + _namePlayer + " and deals " + attackEnemy + " damage!";
    }

}