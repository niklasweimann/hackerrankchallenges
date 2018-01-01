import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
       
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        while(sc.hasNextLine())
        {
            String line = sc.nextLine();
            Pattern hiPattern = Pattern.compile("^(h|H){1}(I|i){1} [^d]");
            Matcher m = hiPattern.matcher(line);
            
            if(m.find())
                System.out.println(line);
        }
    }
}