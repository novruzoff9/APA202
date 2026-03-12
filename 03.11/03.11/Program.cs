using System.Xml.Linq;

class Program
{
    public static void Main()
    {
        //int a = Sum(5);
        //int[] massiv = [7, 2, 5, 9];
        //Console.WriteLine(Arrmin(massiv));
        Console.WriteLine(CharCount("salam", 'a'));
    }

    //Metod-a söz və hərf göndəriləcək.Həmin sözdə verilən hərfdən neçə ədəd olduğunu qaytaracaq metod
    public static int CharCount(string str, char c)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                count++;
            }
        }
        return count;
    }









    //metod-a ədədlər massiv göndəriləcək.Həmin massivdəki, ən kiçik elementi tapıb geri qaytaracaq
    public static int Arrmin(int[] arr)
    {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }


    //metod-a n dəyəri göndəriləcək. Metod həmin ədədin kvadratını qaytaracaq
    public static int Square(int a)
    {
        return a * a;
    }

    //Metod-a n dəyəri göndəriləcək.metod 1-dən n-dək olan cüt ədədlərin cəmini qaytaracaq
    public static int Sum(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (i % 2 == 0)
                sum += i;
        }
        return sum;
    }
}