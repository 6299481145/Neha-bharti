#include <iostream>
using namespace std;
namespace onlits
{
    class node
    {
        int data;
        node *link;

    public:
        node();
        node(int data);
        void set_data(int data); //input
        int get_data();          //output
        void set_link(node *n);
        node *get_link();
    };

    node::node()
    {
        this->data = 0;
        this->link = NULL;
    }

    node::node(int data)
    {
        this->data = data;
        this->link = NULL;
    }

    int node::get_data()
    {
        return data;
    }

    void node::set_link(node *n)
    {
        link = n;
    }

    node *node::get_link()
    {
        return link;
    }

    class list
    {
        node *head;
        node *itr;

    public:
        list();
        void menu();
        void display();
        void append();
        void remove();
        void message(string m);
    };

    list::list()
    {
        head = NULL;
        itr = NULL;
    }

    void list::menu()
    {
        do
        {
            cout << "MAIN MENU" << endl;
            cout << "1. Display (Traversal)" << endl;
            cout << "2. Append node" << endl;
            cout << "3. Remove node (from back)" << endl;
            cout << "Enter choice (0 to exit): ";
            int ch;
            cin >> ch;
            switch (ch)
            {
            case 0:
                exit(0);
                break;
            case 1:
                display();
                break;
            case 2:
                append();
                break;
            case 3:
                remove();
                break;
            default:
                cout << "-----------------------" << endl;
                cout << "Invalid input!" << endl;
                cout << "-----------------------" << endl;
            }
        } while (1);
    }

    void list::display()
    {
        if (head == NULL)
        {
            message("List is empty, nothing to display!");
        }
        else
        {
            itr = head;
            cout << "The list contains the following elements:" << endl;
            cout << "-----------------------------------------" << endl;
            do
            {
                cout << itr->get_data() << endl;
                if (itr->get_link() == NULL)
                    break;
                else
                    itr = itr->get_link(); //move itr to next node
            } while (1);
            cout << "-----------------------------------------" << endl;
        }
    }

    void list::append()
    {
        int val;
        cout << "Enter value to append: ";
        cin >> val;
        if (head == NULL)
        {
            head = itr = new node(val);
            message("Node created!");
        }
        else
        {
            itr->set_link(new node(val));
            itr = itr->get_link();
            message("Node created!");
        }
    }

    void list::remove()
    {
        if (head == NULL)
        {
            message("List is empty, nothing to remove!");
        }
        else if (head->get_link() == NULL)
        {
            delete head->get_link();
            head = NULL;
            message("Item deleted!");
        }
        else
        {
            itr = head;
            while (itr->get_link()->get_link() != NULL)
            {
                itr = itr->get_link();
            }
            delete itr->get_link();
            itr->set_link(NULL);
            message("Item deleted!");
        }
    }

    void list::message(string m)
    {
        cout << "---------------------------------" << endl;
        cout << m << endl;
        cout << "---------------------------------" << endl;
    }
}

int main()
{
    onlits::list l;
    l.menu();
}   