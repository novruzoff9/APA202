//string str = "test";
//bool hasA = false;
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == 'a')
//    {
//        hasA = true;


//        break;
//    }
//}
//if (hasA)
//{
//    Console.WriteLine("A herfi var");
//}
//else
//{
//    Console.WriteLine("A herfi yoxdur");
//}


//string str = "test";
//int count = 0;
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == 'a')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//int[] numbers = [5, 2, 7, 12];
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        sum += numbers[i];
//    }
//}
//Console.WriteLine(sum);





string[] strings = ["test", "text2", "lorem"];
int count = 0;
for (int i = 0; i < strings.Length; i++)
{
	for (int j = 0; j < strings[i].Length; j++)
	{
		if (strings[i][j] == 't')
		{
			count++;
		}
	}
}
Console.WriteLine(count);