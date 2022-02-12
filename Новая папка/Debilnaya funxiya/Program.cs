using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debilnaya_funxiya
{
    class Program
    {
        static int A(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return A(n - 1, 1);
            else
                return A(n - 1, A(n, m - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(A(2, 2));
            Console.ReadKey();
        }
    }
}
