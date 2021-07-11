class Static{
    int a =20;
    static int b = 20;
    void static_fun(){
        System.out.println("The value of a (instance) is " +a);
        System.out.println("The value of b(class) is "+b);
        a++;
        b++;
    }
}
public class StaticDemo{
    public static void main (String[] args){
        Static s1 = new Static();
        Static s2 = new Static();

        for(int  i=1; i<=3;i++) 
            s1.static_fun();

        for(int i=1; i<=2; i++)
            s2.static_fun();
       
        System.out.println("The code in s1 and s2" +s1 + ", "  + s2 + "respectively: ");//Displaying hashcode in s
    
    }
}