// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Clear();
while (true)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    // нужно проверить, что строка input состоит только из цифр
    int number;
    if (int.TryParse(input, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10; // избавляемся от последней цифры
        }
        if (sum % 2 == 0)
        {
            break;
        }
    }
}