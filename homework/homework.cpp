#include <iostream>
using namespace std;

int main()
{
    int star;
    cin >> star;
    for (int i = 0; i < star; i++)
    {
        for (int j = 0; j < star-i-1; j++)
        {
            cout << " ";
        }
        for (int k = 0; k < 2 * i + 1; k++)
        {
            cout << "*";
        }
        cout << endl;
    }
    for (int i = star - 1; i < 0; i--)
    {
        for (int j = 0; j < star - i; j++)
        {
            cout << " ";
        }
        for (int k = 0; k < 2 * i - 1; k++)
        {
            cout << "*";
        }
        cout << endl;
    }

    return 0;
}