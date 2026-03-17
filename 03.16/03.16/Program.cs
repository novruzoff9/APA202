using _03._16;

Order order1 = new(1, "alma",4, 2.2);
Console.WriteLine(order1.Count);
Console.WriteLine(order1.TotalPrice());
order1.Increase(5);
Console.WriteLine(order1.Count);
order1.ShowInfo();


OnlineOrder onlineorder1 = new(2, "armud", 3, 2.6, 5.7);
Console.WriteLine(onlineorder1.Count);
Console.WriteLine(onlineorder1.Distance);
