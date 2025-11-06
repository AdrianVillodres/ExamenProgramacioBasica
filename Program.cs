using System.Security.Cryptography;

namespace ExamenProgramacio
{
    public class ExamenUF1
    {
        public static void Main()
        {
            const string INTROMSG = "Give me a number beeween 1 and 5, if you answer the number you will find a trap";
            const string ERRORMSG = "Error, give me an integer number between 1 and 5";
            const string TRAPMSG = "You found a trap, lives left: ";
            const string COINMSG = "You found a coin, coins: ";
            const string WINMSG = "You've won!";
            const string LOSEMSG = "You've lost!";
            const int COINSFORWIN = 5;

            int lives, coins, num;

            bool trapFound;
            bool isValid;

            coins = 0;
            lives = 3;
            num = 0;
            

            while(lives > 0 && coins < 5)
            {
                isValid = true;
                Console.WriteLine(INTROMSG);
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ERRORMSG);
                    isValid = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine(ERRORMSG);
                    isValid = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(ERRORMSG);
                    isValid = false;
                }

                if (isValid)
                {
                    if(num == 3)
                    {
                        lives -= 1;
                        Console.WriteLine($"{TRAPMSG}{lives}");
                    }else if(num < 1 || num > 5)
                    {
                        Console.WriteLine(ERRORMSG);
                    }
                    else
                    {
                        coins += 1;
                        Console.WriteLine($"{COINMSG}{coins}");
                    }
                }
            }
            if (coins == COINSFORWIN)
            {
                Console.WriteLine(WINMSG);
            }
            else
            {
                Console.WriteLine(LOSEMSG);
            }


        }
    }
}