using System;
namespace uppgift_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Skriv 5 namn: ");
            string[] namn = new string[5];

            for (int i =0; i < 5; i++ )
            {
                namn[i] = Console.ReadLine();
            }
            
                Console.WriteLine(" Dina namn är: ");
                for (int i = 0; i < 5; i++)
            
            {
                
                    Console.WriteLine(namn[i]);
            }

        }
    }
}
