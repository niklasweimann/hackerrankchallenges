// Score: 4.29 
// Failed TestCase: #1, #3, #4, #5, #6, #7
// Solved TestCase: #0, #2
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner s = new Scanner(System.in);

		int n = s.nextInt();

		String binary = Integer.toBinaryString(n);
		int maxConsecutiveOneNum = 0;
		int consecutiveOneNum = 0;
		for (int i = 0; i < binary.length(); i++) 
        {
			if (binary.charAt(i) == '1') 
            {
				consecutiveOneNum++;
                if(consecutiveOneNum > maxConsecutiveOneNum)
                    maxConsecutiveOneNum = consecutiveOneNum;
			} else 
            {
				consecutiveOneNum = 0;
			}
		}
		System.out.println(maxConsecutiveOneNum);

		s.close();
    }
}