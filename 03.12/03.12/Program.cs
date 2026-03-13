//Metod - a n dəyəri göndəriləcək. 1-dən n-dək olan 2 rəqəmləri ədələrin sayını qaytaracaq
class Program
{
    public static void Main()
    {
        int n = 367289;
        Console.WriteLine(sayinitap(n));
    }
    static int sayinitap(int n)
    {
        int say = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i >= 10 && i <= 99)
            {
                say++;
            }
        }
        return say;
    }
}
//Metod - a x və y göndəriləcək. x üstü y-i hesablayıb qaytaracaq
class Program
{
    public static void Main()
    {
        double x = 5;
        int y = 6;
        Console.WriteLine(quvvetihesabla(x, y));
    }
    public static double quvvetihesabla(double x, int y)
    {
        double netice = 1;
        for (int i = 0; i < y; i++)
            netice = netice * x;

        return netice;
    }
}

//Metod - a göndərilən arrayin icindeki 5ə bölünən ədədlərin cəmini tapın.
class Program
{
    public static void Main()
    {
        int[] arr = [1, 2, 19, 2000];
        Console.WriteLine(Count(arr));
    }
    public static int Count(int[] arr)
    {
        int cem = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 5 == 0)
            {
                cem += arr[i];
            }
        }
        return cem;
    }
}

