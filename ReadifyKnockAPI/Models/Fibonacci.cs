using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyKnockAPI.Models
{
    public class Fibonacci
    {

        public static long GetNthFibonacci(long n)
        {
            if (n >= 0)
            {
                //Recurrsive Function at the beginning, but fail because of the response time
                /*switch (n)
                {
                    case 0:
                        return 0;
                    case 1:
                        return 1;
                    default:
                        return (GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2));

                }*/

                /*
                 * Use Abraham de Moivre's formula.
                 * but the value is not correct when n is large
                 */
                /*double phi1 = (1 + Math.Sqrt(5)) / 2.0;
                double phi2 = (1 - Math.Sqrt(5)) / 2.0;
                return (long)((Math.Pow(phi1, n) - Math.Pow(phi2, n)) / Math.Sqrt(5));*/

                //Use fast doubling method - https://math.stackexchange.com/questions/1124590/need-help-understanding-fibonacci-fast-doubling-proof
                if (n < 2) return n;
                if (n == 2) return 1;
                long k = n / 2;
                long a = GetNthFibonacci(k + 1);
                long b = GetNthFibonacci(k);
                long result;
                try
                {
                    if (n % 2 == 1)
                        result = checked(a * a + b * b);
                    else
                        result = checked(b * (2 * a - b));
                }
                catch (Exception e)
                {
                    throw e;
                }
                return result;
            }
            else
                return ((long)Math.Pow(-1, n + 1) * GetNthFibonacci(Math.Abs(n)));
        }
    }
}