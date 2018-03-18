using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n/2, n/2];
            for (int i = 0; i < n; i++) ;
	    Console.ReadKey();
        }
        public static void Spiral2(int[,] n)
        {
            int l = n.GetLength(0);
            int m = n.GetLength(1);

            int z = 0;

            int minLm = Math.Min(l, m);
            int length = minLm % 2 == 0 ? minLm / 2 : minLm / 2 + 1;

            for (int k = 0; k < length; k++)
            {
                int i;
                for (i = k; i < m - k; i++)
                    n[k, i] = z++;
                i--;
                int j;
                for (j = k + 1; j < l - k; j++)
                    n[j, i] = z++;
                j--;
                for (i = m - k - 1 - 1; i >= k; i--)
                    n[j, i] = z++;
                i++;
                for (j = --j; j >= k + 1; j--)
                    n[j, i] = z++;
            }
        }
    }
}
