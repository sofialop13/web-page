using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            if (IsDivisibleBy(x, 2))
            {

                Console.WriteLine("That's even");
            }
            else
            {
                Console.WriteLine("That's Odd");

            }
            


            /*         for (int i = 0; i < 100; i++)
                     {
                         if (i % 3 == 0)
                         {
                             Console.Write("Fizz");

                         }
                         else { }







                         if (i % 5 == 0)

                         {
                             Console.Write("Fuzz");
                         }

                         if (i % 7 == 0)
                         {
                             Console.Write("bang");
                         }
                         if (i % 11 == 0)
                         {
                             Console.Write("Bong");
                         }
                         Console.WriteLine();

                         /*         for(int i = 0; i < 5; i++)
                                  {
                                      Console.WriteLine(i);

                                  }

                                  Console.WriteLine("book");
                                  string name = "Sofia";
                                  Console.WriteLine(name);
                                  Console.WriteLine("age");
                                  int age = 20;
                                  Console.WriteLine(age);
                                  int magicnumber = int.Parse(Console.ReadLine());
                                  Console.WriteLine(magicnumber * 2);
                                  if (magicnumber % 2==0)
                                  {
                                      Console.WriteLine("yes");
                                  }
                                  else
                                      Console.WriteLine("no");*/







        }


    static int timesbytwo(int x)
    {
        return x * 2;
    }


    static int timesbythree(int x)
    {
        return x * 3;
    }
    static bool IsDivisibleBy(int x, int y)
    {
            int remaider = x % y;
            return remaider == 0;

          

            

    }
    }
}
