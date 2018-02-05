using System;


namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Please enter your name to see its reverse.");
                Console.ResetColor();

                string name = Console.ReadLine().ToUpper();
                char[] nameArray = name.ToCharArray();


                Array.Reverse(nameArray);

                foreach (char nameChar in nameArray)
                {
                    Console.Write(nameChar);
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("       Another name? [Y or N]");
                Console.ResetColor();

                string playAgainAnswer = Console.ReadLine().ToUpper();


                if (playAgainAnswer == "Y")
                {
                    continue;

                }
                else if (playAgainAnswer == "N")
                {

                    return;

                }
                else
                {
                    return;
                }
                Console.ReadLine();



            }

        }
    }

}
