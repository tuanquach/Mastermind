using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomObject = new Random();
            var randomString = "";

            for (int i = 0; i < 4; i++)
            {
                randomString += randomObject.Next(1, 6).ToString();
            }
            
            for (int i = 0; i < 10; i++)
            {
                var inputString = "";
                var inputNumber = 0;
                var countPlus = 0;
                var resultString = "";
                var checkInputString = false;
                
                do
                {
                    checkInputString = false;
                    Console.Write("Please input a number with 4 digits: ");
                    inputString = Console.ReadLine();

                    if (!int.TryParse(inputString, out inputNumber) || inputString.Length != 4)
                    {
                        checkInputString = true;
                    }
                } while (checkInputString);

                for (int j = 0; j < inputString.Length; j++)
                {
                    for (int k = 0; k < randomString.Length; k++)
                    {
                        if (inputString[j] == randomString[k])
                        {
                            if (j == k)
                            {
                                resultString += "+";
                                countPlus += 1;
                            }
                            else
                            {
                                resultString += "-";
                            }
                        }
                        else
                        {
                            resultString += "";
                        }
                    }
                }

                if (countPlus == 4)
                {
                    Console.WriteLine("++++\nYou win.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{resultString}");

                    if (i == 9)
                    {
                        Console.WriteLine("You lose.");
                    }
                }
            }

            Console.WriteLine($"Random number is: {randomString}");
            Console.ReadLine();
        }
    }
}
