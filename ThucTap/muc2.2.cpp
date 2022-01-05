#include <bits/stdc++.h>
#include <iostream>
#define ll long long
using namespace std;

int doDai(string s)
{
    int cnt = 0;
    for (int i = 0; s[i] != NULL; i++)
        cnt++;
    return cnt;
}

string daoNguoc(string s)
{
    string dao("");
    int l = doDai(s);
    for (int i = l - 1; i >= 0; --i)
        dao += s[i];
    return dao;
}

void muc_02(int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 2; j < n - 1; j++)
        {
            string h = "";
            for (int e = 0; e < n; e++)
            {
                if (e == i || e == j)
                    h = h + "1";
                else
                    h = h + "0";
            }
            h = daoNguoc(h);
            cout << h << "\n";
        }
    }
    
 	cout <<  "\n";
 	if (n > 4)
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 2; j < n - 1; j++)
        {
            string s = "";
            for (int e = 0; e < n; e++)
            {
                if (e == i || e == j)
                    s = s + "0";
                else
                    s = s + "1";
            }
            cout << s << "\n";
        }
    } 
}

int main() {
    int n;
    freopen("input.txt", "r", stdin);
    cin >> n;
    if (n > 100)
    {
        cout << "Nhap lai tham so n<=100 trong file";
    }
    else {
        if (n <= 3)
            cout << "Do dai n khong du de thuc hien bai toan";
        else {
            cout << "Chuoi 01 xuat hien 2 lan \n";
            muc_02(n);
        }
    }
    return 0;
}

