#include<iostream>
using namespace std;

class point
{
    int x;
    int y;

public:
    point();
    point(int x, int y);
    point(point &p);

    void setx(int x);
    int getx();
    void sety(int y);
    int gety();
};

point :: point()
{
    x = 0;
    y = 0;
}

point :: point(int x, int y)
{
    this->x=x;
    this->y=y;
}
point :: point(point &p)
{
    x=p.x;
    y= p.y;
}

void point :: setx(int x)
{
    this->x = x;
}

int point :: getx()
{
    return x;
}

void point :: sety(int y)
{
    this->y = y;
}

int point :: gety()
{
    return y;
}

int main()
{
    point p1;
    point p2(30,40);
    point p3(p2);

    cout<<"p1("<<p1.getx()<<", "<<p1.gety()<<")"<<endl;
    cout<<"p2("<<p2.getx()<<", "<<p2.gety()<<")"<<endl;
    cout<<"p3("<<p3.getx()<<", "<<p3.gety()<<")"<<endl;

    return 0;
}