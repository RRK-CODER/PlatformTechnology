#include<bits/stdc++.h>
using namespace std;

void solve()
{
    int n;
    cin>>n;
    int a[n+1], d[n+1],z=0;
    for(int i=0; i<n; i++)
       cin>>d[i];
  a[0]=d[0];
  for(int i=1; i<n; i++)
  {
    int x=a[i-1]-d[i];
    int y=a[i-1]+d[i];
    if(min(x,y)<0 || x==y)
          a[i]=d[i]+a[i-1];
    else
    z=1;
  }
  if(z==0){
    for(int i=0; i<n; i++)
    cout<<a[i]<<" ";
  }
    else
    cout<<"-1";
    cout<<endl;

}

int main()
{
    ios_base::sync_with_stdio(0), cin.tie(0), cout.tie(0);
    srand(chrono::high_resolution_clock::now().time_since_epoch().count());
    
    int t;
    cin >> t;
    while(t--)
    {
        solve();
    }
    return 0;
}