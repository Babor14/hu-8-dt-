// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Введите день");
//Console.WriteLine("Введите месяц");
//Console.WriteLine("Введите год");
//Console.WriteLine("ваша дата:{data}");
using System.Diagnostics;
DateTime starttime=DateTime.Now;
Stopwatch sw = new Stopwatch();
sw.Start();
Console.WriteLine("год");
int date1 = int.Parse(Console.ReadLine());
//
Console.WriteLine("месяц");
int date2 = int.Parse(Console.ReadLine());
//int date2= 04;
Console.WriteLine("дни");
int date3 = int.Parse(Console.ReadLine());
//int date3 = 12;
//var date4= date1 + date2 + date3;
DateTime datenow= DateTime.Now;
DateTime date=new DateTime(date1,date2,date3);
Console.WriteLine(date);
sw.Stop();
DateTime endtime=DateTime.Now;
Console.WriteLine($"время начала работы программы:"+ starttime.Millisecond);
Console.WriteLine($"Время выполнения работы программы(mil):{sw.ElapsedMilliseconds}");
Console.WriteLine($"Программа закончила работу в:"+endtime.Millisecond);