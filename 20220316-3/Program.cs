using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars;
            Console.Write("Stars:");
            stars = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<stars;i++)
            {
                Console.Write("哭阿");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
