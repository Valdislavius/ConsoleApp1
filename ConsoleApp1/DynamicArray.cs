namespace ConsoleApp1;
class DynamicArray
{
    private int[] array;

    public DynamicArray(int size)
    {
        array = new int[size];
    }

    public void FillWithRandomNumbers(int minValue, int maxValue)
    {
        var random = new Random();
        
        for(int i = 0; i < array.Length; i++) array[i] = random.Next(minValue, maxValue);
    }

    public double CalculateAverage()
    {
        int sum = 0;
        
        foreach(var num in array) sum += num;

        return (double)sum / array.Length;
    }

    public void PrintArray()
    {
        Console.WriteLine("Массив: ");
        foreach (var num in array) Console.Write($"{num} ' '");
        Console.WriteLine();
    }
}

