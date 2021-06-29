#include <iostream>
using namespace std;
void sort(int *arr, int n);
void display(int *arr, int n);
int main()
{
    int n = 5;
    int arr[] = {25, 3, 16, 99, 20};
    sort(arr, n);
    display(arr, n);
    return 0;
}

void swap(int *x, int *y)
{
    *x = *x + *y;
    *y = *x - *y;
    *x = *x - *y;
}

void sort(int *arr, int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if(arr[i] > arr[j])
            {
                swap(arr[i], arr[j]);
            }
        }
    }
}

void display(int *arr, int n)
{
    for(int i=0; i<n; i++)
    {
        cout<<arr[i]<<endl;
    }
}
