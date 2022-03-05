using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = System.IO.File.ReadAllLines(@"C:\Users\Public\WordsFolder\Words.txt");
            Random rand = new Random();
            int FST = rand.Next(100);
            int SND = rand.Next(100);
            int TRD = rand.Next(100);
            int FTH = rand.Next(100);
            string first_answer;
            string second_answer;
            string third_answer;
            string fourth_answer;

            for (; ; )
            {
                Console.Clear();
                int choose;
                Console.WriteLine("\nMENU:\n");
                Console.WriteLine("Hello in Memory Game!");
                Console.WriteLine("Write number 1 and press enter, to take level EASY");
                Console.WriteLine("Write number 2 and press enter, to take level HARD");
                Console.WriteLine("Write number 3 and press enter, to exit the game!");
                Console.WriteLine("Choose a level of game:");
                choose = int.Parse(Console.ReadLine());


                if (choose == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nWelcome in Memory Game");
                    Console.WriteLine("Level EASY");
                    Console.WriteLine("Press enter to start!");
                    Console.ReadLine();
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        int j;
                        j = 10 - i;
                        Console.Clear();
                        Console.WriteLine("Tries remaining: " + j);
                        Console.WriteLine("1\t2\t3\t4\nX\tX\tX\tX");

                        /* Console.WriteLine(words[FST]);
                         Console.WriteLine(words[SND]);
                         Console.WriteLine(words[TRD]);
                         Console.WriteLine(words[FTH]);*/

                        Console.WriteLine("Enter your answer to the first word:");
                        first_answer = string.Format(Console.ReadLine());

                        if (first_answer == words[FST])
                        {
                            Console.Clear();
                            /* Console.WriteLine(words[FST]);
                             Console.WriteLine(words[SND]);
                             Console.WriteLine(words[TRD]);
                             Console.WriteLine(words[FTH]);
                             Console.WriteLine();*/

                            Console.WriteLine("1\t2\t3\t4");
                            Console.WriteLine(first_answer + "\tX\tX\tX");
                            Console.WriteLine("Enter your answer to the second word:");
                            second_answer = string.Format(Console.ReadLine());

                            if (second_answer == words[SND])
                            {
                                Console.Clear();
                                /*  Console.WriteLine(words[FST]);
                                  Console.WriteLine(words[SND]);
                                  Console.WriteLine(words[TRD]);
                                  Console.WriteLine(words[FTH]);
                                  Console.WriteLine();*/

                                Console.WriteLine("1\t2\t3\t4");
                                Console.WriteLine(first_answer + '\t' + second_answer + "\tX\tX");
                                Console.WriteLine("Enter your answer to the third word:");
                                third_answer = string.Format(Console.ReadLine());

                                if (third_answer == words[TRD])
                                {
                                    Console.Clear();
                                    /* Console.WriteLine(words[FST]);
                                     Console.WriteLine(words[SND]);
                                     Console.WriteLine(words[TRD]);
                                     Console.WriteLine(words[FTH]);
                                     Console.WriteLine();*/

                                    Console.WriteLine("1\t2\t3\t4");
                                    Console.WriteLine(first_answer + '\t' + second_answer + '\t' + third_answer + '\t' + "X");
                                    Console.WriteLine("Enter your answer to the fourth word:");
                                    fourth_answer = string.Format(Console.ReadLine());

                                    if (fourth_answer == words[FTH])
                                    {
                                        Console.Clear();
                                        Console.WriteLine("1\t2\t3\t4");
                                        Console.WriteLine(first_answer + '\t' + second_answer + '\t' + third_answer + '\t' + fourth_answer);

                                        Console.WriteLine("Congratulation!\tYou win!\npress eneter to end game!\n");
                                        Console.ReadLine();

                                        Environment.Exit(0);
                                    }
                                }
                            }
                        }
                        else
                        {

                            Console.WriteLine("Wrong answer, press enter and try again");
                            Console.ReadLine();
                        }
                    }
                    int over;
                    Console.Clear();
                    Console.WriteLine("Game over!\nWill you restart game? Write any key and try again!\nWrite number 4 to exit the game:");
                    over = int.Parse(Console.ReadLine());
                    if (over == 4)
                    {
                        Environment.Exit(0);
                    }
                }
                else if (choose == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nWelcome in Memory Game");
                    Console.WriteLine("Level HARD");
                    Console.WriteLine("Press enter to start!");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choose == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong answer, press enter and try again");
                    Console.ReadLine();

                }

            }
        }
    }
}
