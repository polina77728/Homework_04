/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
string number =  Console.ReadLine();

int length = number.Length;  // колличество элементов массива

int[] array = new int[length]; //объявление массива


for(int i = 0; i < length; i++)
{
    array[i] = number[i];
}

Console.WriteLine(array);
Console.WriteLine();

int sum =  array[0];

for(int i = 0; i < length; i++)
{
    sum += array[i];
}



Console.WriteLine($"{number} -> {sum}"); 
