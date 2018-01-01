import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

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

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] ar = new int[n];
        for(int ar_i = 0; ar_i < n; ar_i++){
            ar[ar_i] = in.nextInt();
        }
        int result = birthdayCakeCandles(n, ar);
        System.out.println(result);
    }
}