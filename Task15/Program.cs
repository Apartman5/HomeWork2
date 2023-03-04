// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Input the serial number of the day of the week:");
int weekDay = Convert.ToInt32(Console.ReadLine());

bool WeekEnd(int number)
{
    if (number > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int day)
{
    if (day > 0 && day < 8)
    {
        return true;
    }
    Console.WriteLine("It`s not a day of the week!");
    return false;
}

if(ValidateWeekday(weekDay))
{
    if(WeekEnd(weekDay))
    {
        Console.WriteLine("It`s a weekend!");
    }
    else Console.WriteLine("It`s not a weekend!");
}
