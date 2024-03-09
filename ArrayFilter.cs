namespace GB_pl_finalHW;

public class ArrayFilter
{
    public void RunTask()
    {
        Console.Write("Введите через пробел элементы массива: ");
        string[] array = Console.ReadLine()!.Split(" ");
        Console.Write(string.Join(" ", array));
    }
    
}