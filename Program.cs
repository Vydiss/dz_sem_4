// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Console.Clear();
// while (true)
// {
//     Console.Write("Введите целое число: ");
//     string input = Console.ReadLine();
//     if (input == "q")
//     {
//         break;
//     }
//     // нужно проверить, что строка input состоит только из цифр
//     int number;
//     if (int.TryParse(input, out number))
//     {
//         int sum = 0;
//         while (number > 0)
//         {
//             sum += number % 10;
//             number /= 10; // избавляемся от последней цифры
//         }
//         if (sum % 2 == 0)
//         {
//             break;
//         }
//     }
// }


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Clear();

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // новый массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int CountEvenNumbers(int[] numbers)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArray(sizeArray);
// Console.WriteLine($"Массив: [ {string.Join("; ", arr)} ]");
// Console.WriteLine($"Количество четных чисел: {CountEvenNumbers(arr)}");


// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Console.Clear();

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // новый массив на size элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] ReverseArray(int[] array)
// {
//     int[] revArray = new int[array.Length];
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         revArray[j] = array[i];
//     }
//     return revArray;
// }

// Console.WriteLine("Введите длинну массива: ");
// int sizeArr = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(sizeArr, 1, 150);
// int[] revArray = ReverseArray(array);

// Console.WriteLine($"Заданный массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Перевернутый массив: [ {string.Join("; ", revArray)} ]");