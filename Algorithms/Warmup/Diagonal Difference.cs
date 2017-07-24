using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int FirstDiagonal = 0;
        int SecondDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            FirstDiagonal += a[i][i];
        }
        int j = n - 1;
        for (int i = 0; i < n; i++)
        {
            SecondDiagonal += a[i][j];
            j -= 1;
        }
        Console.WriteLine(Math.Abs(FirstDiagonal-SecondDiagonal));
    }
}