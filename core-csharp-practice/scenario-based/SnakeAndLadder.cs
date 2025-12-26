using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Snake and Ladder Game - 26-DEC-2025
namespace BridgeLabzTraining.scenario_based
{
    internal class SnakeAndLadder
    {
        public static void Main(string[] args)
        {
            //create ladders array
            int[] ladderFrom = { 8, 16, 33, 40, 36 };
            int[] ladderTo = { 22, 65, 55, 75, 83 };
            //create snakes ladder
            int[] snakeFrom = { 95, 68, 78, 25, 90 };
            int[] snakeTo = { 15, 23, 48, 6, 86 };

            //board
            int[] board = new int[101];
            //mark board numbers
            for (int i = 1; i <=100; i++)
            {
                board[i] = i;
            }

            //apply ladders on board
            for(int i = 0; i < ladderFrom.Length; i++)
            {
                board[ladderFrom[i]] = ladderTo[i];
            }
            //apply snakes on board
            for(int i = 0;i < snakeFrom.Length; i++)
            {
                board[snakeFrom[i]]=snakeTo[i];
            }

            //number of players
            Console.WriteLine("Enter Number of Players");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            //check for valid number of players
            if (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Invalid Number Of Players");
                return;
            }
            //array to store players position
            int[] playersPosition = new int[numberOfPlayers];

            while (true)
            {
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    bool extraTurn = true;
                    while (extraTurn)
                    {
                        extraTurn = false;

                        Console.WriteLine();
                        Console.WriteLine($"Player {i + 1} turn");
                        
                        int oldPosition = playersPosition[i];
                        //Roll dice
                        int diceNumber = RollDice();
                        Console.WriteLine("Dice Number: " + diceNumber);
                        int newPosition = oldPosition;


                        switch (diceNumber)
                        {
                            case 1:
                                newPosition = MovePlayer(oldPosition, 1);
                                break;

                            case 2:
                                newPosition = MovePlayer(oldPosition, 2);
                                break;
                            case 3:
                                newPosition = MovePlayer(oldPosition, 3);
                                break;
                            case 4:
                                newPosition = MovePlayer(oldPosition, 4);
                                break;
                            case 5:
                                newPosition = MovePlayer(oldPosition, 5);
                                break;
                            case 6:
                                newPosition = MovePlayer(oldPosition, 6);
                                break;
                            default:
                                continue;
                        }
                        //if newPosition increases 100
                        if (newPosition == oldPosition)
                        {
                            Console.WriteLine($"Cannot move stay at {oldPosition}");
                        }
                        else
                        {
                            int finalPosition = ApplySnakeOrLadder(newPosition, board);
                            playersPosition[i] = finalPosition;
                            Console.WriteLine($"Move from to : {oldPosition} -> {finalPosition}");
                        }
                        //check if a player wins
                        if (CheckWin(playersPosition[i]))
                        {
                            Console.WriteLine("Player " + (i + 1) + " Wins. ");
                            return;
                        }
                        //if dice number is 6 the player gets an extra chance
                        if (diceNumber == 6)
                        {
                            Console.WriteLine("Got an Extra Chance.");
                            extraTurn = true;
                        }
                        Console.WriteLine();

                    }
                }

            }
        }
        //Method to roll dice
        public static int RollDice()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        //Method to Move Player
        public static int MovePlayer(int oldPosition,int diceNumber)
        {
            int newPosition = oldPosition + diceNumber;
            if (newPosition > 100)
            {
                return oldPosition;
            }
            else
            {
                return newPosition;
            }

        }
        //Method to check if player wins
        public static bool CheckWin(int position)
        {
            bool result = position == 100 ? true : false;
            return result;
        }
        //Method to check for snakes and ladders
        public static int ApplySnakeOrLadder(int position, int[] board)
        {
            if (board[position] > position)
            {
                Console.WriteLine("A ladder -> move up to higher position.");
            }
            if (board[position] < position)
            {
                Console.WriteLine("A snake -> slide down to lower position.");
            }
            return board[position];
        }

    }
}
