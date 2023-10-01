using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GameGuessNumber();
                    break;
                case 2:
                    MultiplicationTable();
                    break;
                case 3:
                    FindDivisors();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Ошибка, выберите цифру от 1 до 4.");
                    break;
            }
        }
    }

    static void GameGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        Console.WriteLine("'Угадай число'");

        while (true)
        {
            Console.Write("Введите число: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Ура, вы угадали число!");
                return;
            }

            Console.WriteLine("Вы не угадали:( Попробуйте еще раз.");
        }
    }

    static void MultiplicationTable()
    {
        int[,] matrix = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void FindDivisors()
    {
        Console.WriteLine("Вывод делителей числа:");
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Делители числа " + number + ": ");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}
