/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine()!);
var array = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();

if (number < 100)
{
  Console.WriteLine("Третьей цифры у введенного числа нет");
}
else
{
  Console.WriteLine($"Третья цифра числа {number} - это цифра {array[2]}");
}

