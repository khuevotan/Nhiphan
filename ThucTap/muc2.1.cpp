#include <bits/stdc++.h>
#include <iostream>
using namespace std;

void writeToFile(const char* fileName, string binStr) {
    fstream f(fileName,  ios::app);
    f << binStr << endl;
    f.close();
}

void dequy(int n, string s){
	if (n == 0) 
		writeToFile("output.txt", s);
	else {
		for (int i = 0; i <= 1; i++)
		{
			dequy(n-1, s + char(i + '0'));
		}
	}
}

int main(){
	int n ;
    freopen("input.txt", "r", stdin);
  	cin>>n;
  	if(n>100)
  	{
  		cout << "Nhap lai tham so n<=100 trong file";
	}
	else
	{
		writeToFile("output.txt", "=== Day nhi phan co do dai la n ===");  	
		dequy(n, "");
	}
	return 0;
}
