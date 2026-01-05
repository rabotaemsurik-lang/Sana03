using Sana03;

internal class Program
{
    static int ReadIntNumberN()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0) { 
            Console.WriteLine("Введіть ціле число");
        }
        return number;

    }
    static double ReadDoubleElementOfArray()
    {
        double number;
        while(!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Введіть коректно значення");
        }
        return number;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть к-сть елементів масиву");
        int N = ReadIntNumberN();
        Console.WriteLine($"В масиві {N} елементів");
        double[] arr = new double[N];
        Console.WriteLine("Введіть елемнти масиву");
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine($"array[{i}] = ");
            arr[i] = ReadDoubleElementOfArray();
        }
        MyArray myArray = new MyArray(arr);
        Console.WriteLine("суму від’ємних елементів масиву :" + myArray.SumOfNegativeNumbers() );
        Console.WriteLine("мінімальний елемент масиву :" + myArray.MinElementOfArray() );
        Console.WriteLine("номер (індекс) максимального елемента масиву :" + myArray.MaxIndexOfArray());
        Console.WriteLine("максимальний за модулем елемент масиву :" + myArray.MaxModuleElementOfArray());
        Console.WriteLine("суму індексів додатних елементів :" + myArray.SumIndexOfPositiveElements());
        Console.WriteLine("кількість цілих чисел у масиві :" + myArray.IntegerNumbersInArray());




    }
    
}