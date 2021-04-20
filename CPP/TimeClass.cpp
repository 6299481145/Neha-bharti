#include<iostream>

using namespace std;

class Time
{
	int hh;
	int mm;
	int ss;
	int ampm;
public:
    void get_Time(int h, int m, int s, int ap);
	void show_Time();		
};
void Time:: get_Time(int h, int m, int s, int ap)
{
	hh=h;
	mm=m;
	ss=s;
	ampm=ap;
}
void Time::show_Time() 
{
	cout<<hh<<":"<<mm<<":"<<ss<<"";
	if(ampm==0)
	  cout<<"am"<<endl;
	else
	  cout<<"pm"<<endl;  
}
int main()
{
	Time t;
	t.get_Time(11,20,30,0);
	t.show_Time	();
	return 0;
}

