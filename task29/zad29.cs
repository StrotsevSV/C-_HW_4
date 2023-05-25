// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]


 Console.WriteLine("Вы желаете вывести массив? (y/n)");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "y")
    {
        Console.WriteLine("Введите количество элементов в массиве: ");
        int count = int.Parse(Console.ReadLine());

        int[] numbers = GenerateRandomArray(count);

        Console.Write("Сгенерированный массив: ");
        PrintArray(numbers);
    }
    else if (answer.ToLower() == "n")
    {
        Console.WriteLine("Спасибо, что выбрали нашу компанию!");
    }
    else
    {
        Console.WriteLine("Некорректный ответ.");
    }

    static int[] GenerateRandomArray(int count)
    {
    Random random = new Random();
    int[] numbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        numbers[i] = random.Next(100); // Генерация случайного числа от 0 до 99
    }

    return numbers;
    }

    static void PrintArray(int[] numbers)
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }