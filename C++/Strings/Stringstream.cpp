#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str)
{
    // Complete this function
    stringstream ss(str);
    int count = countSubstring(str, ",");
    vector<int> intArr(0);
    for (int i = 0; i < count + 1; i++)
    {
        int j;
        char ch;
        ss >> j >> ch;
        intArr.insert(intArr.end(), j);
    }
    return intArr;
}

int main()
{
    string str;
    cin >> str;
    vector<int> integers = parseInts(str);
    for (int i = 0; i < integers.size(); i++)
    {
        cout << integers[i] << "\n";
    }

    return 0;
}
