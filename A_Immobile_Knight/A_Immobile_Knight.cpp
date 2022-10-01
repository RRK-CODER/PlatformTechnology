#include <bits/stdc++.h>

using namespace std;

int main()
{
    int t;
    cin>>t;
    while(t--)
    {
        int n, m;
        cin>>n>>m;
         if(n==1 || m==1)
        cout<<"1"<<" "<<"1"<<endl;
        else if(n==1 && m>1)
        cout<<"1"<<" "<<(m/2)+1<<endl;
        else if(m==1 && n>1)
        cout<<(n/2)+1<<" "<<"1"<<endl;
        else if(n<=3 && m<=3)
        cout<<(n/2)+1<<" "<<(m/2)+1<<endl;
        else
        cout<<n<<" "<<m<<endl;
        
    }
     return 0;  
}