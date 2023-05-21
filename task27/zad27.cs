// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

 Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());

    int sum = 0;
    int temp = number;

    while (temp != 0)
    {
         int digit = temp % 10;
        sum += digit;
        temp /= 10;
    }

    Console.WriteLine("Сумма цифр числа: " + sum);