import java.util.Scanner;

public class Solution {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int T = sc.nextInt();
		for (int tc = 0; tc < T; tc++) {
			int N = sc.nextInt();
			int K = sc.nextInt();

            int result = 0;
            for (int A = 1; A <= N; A++) {
                for (int B = A + 1; B <= N; B++) {
                    int current = A & B;
                    if (current > result && current < K) {
                        result = current;
                    }
                }
            }
            
			System.out.println(result);
		}

		sc.close();
	}
}