using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblem
{
    internal class Quotient_Reminder
    {
        public static void QuotientReminder()
        {
            int x, y, p, q;
            Console.WriteLine("Enter First Number");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            y = Convert.ToInt32(Console.ReadLine());

            p = x / y;
            q = x % y;

            Console.WriteLine(" Quotient is " + q);
            Console.WriteLine(" Reminder is " + p);
        }
    }
}
