using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> myList = new List<float>();
            int nb = 0;
            float multi = 1;
            float nbUser;
            string answer;

            do
            {


                Console.WriteLine("ajouter un nombre");
                nbUser = Convert.ToSingle(Console.ReadLine());
                myList.Insert(nb, nbUser);
                Console.WriteLine("voulez vous continuer ?");
                answer = Console.ReadLine();
                multi *= nbUser;
                nb++;

            }

            while (answer!="non");

            Console.WriteLine("votre list comprend ces valeurs");
            for (nb = 0; nb < myList.Count; nb++)
            {

                Console.WriteLine(myList[nb]);
                
            }
            
            
            Console.WriteLine($"la multiplication de ces valeurs vaut {multi}");




        }
    }
}
