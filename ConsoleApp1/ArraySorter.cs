namespace ConsoleApp1;
class ArraySorter
{
    private int[] array;

    public ArraySorter(int size)
    {
        array = new int[size];
    }

    public void FillArrayFromUserinput()
    {
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void BubbleSort()
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if( array[i] < array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Массив: ");

        foreach(var num in array) Console.WriteLine($"{num} ' '");

        Console.WriteLine();
    }
}

