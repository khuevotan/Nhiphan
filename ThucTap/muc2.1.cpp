#include <bits/stdc++.h>
#include <iostream>

using namespace std;
void writeToFile(const char* fileName, string binStr) {
    fstream f(fileName,  ios::app);
    f << binStr << endl;
    f.close();
}

int n;

int a[10000];
string chuoi;
string chuoi2;
 
void in(int a[],int n){
    for (int i = 1; i <= n; i++)
    {
		chuoi =	std::to_string(a[i]);
		chuoi2 = chuoi2 + chuoi;
	}
    writeToFile("output.txt", chuoi2);
	chuoi2 = "";
}
 
void deQuy(int i, int n){
    for (int j = 0; j <= 1; j++){
        a[i] = j;
        if (i == n)
            in(a,n);
        else
            deQuy(i + 1,n);
    }
}
 
int main(){
    freopen("input.txt", "r", stdin);
  	cin>>n;
  	if(n>100)
  	{
  		cout << "Nhap lai tham so n<=100 trong file";
	}
	else
	{
		writeToFile("output.txt", "=== Day nhi phan co do dai la n ===");  	
		deQuy(1,n);
	}
}
