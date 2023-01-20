/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number < 1 || number > 7)
{
  Console.WriteLine("Введено ошибочное число, оно не равно дню недели");
}
else if (number == 6 || number == 7)
{
  Console.WriteLine("Этот день недели - выходной");
}
else
{
  Console.WriteLine("Этот день недели - рабочий");
}
