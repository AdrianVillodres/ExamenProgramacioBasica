using System.Security.Cryptography;

namespace ExamenProgramacio
{
    public class ExamenUF1
    {
        public static void Main()
        {
            const string INTROMSG = "Give me a number(0 if you want to exit): ";
            const string NUMMSG = "The numbers that are divisors of {0} are: ";
            const string ERRORMSG = "Error, give me a integer number(n > 0) or 0";
            const string OUTPUTMSG = "{0} ";
            const string ZEROMSG = "Programa finalitzat";

            int num;
            int divNum;
            bool isValid;

            
            num = 1;
            while(num != 0)
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
                    if(num > 0)
                    {
                        Console.Write(NUMMSG, num);
                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.Write(OUTPUTMSG, i);
                            }
                        }
                        Console.WriteLine();
                    }
                    else if(num == 0)
                    {
                        Console.WriteLine(ZEROMSG);
                    }
                    else
                    {
                        Console.WriteLine(ERRORMSG);
                    }
                }

            }


            
        }
    }
}