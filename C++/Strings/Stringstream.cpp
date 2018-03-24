#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str)
{
    // Complete this function
    stringstream ss(str);
    char ch;
    int curr;
    vector<int> res;

    while (!ss.eof())
    {
        ss >> curr >> ch;
        res.push_back(curr);
    }
    return res;
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