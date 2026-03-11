//Verilmiş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm

//int[] numbers = [1, 5, 7, 13, 45];
//int search = 15;
//int index = -1;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == search)
//        index = i;
//}
//Console.WriteLine(index);


//Verilmis bir stringin yalniz ortadakı simvolunu cixisa verin. eger cut sayda simvol varsa ortadaki iki simvolu ciisa verin. 

//mes: "Salam" -> 'l', "Market" -> 'rk')
//string word = "Market";

//if(word.Length % 2 == 1)
//{
//    Console.WriteLine(word[word.Length / 2]);
//}
//else
//{
//    Console.Write(word[word.Length / 2 - 1] + word[word.Length / 2]);
//}

//Bir tam ədədlər massivi verilib. Həmin massivdəki tək indexdə dayanan elementlərin cəmi ilə cüt indexdə dayanan elementlərin cəminin fərqini tapan alqoritm yazın.

//int[] numbers = [1, 5, 7, 13, 45];
//int teklerinCemi = 0;
//int cutlerinCemi = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if(i % 2 == 0)
//    {
//        cutlerinCemi += numbers[i];
//    }
//    else
//    {
//        teklerinCemi += numbers[i];
//    }
//}
//Console.WriteLine(teklerinCemi - cutlerinCemi);

//Verilmiş cümlədə sözləri ayrı ayrı ekrana yazdırın məs

string s = "salam dostum necesen hfhgu";
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == ' ')
        Console.WriteLine();
    else
        Console.Write(s[i]);
}