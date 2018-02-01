#include <iostream>
#include <cstdio>
using namespace std;

int main()
{
    // Complete the code.
    int m_int;
    long m_long;
    char m_char;
    float m_float;
    double m_double;
    scanf("%d %ld %c %f %lf", &m_int, &m_long, &m_char, &m_float, &m_double);
    printf("%d \n%ld \n%c \n%f \n%lf", m_int, m_long, m_char, m_float, m_double);
    return 0;
}