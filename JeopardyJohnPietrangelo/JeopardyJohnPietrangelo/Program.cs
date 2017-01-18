//John Pietrangelo CIS345 Tues/Thurs 9am
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JeopardyJohnPietrangelo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool switchTurn = false;
            string input1;
            int player1RunScore = 0;
            int player2RunScore = 0;
            int columNum = 0;
            int rowNum = 0;
            string[] categories = { "Math", "Science", "History", "Sports", "Politics", "Film" };
           
            int[,] questionValues = { { 200, 200, 200, 200, 200, 200},
                                      { 400, 400, 400, 400, 400, 400},
                                      { 600, 600, 600, 600, 600, 600},
                                      { 800, 800, 800, 800, 800, 800},
                                      {1000,1000,1000,1000,1000,1000} };

            do
            {
                Clear();
              WriteLine("{0,55}","Welcome to the game Jeopardy!\n\n\n");

              for (int cat = 0; cat < categories.Length; cat++)
              {
                    Write("{0,10} ", categories[cat]);
              }
                WriteLine("\n");
            for (int row = 0; row < questionValues.GetLength(0); row++)
            {
                for (int col = 0; col < questionValues.GetLength(1); col++)
                {
                    Write("{0,10} ", questionValues[row, col]);
                }
                    WriteLine();
                    WriteLine();
            }
                for (int turn = 0; turn < questionValues.Length; turn++)
                {
                    switchTurn = !switchTurn;
                    if (switchTurn == true)
                    {
                        Write("Player 1, choose a category.");
                         string colum =ReadLine().ToLower();
                        switch (colum)
                        {
                            case "math":
                                columNum = 0;
                                break;
                            case "science":
                                columNum = 1;
                                break;
                            case "history":
                                columNum = 2;
                                break;
                            case "sports":
                                columNum = 3;
                                break;
                            case "politics":
                                columNum = 4;
                                break;
                            case "film":
                                columNum = 5;
                                break;
                            default:
                                break;
                        }
                        Write("Player 1, choose a dollar value.");
                        string row = ReadLine();
                        switch (row)
                        {
                            case "200":
                                rowNum = 0;
                                break;
                            case "400":
                                rowNum = 1;
                                break;
                            case "600":
                                rowNum = 2;
                                break;
                            case "800":
                                rowNum = 3;
                                break;
                            case "1000":
                                rowNum = 4;
                                break;
                            default:
                                break;
                        }


                    }
                    else
                    {
                        Write("Player 2, choose a category.");
                        string colum = ReadLine().ToLower();
                        switch (colum)
                        {
                            case "math":
                                columNum = 0;
                                break;
                            case "science":
                                columNum = 1;
                                break;
                            case "history":
                                columNum = 2;
                                break;
                            case "sports":
                                columNum = 3;
                                break;
                            case "politics":
                                columNum = 4;
                                break;
                            case "film":
                                columNum = 5;
                                break;
                            default:
                                break;
                        }
                        Write("Player 2, choose a dollar value.");
                        string row = ReadLine();
                        switch (row)
                        {
                            case "200":
                                rowNum = 0;
                                break;
                            case "400":
                                rowNum = 1;
                                break;
                            case "600":
                                rowNum = 2;
                                break;
                            case "800":
                                rowNum = 3;
                                break;
                            case "1000":
                                rowNum = 4;
                                break;
                            default:
                                break;
                        }
                        
                    }
                }

                //after all columns advance to new line
                WriteLine("\t\t\tWould you Like to Play again? \n\n\tP = Press 'E' to exit or any other key to play again.");

                input1 = Console.ReadLine().ToLower();
                if (input1 == "e")
                {
                    exit = !exit;
                }
                else
                {
                    player1RunScore = 0;
                    player2RunScore = 0;
                   
                }
            

            } while (!exit);
            
               
           
             

        }
    }
}
