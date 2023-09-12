using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageSystem
{
    internal class Waiting
    {
        public static void Wait()
        {
            Console.Write("\nWait");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\n");
        }
    }
}
