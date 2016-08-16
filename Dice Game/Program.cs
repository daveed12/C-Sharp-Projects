using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game_Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            const int die = 6;
            int dieNum;
            int dieNum2;
            int boxCars = 6;
            char input;
            //Checks if user inputed a character
            bool flag = false;
            //Checks if user inputed a valid character
            bool flag2 = false;
            
            
            char[] possible = { 'y', 'n', 'Y', 'N' };
            do
            {
                //Checks whether or not user inputed invalid character
                bool flag3 = false;

                Console.WriteLine("This is a dice game would you like to play? y for yes or n for no");
                flag = char.TryParse(Console.ReadLine(), out input);
                while(flag == false)
                {
                    Console.WriteLine("Please input only one character, thank you");
                    flag = char.TryParse(Console.ReadLine(), out input);
                }
                    for(int i = 0; i<possible.Length; i++)
                    {
                        if (possible[i] == input)
                        {
                            flag2 = true;
                            flag3 = true;
                            break;
                        }
                       
                    
                    }
                while (flag3 == false)
                {
                    Console.WriteLine("Please make sure you input a valid response");
                    char.TryParse(Console.ReadLine(), out input);
                    for (int i = 0; i < possible.Length; i++)
                    {
                        
                        if (possible[i] == input)
                        {
                            flag2 = true;
                            flag3 = true;
                            break;
                        }


                    }
                }
                if (flag2 == true)
                    {
                        if (input == possible[0] || input == possible[2])
                        {
                            Random randomNum = new Random();
                            dieNum = randomNum.Next(1, die + 1);
                            dieNum2 = randomNum.Next(1, die + 1);
                            if (dieNum == 1 && dieNum2 == 1)
                            {
                                Console.WriteLine("You rolled snake eyes!");
                                Console.ReadLine();
                            }
                            else if (dieNum == boxCars && dieNum2 == boxCars)
                            {
                                Console.WriteLine("You rolled box cars");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"You rolled {dieNum:D} and {dieNum2:D}");
                                flag2 = false;
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Goodbye");
                            Console.ReadLine();
                        }
                    }
            }while (flag2 == false);
        }
    }
}
