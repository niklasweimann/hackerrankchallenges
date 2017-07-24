using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        double negativeCount=0.0,positiveCount=0.0,zeroCount=0.0;
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        for(int i = 0; i < n; i++)
        {
            int num = arr[i];
            if(num<0){
                negativeCount++;
            }else if(num>0){
                positiveCount++;
            }else{
                zeroCount++;
            }
        }
        Console.WriteLine(positiveCount/n);
        Console.WriteLine(negativeCount/n);
        Console.WriteLine(zeroCount/n);
    }
}
