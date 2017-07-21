using System;
using System.Linq;

namespace HackerRankWeekOfCode
{
    class Day2
    {
        public static string run(string pN, string pA, string pB)
        {
            int n = Convert.ToInt32(pN);
            string[] A_temp = pA.Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
            string[] B_temp = pB.Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);
            int[] res = maximumGcdAndSum(A, B);
            return res[1]+res[2] + "";
        }

        public static int[] maximumGcdAndSum(int[] A, int [] B)
        {
            if (A.Length == 0 && B.Length == 0)
                return new int[] { 0, 0, 0};
            var returnBestArray = new int[3] { 0, 0, 0 };
            int temp = 0;
            for (int x = 0; x < A.Length; x++)
            {
                for (int y = 0; y < B.Length; y++)
                {
                    if (A[x] == B[y])
                    {
                        temp = A[x];
                    }
                    else if (A[x] == 0)
                    {
                        temp = B[y];
                    }
                    else if (B[y] == 0)
                    {
                        temp = A[x];
                    }
                    else if (A[x] < returnBestArray[0] || B[y] < returnBestArray[0])
                    {
                        returnBestArray[0] = returnBestArray[0];
                    }
                    else
                    {
                        temp = GCD(A[x], B[y]);
                    }
                    if (returnBestArray[0] < temp)
                    {
                        returnBestArray[0] = temp;
                        returnBestArray[1] = A[x];
                        returnBestArray[2] = B[y];
                    }
                }
            }
            return returnBestArray;
        }

        static int GCD(int a, int b)
        {
            int shift;

            int x = a;
            int y = b;

            if (x == 0) return y;
            if (y == 0) return x;

            for (shift = 0; ((x | y) & 1) == 0; ++shift)
            {
                x >>= 1;
                y >>= 1;
            }
            while ((x & 1) == 0)
            {
                x >>= 1;
            }
            do
            {
                while ((y & 1) == 0)
                    y >>= 1;

                if (x > y)
                {
                    uint temp = Convert.ToUInt32(y); y = x; x = Convert.ToInt32(temp);
                }
                y = y - x;
            } while (y != 0);
            return x << shift;
        }
    }
}