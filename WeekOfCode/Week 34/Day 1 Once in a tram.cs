using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankWeekOfCode
{
    class Program
    {
        static Day1 mDay1 = new Day1();
        static void Main(String[] args)
        {
            int cDay = 2;
            Console.WriteLine("--- Hacker Rank Week of Code 34 ---");
            Console.WriteLine("");
            string result;
            //Day 1
            if (cDay == 1 || cDay == 0)
            {
                var day1 = new string[] { "---Begin of Day 1---",
                    "Day 1: Once in a tram",
                    "SampleInput: 555555 Sample Output: 555564",
                    "Input: 555555",
                    result = Day1.run(555555),
                    "Output: " + result,
                    "--- End of Day 1 ---",
                    "" };
                foreach (var item in day1)
                {
                    Console.WriteLine(item);
                }
            }
            //Day 2
            if (cDay == 2 || cDay == 0)
            {
                var day2 = new string[] { "---Begin of Day 2---",
                    "Day 2: Maximum Gcd and Sum",
                    "SampleInput: \"5\", \"3 1 4 2 8\", \"5 2 12 8 3\" Sample Output: 16",
                    "Input: \"5\", \"3 1 4 2 8\", \"5 2 12 8 3",
                    result = Day2.run("5", "3 1 4 2 8", "5 2 12 8 3"),
                    "Output: " + result, "--- End of Day 2 ---", "" };
                foreach (var item in day2)
                {
                    Console.WriteLine(item);
                }
            }
            //Day 3
            if (cDay == 3 || cDay == 0)
            {
                var day3 = new string[] { "---Begin of Day 3---",
                    "Day 3: Same Occurence",
                    "SampleInput: --- Sample Output: ---",
                    "Input: ---",
                    result = Day3.run(1),
                    "Output: " + result,
                    "--- End of Day 3 ---",
                    "" };
                foreach (var item in day3)
                {
                    Console.WriteLine(item);
                }
            }
            //Day 4
            if (cDay == 4 || cDay == 0)
            {
                var day4 = new string[] { "---Begin of Day 4---",
                    "Day 4: Recurrent on a Tree",
                    "SampleInput: --- Sample Output: ---",
                    "Input: ---",
                    result = Day4.run(1),
                    "Output: " + result,
                    "--- End of Day 4 ---",
                    "" };
                foreach (var item in day4)
                {
                    Console.WriteLine(item);
                }
            }
            //Day 5
            if (cDay == 5 || cDay == 0)
            {
                var day5 = new string[] { "---Begin of Day 5---",
                    "Day 5: Magic Cards",
                    "SampleInput: --- Sample Output: ---",
                    "Input: ---",
                    result = Day5.run(1),
                    "Output: " + result,
                    "--- End of Day 5 ---",
                    "" };
                foreach (var item in day5)
                {
                    Console.WriteLine(item);
                }
            }
            //Day 6
            if (cDay == 6 || cDay == 0)
            {
                var day6 = new string[] { "---Begin of Day 6---",
                    "Day 6: Path Statistics",
                    "SampleInput: --- Sample Output: ---",
                    "Input: ---",
                    result = Day6.run(1),
                    "Output: " + result,
                    "--- End of Day 6 ---",
                    "" };
                foreach (var item in day6)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}