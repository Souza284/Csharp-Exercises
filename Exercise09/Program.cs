public class Program
{
    public static void Main(string[] args)
    {
        bool isPlayer1 = true;
        int numTurns = 0;

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

        while (!check() && numTurns != 9)
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

            Console.WriteLine("Enter your play: ");
            
            var choice = Console.ReadLine();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (slots.Contains(new KeyValuePair<int, string>(i * 3 + j,choice!)) && choice != "X" && choice != "O")
                    {
                        int grintIndex = Convert.ToInt32(choice) - 1;

                        if (isPlayer1)
                        {
                            slots[grintIndex] = "X";
                        }
                        else
                        {
                            slots[grintIndex] = "O";
                        }

                        numTurns ++;
                    }
                }
            }

            isPlayer1 = !isPlayer1;
        }

        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Console.Write("|" + slots[i * 3 + j] + "|");
            }
            Console.WriteLine();
            Console.WriteLine("---------");
        }

        Console.WriteLine("END GAME!");

        bool check()
        {
            bool row1 = slots[0] == slots[1] && slots[1] == slots[2];
            bool row2 = slots[3] == slots[4] && slots[4] == slots[5];
            bool row3 = slots[6] == slots[7] && slots[7] == slots[8];

            bool column1 = slots[0] == slots[3] && slots[3] == slots[6];
            bool column2 = slots[1] == slots[4] && slots[4] == slots[7];
            bool column3 = slots[2] == slots[5] && slots[5] == slots[8];

            bool diagDown = slots[0] == slots[4] && slots[4] == slots[8];
            bool diagUp = slots[6] == slots[4] && slots[4] == slots[2];

            return row1 || row2 || row3 || column1 || column2 || column3 || diagDown || diagUp;
        }

    }

}