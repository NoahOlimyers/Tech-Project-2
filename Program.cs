using System;

namespace Tech_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for input
            int[] i = new int[1];
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            i[0] = Convert.ToInt32(Console.ReadLine());
            
            if (i[0]>=90)
            {
                Console.WriteLine("A");
            }
            else if (i[0] >=80 && i[0] < 90 )
            {
                Console.WriteLine("B");
            }
            else if (i[0] >= 70 && i[0] < 80)
            {
                Console.WriteLine("C");
            }
            else if (i[0] >= 60 && i[0] < 70)
            {
                Console.WriteLine("D");
            }
            else if (i[0] < 60)
            {
                Console.WriteLine("F");
            }
            else if (i[0] < 0 || i[0] > 100)
            {
                Console.WriteLine("Enter a value between 0 and 100");
            }
            else if (i[0] == 999)
            {
                Console.WriteLine("You entered 999 to stop");
            }
            Console.WriteLine("You're grade is:" + i[0]);
            Console.ReadKey();
        }
    }
}
