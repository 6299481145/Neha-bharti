#include <iostream>
using namespace std;
class products
{
public:
    virtual void show() = 0;
};

class product1 : public products
{
public:
    void show()
    {
        cout << "Product 1" << endl;
    }
};

class product2 : public products
{
public:
    void show()
    {
        cout << "Product 2" << endl;
    }
};

class factory
{
public:
    static products* get_product(int i)            //Factory Method
    {
        switch(i)
        {
            case 1:
                return new product1();
                break;
            case 2:
                return new product2();
                break;
            default:
                cout << "No such products!" << endl;
                return NULL;
        }
    }
};


int main()              //Abstraction
{
    int i;
    cout << "Enter a number: ";
    cin >> i;
    products *p = factory::get_product(i);
    if(p != NULL) p->show();
    return 0;
}