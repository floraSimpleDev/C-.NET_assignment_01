using System;
using System.ComponentModel;

namespace AdvancedGame17
{
    internal class ConsoleGame
    {
        const int MapSize = 100;
        static int[] map = new int[MapSize];

        const int EMPTY = 0;
        const int MINE = 1;
        const int TUNNEL = 2;
        const int LUCKY_WHEEL = 3;
        const int PAUSE = 4;

        static int playerA = 0;
        static int playerB = 0;
        static int currentPlayer = 0;

        static Random random = new Random();
        static bool[] skipTurn = new bool[2];

        static bool isGameOver = false;

        public static void Main(string[] args)
        {
            InitMap();

            Console.WriteLine("\n Initiating map successfully! Let's start!");
            for (int round = 1; round <= 30; round++)
            {
                if (isGameOver) break;

                Console.WriteLine($"\n------ Round {round} ------\n");

                PlayTurn();
                DrawMap();

                if (!isGameOver)
                {
                    Console.WriteLine("\nPress any key to continue to the next round...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nGame Over! Thanks for playing this game! ");
        }

        static void InitMap()
        {
            PlaceRandomEvents(MINE, 5, random);
            PlaceRandomEvents(TUNNEL, 3, random);
            PlaceRandomEvents(LUCKY_WHEEL, 3, random);
            PlaceRandomEvents(PAUSE, 2, random);
        }

        static void PlaceRandomEvents(int eventType, int count, Random randomMap)
        {
            int placed = 0;

            while (placed < count)
            {
                int index = randomMap.Next(1, MapSize - 1);

                if (map[index] == EMPTY && index != playerA && index != playerB)
                {
                    map[index] = eventType;
                    placed++;
                }
            }
        }

        static void PlayTurn()
        {
            if (skipTurn[currentPlayer])
            {
                Console.WriteLine($"Player {(currentPlayer == 0 ? "A" : "B")} is skipping this turn.");
                skipTurn[currentPlayer] = false;
                currentPlayer = 1 - currentPlayer;
                return;
            }
            
            int dice = random.Next(1, 7);
            Console.WriteLine($"Player {(currentPlayer == 0 ? "A" : "B")} get {dice} dice");

            if (currentPlayer == 0)
            {
                playerA += dice;
                if (playerA >= MapSize)
                {
                    Console.WriteLine("\n Player A has reached the end of the map! Player A wins!");
                    isGameOver = true;
                }
                HandleEvent(0, ref playerA, ref playerB);
            }
            else
            {
                playerB += dice;
                if (playerB >= MapSize)
                {
                    Console.WriteLine("\n Player B has reached the end of the map! Player B wins!");
                    isGameOver = true;
                }
                HandleEvent(1, ref playerB, ref playerA);
            }

            currentPlayer = 1 - currentPlayer;
        }

        private static void HandleEvent(int playerIndex, ref int selfPos, ref int opponentPos)
        {
            int eventType = map[selfPos];
            string playerName = playerIndex == 0 ? "A" : "B";

            switch (eventType)
            {
                case MINE:
                    Console.WriteLine($"Player {playerName} hit a mine! Back to start.");
                    selfPos = -6;
                    if (selfPos < 0) selfPos = 0;
                    break;
                case TUNNEL:
                    Console.WriteLine($"Player {playerName} found a tunnel! Move forward 10 spaces.");
                    selfPos += 10;
                    if (selfPos >= MapSize) selfPos = MapSize - 1;
                    break;
                case LUCKY_WHEEL:
                    Console.WriteLine($"Player {playerName} hit the Lucky Wheel!");
                    Console.WriteLine("Choose an action: 1. Swap your position with your competitor; 2. Let your competitor move back 6 spaces. ");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Swapping positions with competitor.");
                        int temp = selfPos; ;
                        selfPos = opponentPos;
                        opponentPos = temp;
                    }
                    else
                    {
                        Console.WriteLine("Moving competitor back 6 spaces.");
                        opponentPos -= 6;
                        if (opponentPos < 0) opponentPos = 0;
                    }
                    break;
                case PAUSE:
                    Console.WriteLine($"Player {playerName} hit a pause! Skipping next turn.");
                    skipTurn[playerIndex] = true;
                    break;
                default:
                    Console.WriteLine($"Player {playerName} moved to the ordinary space {selfPos}.");
                    break;
            }
        }

        static void DrawMap()
        {
            for (int i = 0; i < MapSize; i++)
            {
                if (playerA == i && playerB == i)
                {
                    Console.Write("<>  ");
                }
                else if (playerA == i)
                {
                    Console.Write("A  ");
                }
                else if (playerB == i)
                {
                    Console.Write("B  ");
                }
                else
                {
                    Console.Write(GetSymbol(map[i]) + "  ");
                }

                if ((i + 1) % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        private static string GetSymbol(int type)
        {
            return type switch
            {
                MINE => "X",
                TUNNEL => "O",
                LUCKY_WHEEL => "L",
                PAUSE => "P",
                _ => "[]"
            };
        }
    }
}
