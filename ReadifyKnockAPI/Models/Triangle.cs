using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadifyKnockAPI.Models
{
    public class Triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public string isTriangle()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return "Error";
            if (a == b && b == c)
                return "Equilateral";
            try
            {
                if (checked(a + b) > c && checked(b + c) > a && checked(c + a) > b)
                {
                    if (a == b || b == c || c == a)
                        return "Isosceles";
                    else
                        return "Scalene";
                }
                return "Error";
            }
            catch
            {
                return "Error";

            }
        }
    }
}