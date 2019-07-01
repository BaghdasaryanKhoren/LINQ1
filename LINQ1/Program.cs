using System;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, -2, 4, 5, -6, 0 };
            string[] website = { "name.com", "name.org", "name.hu", "name.ru", "name.am" };
            var posNum = from n 
                         in nums
                         where n < 0
                         select n;
            foreach (int item in posNum)
                Console.WriteLine(item);
            Console.WriteLine();
            nums[1] = -777;
            foreach (int item in posNum)
                Console.WriteLine(item + " ");
            Console.WriteLine();

            var posNum2 = from n
                         in nums
                         where n > 0
                         orderby n descending
                         select n;
            foreach (int item in posNum2)
                Console.WriteLine(item);
            Console.WriteLine();
            var posNum3 = from n
                         in nums
                          where n > 0
                          orderby n ascending
                          select n;
            foreach (int item in posNum3)
                Console.WriteLine(item);
            Console.WriteLine();
            var webadres = from addr
                          in website
                           group addr
                           by addr.Substring(addr.LastIndexOf('.'));
            foreach (var item in webadres)
                Console.WriteLine(item.Key);
            Console.WriteLine();
            var webadres2 = from addr
                          in website
                           where addr.LastIndexOf('.') != -1
                           group addr 
                           by addr.Substring(addr.LastIndexOf('.'));
            foreach (var item in webadres2)
                foreach (var e in item)
                    Console.WriteLine(e);
        }
    }
}
