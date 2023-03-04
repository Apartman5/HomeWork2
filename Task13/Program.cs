// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое целое число: ");
string digits = Console.ReadLine();
int number = Convert.ToInt32(digits);
if(number < 100)
{
    Console.WriteLine("Третьей цифры в числе нет!");
}
else 
{
    Console.WriteLine($"Третья цифра числа c конца - {digits[digits.Length-3]}");
    Console.WriteLine($"Третья цифра числа c начала - {digits[2]}");
}