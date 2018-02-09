#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int N;
    cin >> N;
    int *A = new int[N];
    int i = 0;
    while (cin >> A[i++])
        ;
    while (cout << A[--N] << ' ' << N)
        ;
    delete[] A;
    return 0;
}
