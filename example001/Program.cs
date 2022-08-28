//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int result = (num/10)%10;
// Console.WriteLine(result);

int num;
 Console.WriteLine("Введите трехзначное число");
num = Convert.ToInt32(Console.ReadLine());
 int result = (num/10)%10;
Console.WriteLine(result);
