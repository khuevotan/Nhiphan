#include <bits/stdc++.h>
#define ll long long
using namespace std ;

int doDai(string s)
{
    int cnt = 0;
    for(int i = 0; s[i] != NULL ; i++) 
    	cnt++;
    return cnt;
}
 
string daoNguoc(string s)
{
    string dao("");
    int l = doDai(s);
    for(int i = l-1; i >= 0; --i) 
		dao += s[i];
    return dao;
}

string xoaKyTuCuoi(string s)
{
    string r("");
    for(ll i = 0; i < doDai(s)-1; ++i)
        r += s[i];
    return r;
}

void muc_01()
{
    int n ;
    cout <<"Hay nhap n: ";
    cin >> n ;
    
    for( ll i = 0 ; i < (1LL << n) ; i++ )
    {
        ll x = i;
        string s = "";
        while (x!=0)
        {
            if(x%2 == 1)
                s=s+"1";
            else
                s=s+"0";
            x/=2;
        }
        
        if(s == "")
        	s= "0";
        else
        for(ll i = doDai(s)-1; i > 0; --i)
        {
            if(s[i] == '1' || doDai(s) == 1 )
				break;
            else
                s = xoaKyTuCuoi(s);
        }
	
        s = daoNguoc(s);
        cout << s << "\n";
    }
}

int main()
{
    muc_01();
    return 0;
}
