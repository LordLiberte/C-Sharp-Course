using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // Ensure you have the System.Numerics assembly referenced for BigInteger

namespace Loop_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger [] nums = new BigInteger[1000];
            
            for (int i = 0; i < 1000; i++)
            {
                if (i!= 0)
                {
                    nums[i] = (nums[i - 1]) * 3;
                }
                else
                {
                    nums[i] = 0 + 2;
                }
               
            }

            
            foreach (BigInteger num in nums)
            {
                Console.WriteLine(num*100);

            }


            string[] amigos = new string[5] { "Juan", "Pedro", "Maria", "Jose", "Ana" };

            foreach (string amigo in amigos)
            {
                Console.WriteLine(amigo);
            }
        }
    }
}
