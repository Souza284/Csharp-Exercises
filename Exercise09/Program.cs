public class Program
{
    public static void Main(string[] args)
    {
        bool isPlayer1 = true;

        var slots = new Dictionary<int, string>()
        {
            {0, "1"},
            {1, "2"},
            {2, "3"},
            {3, "4"},
            {4, "5"},
            {5, "6"},
            {6, "7"},
            {7, "8"},
            {8, "9"}
        };

        void PrintGrid()
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write("|" + slots[i * 3 + j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("---------");
            }
        }

        while (true)
        {
            PrintGrid();

            if (isPlayer1)
            {
                Console.WriteLine("Player 1 turn!");
            }
            else
            {
                Console.WriteLine("Player 2 turn!");
            }

            var choice = Console.ReadLine();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (slots.Contains(new KeyValuePair<int, string>(i * 3 + j,choice!)) && choice != "X" && choice != "O")
                    {
                        
                    }
                }
            }
        }

    }

}