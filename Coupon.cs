using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalFunction
{
    public class Coupon
    {
        public static void CouponNumber()
         {
            int first = 0;
        int temp;
        Console.WriteLine("how many coupon number you required ?");
            int Number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("genreted coupon number");

            for (int i = 0; i<Number; i++)
            {
                Random number = new Random();
        int coupon = number.Next(10000, 100000);

        Console.WriteLine("Coupon : "+coupon);
                Console.ReadLine();
                temp = coupon;
                first = temp;

                if (first != temp)
                {
                    Console.WriteLine("Coupon Are same");
                }
                else
                {
                    Console.WriteLine("Coupon are Different");
                }
                
            }
        }
    }
}
