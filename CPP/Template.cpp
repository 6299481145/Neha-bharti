#include<iostream>
using namespace std;

template<class T>
class MathematicalOperations
{
    T a:
public:
    T get_a() 
    {
        return a;
    }  

    void set_a(T a) 
    {
        this->a = a;
    }
};

int main()
{
    MathematicalOperations<float> m;

    m.set_a('a');

    cout<<"The value of a is"<<m.get_a()<<endl;

    return 0;

}
