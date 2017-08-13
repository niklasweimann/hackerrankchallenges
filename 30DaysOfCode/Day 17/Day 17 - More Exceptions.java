import java.util.*;
import java.io.*;
//Write your code here
class Calculator{
    public int power(int pN, int pP) throws Exception
    {
        int mN = pN;
        int mP = pP;
        int result = 1;
        if(mN<0 || mP<0)
            throw new Exception("n and p should be non-negative");
        else
        {
            for(int i = 1; i <= mP; i++)
            {
                result = result * mN;
            }
        }
        return result;
    }
}
class Solution{

    public static void main(String[] args) {
    
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        while (t-- > 0) {
        
            int n = in.nextInt();
            int p = in.nextInt();
            Calculator myCalculator = new Calculator();
            try {
                int ans = myCalculator.power(n, p);
                System.out.println(ans);
            }
            catch (Exception e) {
                System.out.println(e.getMessage());
            }
        }
        in.close();
    }
}
