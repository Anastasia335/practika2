// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a;
string aText;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
aText = Convert.ToString(a);
int index = aText.Length;
if (index > 2)
{
    Console.WriteLine("Третья цифра " + aText[2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}