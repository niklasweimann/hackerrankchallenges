using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        // Complete this function
        int tallest = 1;
        int count = 0;
        for(int ar_i = 0; ar_i < n; ar_i++)
        {
            if(tallest < ar[ar_i])
            {
                tallest = ar[ar_i];
            }
        }
        for(int ar_i = 0; ar_i < n; ar_i++)
        {
            if(tallest == ar[ar_i])
            {
                count = count + 1;
            }
        }
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
