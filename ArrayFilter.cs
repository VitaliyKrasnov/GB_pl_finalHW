namespace GB_pl_finalHW;

public class ArrayFilter
{
    public void RunTask()
    {
        Console.Write("Введите количество элементов массива: ");
        int arrayLength = int.Parse(Console.ReadLine()!);
        string[] array = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Введите элемент массива и нажмите 'Enter' для ввода следующего: ");
            array[i] = Console.ReadLine()!;
        }
        
        Console.WriteLine($"[ {string.Join(", ", array)} ]");
    }
    
}