using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        long sum = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        
        Array.Sort(arr);
        Console.WriteLine((sum - arr[arr.Length-1]) + " " + (sum - arr[0]));
    }
}
