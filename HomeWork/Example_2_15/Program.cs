/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 - 7, соответсвующую дню недели, либо название дня недели");

string[] dayOfWeek = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};

int number = 1;
string value = Console.ReadLine();
bool result = int.TryParse(value, out number);



if(!result)
{
    string str = value.ToLower();

    if (str == dayOfWeek[0] || str == dayOfWeek[1] ||str == dayOfWeek[2] ||str == dayOfWeek[3] ||str == dayOfWeek[4])
    {
        Console.WriteLine("Нет. Рабочий день!");
    }
    else if (str == dayOfWeek[5] || str == dayOfWeek[6])
    {
        Console.WriteLine("Да. Выходной!");
    }
    else
    {
        Console.WriteLine("Такого дня недели нет!");
    }
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да.Выходной!");
    }
    else if(number < 1 || number > 7) 
    {
        Console.WriteLine("Число не соответсвует дню недели!");
    }
    else
    {
        Console.WriteLine("Нет. Рабочий день!");
    }
}