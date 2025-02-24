namespace ConsoleApp1;
internal class Programm
{
    public static void Main(string[] args)
    {
        //Задача 1
        try
        {
            var calculator = new Calculator();

            Console.WriteLine("Введите 1 число: ");
            calculator.num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            calculator.num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию (+, -, *, /): ");
            calculator.operation = Console.ReadLine();

            double result = calculator.Calculate();
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Задача 2
        Console.WriteLine("Введите строку для анализа: ");
        string input = Console.ReadLine();

        var analyz = new Analyz();

        int vowelCount = analyz.CountVowels(input);
        int consonantCount = analyz.CountConsonants(input);
        int digitCount = analyz.CountDigits(input);

        Console.WriteLine($"Колличество гласных: {vowelCount}");
        Console.WriteLine($"Колличество согласных: {consonantCount}");
        Console.WriteLine($"Колличество цифр: {digitCount}");

        //Задача 3
        var point1 = new Point(3, 4);
        var point2 = new Point(5, 8);

        double distanceToOrigin = point1.DistnaceToOrigin();
        Console.WriteLine($"Расстояние до начала координат: {distanceToOrigin}");

        double distanceBetweenPoint = point1.DistanceTo(point2);
        Console.WriteLine($"Расстояние между точкой 1 и точкой 2: {distanceBetweenPoint}");

        //Задача 4
        Console.WriteLine("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        var dynamicArray = new DynamicArray(size);
        dynamicArray.FillWithRandomNumbers(1, 100);
        dynamicArray.PrintArray();

        double average = dynamicArray.CalculateAverage();
        Console.WriteLine($"Среднее арифметическое: {average}");

        //Задача 5

        Console.WriteLine("Введите размер массива: ");
        int arraySize = int.Parse(Console.ReadLine());

        var arraySorter = new ArraySorter(arraySize);
        arraySorter.FillArrayFromUserinput();
        arraySorter.BubbleSort();
        arraySorter.PrintArray();
    }
}