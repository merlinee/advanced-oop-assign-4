using System;
using System.Collections.Generic;

namespace assign_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> numbers = new Dictionary<int, double>();
            numbers.Add(1,5);
            numbers.Add(2,6);
            numbers.Add(3,7);
            numbers.Add(4,5);
            numbers.Add(5,9);
            numbers.Add(6,3);
            numbers.Add(7,1);
            
            foreach(string value in Iterator(numbers))
            {
                Console.WriteLine(value);
            }


        }

        static IEnumerable<string> Iterator(Dictionary<int, double> nums)
        {
            double total = 0;
            int i = 0;
            foreach( KeyValuePair<int, double> num in nums )
            {
                total = total + (num.Key * num.Value);
                i++;
                yield return $"Your total is: {(num.Key * num.Value)}";
            }
            yield return $"Sum total is: {total}";
            yield return $"Average is: {total/i}";
        }

    }
}
