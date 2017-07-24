using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int x = 0; x < n; x++)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i<n-x?" ":"#");
            }
            Console.WriteLine("");
        }
    }
}