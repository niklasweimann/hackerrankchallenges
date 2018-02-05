#include <stdio.h>
#include <stdlib.h>

void update(int *a, int *b)
{
    // Complete this function
    int a_a = *a;
    *a = *a + *b;
    *b = abs(a_a - *b);
}

int main()
{
    int a, b;
    int *pa = &a, *pb = &b;

    scanf("%d %d", &a, &b);
    update(pa, pb);
    printf("%d\n%d", a, b);

    return 0;
}