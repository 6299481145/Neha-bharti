#include <iostream>
#include <vector>
using namespace std;
void display(vector<int> &v)
{
    for (int i = 0; i < v.size(); i++)
    {
        cout << v[i] << " ";
    }
    cout << "\n";
}

int main()
{
    vector<int> v;
    cout << "Initial size = " << v.size() << "\n";
    //Putting values into the vector
    int x;
    cout << "Enter five integer values: ";
    for (int i = 0; i < 5; i++)
    {
        cin >> x;
        v.push_back(x);
    }
    cout << "Size after adding 5 values: ";
    cout << v.size() << "\n";

    //Display the contents
    cout << "Current contents: \n";
    display(v);

    //Add one more value
    v.push_back(6.6); //float value truncated

    //Display the size and contents
    cout << "\nSize = " << v.size() << "\n";
    cout << "Contents now: \n";
    display(v);

    //Inserting elements

    vector<int>::iterator itr = v.begin();
    itr = itr + 3;
    v.insert(itr, 9);

    //Display the contents
    cout << "\nContents after inserting:\n";
    display(v);

    //Removing 4th and 5th elements
    v.erase(v.begin() + 3, v.begin() + 5);

    //Display the contents
    cout << "\nContents after deletion:\n";
    display(v);

    //Removing last element
    v.pop_back();
    cout << "\nContents after deletion:\n";
    display(v);
    cout << "End\n";

    return 0;
}