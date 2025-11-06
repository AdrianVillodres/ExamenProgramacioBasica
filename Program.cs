using System.Security.Cryptography;

namespace ExamenProgramacio
{
    public class ExamenUF1
    {
        public static void Main()
        {
            
            const string INTROMSG = "Introduce the secret code for level: ";
            const string GENDORMSG = "{0} door generated";
            const string DOORSTOOPEN = "You can open the doors: ";
            const string DOORSMSG = "{0} ";
            const string ERRORMSG = "Error, give me a integer number(n > 0)";

            int num;
            int divNum;
            bool isValid;
            Random rand = new Random();
            int randNum;

            isValid = true;
            num = 0;
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
                if (num > 0)
                {
                    randNum = rand.Next(5, 16);
                    Console.WriteLine(GENDORMSG, randNum);
                    Console.Write(DOORSTOOPEN);
                    for (int i = 1; i <= randNum; i++)
                    {
                        if (i % num == 0)
                        {
                            Console.Write(DOORSMSG, i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(ERRORMSG);
                }
            }
                
                    
                
          


            
        }
    }
}