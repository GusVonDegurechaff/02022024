using _1.Classes;

Abonent abonent1 = new Abonent();
abonent1.Lastcity = "Москва";
abonent1.Firstcity = "Владимир";
abonent1.Time = 5;
abonent1.Phone = "89777077777";
abonent1.Date = 11112023;
abonent1.OutToScreen();

Abonent abonent2 = new Abonent(1, "Санкт-Петербург", "Владивосток", 4, "89680000932", 11112023);
abonent2.OutToScreen();

Abonent abonent3 = new Abonent();
Console.WriteLine("Введите город откуда звонили");
abonent3.Lastcity = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите город куда звонили");
abonent3.Firstcity = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите продолжительность звонка");
abonent3.Time = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите какой номер звонил");
abonent3.Phone = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите дату разговора");
abonent3.Date = Convert.ToInt32(Console.ReadLine());
abonent3.OutToScreen();