//Verilmiş ədədin müsbət mənfi və ya 0-a bərabər olması
//int a = -76;

//if (a > 0)
//{

//    Console.WriteLine("a musbet ededdir");
//}
//else if (a == 0)
//{

//    Console.WriteLine("a ededi 0 a beraberdir");
//}
//else
//{
//    Console.WriteLine("eded menfidir");
//}


//Yaş dəyişəni təyin et. Əgər
//0-18: usaq
//18 - 65 yetiskin
//65> yasli 


//int age = 17;

//if (age < 18)
//{
//    Console.WriteLine("17 yas uygundur");
//}


//else if (age <= 18 && age <= 65)

//{
//    Console.WriteLine(" yas uygundur");
//}
//else if (age < 65)

//{
//    Console.WriteLine("65 yasdan kicikdir");
//}


//mebleg deyiseni verilir. Əgər:
//məbləğ 100dən azdırsa olduğu kimi
//100-500 arasıdırsa 10% endirim
//500dən böyükdürsə 20% endirim tətbiq olunsun.
//sonda odenilmeli mebleg ekranda gosterilsin


//int mebleg = 90;

//if (mebleg < 100)
//{
//    Console.WriteLine(mebleg);
//}
//else if (mebleg < 100 && mebleg <= 500)
//{
//    Console.WriteLine(mebleg * 0.9);
//}
//else if (mebleg > 500)
//{
//    Console.WriteLine(mebleg * 0.8);
//}

//switch case ile, input olunan qiymete uygun cixis ver:
//(2 - “Pis”, 3 - “Kafi”, 4 - “Yaxsi”, 5 -”Ela”,
//Eks halda “2 - 5 arasi eded daxil edin”)

//int num = 3;

//switch (num)
//{
//    case 2:
//        Console.WriteLine("Kafi");
//        break;
//    case 3:
//        Console.WriteLine("Kafi");
//        break;
//    default:
//        Console.WriteLine("Eks halda “2 - 5 arasi eded daxil edin");
//        break;
//}

//verilmis edede qeder ededlerin cemini alma
int n = 19;
int s = 1;
for (int i = 1; i <= n; i++)
{
    s += i;
}
Console.WriteLine(s);



