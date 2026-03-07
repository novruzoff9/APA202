//1-dən M-ədək ədədlər içərisində 3-ə bölünən ədədlərin sayını tapan alqoritm

//int m = 17;
//int count = 0;
//for (int i = 1; i <= m; i++)
//{
//    if(i % 3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//int m = 23;
//int count = 0;
//int sum = 0;
//for (int i = 1; i <= m; i++)
//{
//    if (i % 5 == 0)
//    {
//        sum += i;
//        count++;
//    }
//}
//Console.WriteLine(sum/count);

//x və y daxil edilsin. x üstü y-i hesablayın
//int x = 5;
//int y = 4;
//int netice = 1;
//for (int i = 0; i < y; i++)
//{
//    netice = netice * x;
//}
//Console.WriteLine(netice);

//int a = Convert.ToInt32(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    sum += num;
//}
//Console.WriteLine(sum);

//int hasil = 1;
//while (true)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    if(num == 0)
//    {
//        break;
//    }
//    hasil *= num;
//}
//Console.WriteLine(hasil);

//string password = "salam123";
//while (true)
//{
//    string input = Console.ReadLine();
//    if(input == password)
//    {
//        Console.WriteLine("Parol duzgundur");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Parol yanlisdir");
//    }
//}

//int y = Convert.ToInt32(Console.ReadLine()); // 5
//int x = Convert.ToInt32(Console.ReadLine()); // 17
//int maxi = -1; //5
//for (int i = 0; i <= x; i++)
//{
//    if(i % y == 0)
//    {
//        maxi = i;
//    }
//}
//Console.WriteLine(maxi);

int[] numbers = { 2, 5, -4, 9, -1 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 0)
    {
        numbers[i] += 2;
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    //Console.WriteLine(numbers[i]);
    Console.Write(numbers[i] + " ");
}