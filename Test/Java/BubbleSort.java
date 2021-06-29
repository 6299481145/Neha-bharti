 class BubbleSort {
    private int arr[] = new int[] { 25, 3, 16, 99, 20 };
    private final int n = 5;    //constant in java

    public static void main(String[] args) {
        BubbleSort b = new BubbleSort();
        b.sort();
        b.display();

    }

    void swap(int x, int y) {
      // arr[x] = arr[x] + arr[y];
       //arr[y] = arr[x] - arr[y];
       //arr[x] = arr[x] - arr[y];
       int t  = arr[x];
       arr[x] = arr[y];
       arr[y] = t;
    }

    void sort() {
        for (int i = 0; i < n; i++) {
            for(int j=0; j<n-1; j++)
            {
                if(arr[j]>arr[j+1])
                {
                    swap(j, j+1);
                }
            }
        }
    }

    void display() {
     int n;
     

        for(int i=0; i<n; i++)
            System.out.println(arr[i]);
    }
}