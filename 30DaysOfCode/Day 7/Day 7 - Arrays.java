import java.io.*;
import java.util.*;


public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] arr = new int[n];
        for(int i=0; i < n; i++){
            arr[i] = in.nextInt();
        }
        in.close();
        String out = "";
        for(int x = n-1; x>=0; x--)
        {
            out = out + arr[x] + " ";
        }
        System.out.println(out);
    }
}
