#include <bits/stdc++.h>
#include <iostream>
using namespace std;

void writeToFile(const char* fileName, string binStr) {
    fstream f(fileName,  ios::app);
    f << binStr << endl;
    f.close();
}

void LietKeDayNhiPhan0101(int n)
{
	
    bool* x = new bool[n];
    unsigned short* y = new unsigned short[n];
 
    for (int i = 0 ; i < n ; i++)
    {
        x[i] = false;
    }

    for (int i = 0 ; i < n - 1 ; i++)
    {
        x[i] = true;
        x[i+1] = true;
        for (int j = i + 2 ; j < n - 1 ; j++)
        {
            x[j] = true;
            x[j+1] = true;
 
            for (int p = 0 ; p < n ; p++)
            {
                if (x[p] == true)
                {
                    y[p] = 0;
                    y[p+1] = 1;
                    p++;
                }
                else
                    y[p] = 0;
            }
 
            int q = 0;
            do
            {  
                for (int p = 0 ; p < n ; p++)
                    cout <<(int)y[p]<<"";
                cout << "\n";
 
                while (q < n)
                {
                    if (x[q] == false && y[q] == 0)
                    {
                        y[q] = 1;
                        break;
                    }  
                    q++;
                }
 
            } while (q < n);
 
            x[j] = false;
            x[j+1] = false;
        }
        x[i] = false;
        x[i+1] = false;
    }
 
    delete[] x;
    delete[] y;
}

int main()
{
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
            LietKeDayNhiPhan0101(n);
        }
    }
    return 0;
}
