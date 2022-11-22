/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. 
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число");
string message = Console.ReadLine();
int count = message.Length;

if (count < 5 || count > 5)
{
    Console.Write("Введено число не по условию задачи");
}

else
{
    if (message[0] == message[4] && message[1] == message[3])
    {
        Console.WriteLine($"{message} -> палиндром");
    }

    else
    {
        Console.WriteLine($"{message} -> нет");
    }
}

