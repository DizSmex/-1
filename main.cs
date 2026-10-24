using System;

internal class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Tasks task = new Tasks();

        // Раздел 1
        Console.WriteLine("\nРаздел 1");

        PrintTask("1. Дробная часть");
        double number = ReadDouble("число, чтобы найти его дробную часть");
        PrintResult(task.Fraction(number));

        PrintTask("3. Букву в число");
        char digit = ReadDigit("цифру, чтобы перевести её в число");
        PrintResult(task.CharToNum(digit));

        PrintTask("5. Двузначное");
        int x = ReadInt("число, чтобы проверить, двузначное ли оно", int.MinValue, int.MaxValue);
        PrintResult(task.Is2Digits(x));

        PrintTask("7. Диапазон");
        int a = ReadInt("начало диапазона", int.MinValue, int.MaxValue);
        int b = ReadInt("конец диапазона", int.MinValue, int.MaxValue);
        int num = ReadInt("число, чтобы проверить, входит ли оно в диапазон", int.MinValue, int.MaxValue);
        PrintResult(task.IsInRange(a, b, num));

        PrintTask("9. Равенство");
        a = ReadInt("первое число для проверки на равенство", int.MinValue, int.MaxValue);
        b = ReadInt("второе число", int.MinValue, int.MaxValue);
        int c = ReadInt("третье число", int.MinValue, int.MaxValue);
        PrintResult(task.IsEqual(a, b, c));


        // Раздел 2
        Console.WriteLine("\nРаздел 2");

        PrintTask("1. Модуль числа");
        x = ReadInt("число, чтобы найти его модуль", -int.MaxValue, int.MaxValue);
        PrintResult(task.Abs(x));

        PrintTask("3. Тридцать пять");
        x = ReadInt("число для проверки (делится на 3 или 5, но не на оба)", int.MinValue, int.MaxValue);
        PrintResult(task.Is35(x));

        PrintTask("5. Тройной максимум");
        x = ReadInt("первое число", int.MinValue, int.MaxValue);
        int y = ReadInt("второе число", int.MinValue, int.MaxValue);
        int z = ReadInt("третье число", int.MinValue, int.MaxValue);
        PrintResult(task.Max3(x, y, z));

        PrintTask("7. Двойная сумма");
        x = ReadInt("первое слагаемое", -1000000000, 1000000000);
        y = ReadInt("второе слагаемое", -1000000000, 1000000000);
        PrintResult(task.Sum2(x, y));

        PrintTask("9. День недели");
        x = ReadInt("номер дня недели (от 1 до 7)", int.MinValue, int.MaxValue);
        PrintResult(task.Day(x));


        // Раздел 3
        Console.WriteLine("\nРаздел 3");

        PrintTask("1. Числа подряд");
        x = ReadInt("число N, чтобы вывести все числа от 0 до N", 0, 1000);
        PrintResult(task.ListNums(x));

        PrintTask("3. Чётные числа");
        x = ReadInt("число N, чтобы вывести чётные числа от 0 до N", 0, 1000);
        PrintResult(task.Chet(x));

        PrintTask("5. Длина числа");
        long longNumber = ReadLong("число, чтобы посчитать количество цифр в нём");
        PrintResult(task.NumLen(longNumber));

        PrintTask("7. Квадрат");
        x = ReadInt("размер стороны квадрата", 1, 100);
        task.Square(x);

        PrintTask("9. Правый треугольник");
        x = ReadInt("высоту треугольника", 1, 100);
        task.RightTriangle(x);


        // Раздел 4
        Console.WriteLine("\nРаздел 4");

        PrintTask("1. Поиск первого значения");
        int[] arr = ReadArray("для поиска первого значения", 0);
        x = ReadInt("число, которое нужно найти в массиве", int.MinValue, int.MaxValue);
        PrintResult(task.FindFirst(arr, x));

        PrintTask("3. Поиск максимального по модулю");
        arr = ReadArray("для поиска максимума по модулю", 1);
        PrintResult(task.MaxAbs(arr));

        PrintTask("5. Добавление массива в массив");
        arr = ReadArray("основной", 0);
        int[] ins = ReadArray("который нужно вставить", 0);
        int pos = ReadInt("позицию (индекс), куда вставить новый массив", 0, arr.Length);
        int[] result = task.Add(arr, ins, pos);
        Console.Write("Результат: ");
        PrintArray(result);

        PrintTask("7. Возвратный реверс");
        arr = ReadArray("для реверса", 0);
        result = task.ReverseBack(arr);
        Console.WriteLine("Новый массив:");
        PrintArray(result);
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        PrintTask("9. Все вхождения");
        arr = ReadArray("для поиска всех вхождений", 0);
        x = ReadInt("число, вхождения которого нужно найти", int.MinValue, int.MaxValue);
        result = task.FindAll(arr, x);
        Console.Write("Результат: ");
        PrintArray(result);
    }

    // --- Вспомогательные методы оформления ---

    private static void PrintTask(string title)
    {
        Console.WriteLine($"\n> {title}");
    }

    private static void PrintResult(object result)
    {
        Console.WriteLine($"Результат: {result}");
    }

    // --- Методы ввода ---

    private static int ReadInt(string whatToEnter, int min, int max)
    {
        while (true)
        {
            Console.Write($"Введите {whatToEnter}: ");
            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
            else if (number >= min && number <= max)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ошибка: число вне допустимого диапазона.");
            }
        }
    }

    private static double ReadDouble(string whatToEnter)
    {
        while (true)
        {
            Console.Write($"Введите {whatToEnter}: ");
            double number;

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка: введите число (дробная часть через запятую или точку).");
            }
            else if (number >= -1000000000 && number <= 1000000000)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Ошибка: число слишком большое.");
            }
        }
    }

    private static char ReadDigit(string whatToEnter)
    {
        while (true)
        {
            Console.Write($"Введите {whatToEnter}: ");
            char digit;

            if (!char.TryParse(Console.ReadLine(), out digit))
            {
                Console.WriteLine("Ошибка: введите только один символ.");
            }
            else if (digit >= '0' && digit <= '9')
            {
                return digit;
            }
            else
            {
                Console.WriteLine("Ошибка: это не цифра.");
            }
        }
    }

    private static long ReadLong(string whatToEnter)
    {
        while (true)
        {
            Console.Write($"Введите {whatToEnter}: ");
            long number;

            if (long.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Ошибка: введите целое число.");
        }
    }

    private static int[] ReadArray(string purpose, int minLength)
    {
        int length = ReadInt($"размер массива ({purpose})", minLength, 100);
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = ReadInt($"элемент [{i}]", int.MinValue, int.MaxValue);
        }

        return arr;
    }

    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }
            Console.Write(arr[i]);
        }
        Console.WriteLine("]");
    }
}
