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
            Console.Write($"Введите {i + 1}й элемент массива и нажмите 'Enter': ");
            array[i] = Console.ReadLine()!;
        }
        Console.WriteLine("Введённый массив:");
        Console.WriteLine($"[ {string.Join(", ", array.Select(item => $"\"{item}\"").ToArray())} ]");
        Console.WriteLine("Отфильтрованный массив:");
        // можно было решить одной строкой :)
        //array = array.Where(item => item.Length <= 3).ToArray();
        array = FilterArray(array).Select(item => $"\"{item}\"").ToArray();
        Console.WriteLine($"[ {string.Join(", ", array)} ]");
    }
    
    private string[] FilterArray(string[] array)
    {
        int numberOfFilteredItems = 0;
        foreach (var item in array)
        {
            if (item.Length <= 3) numberOfFilteredItems++;
        }
        
        string[] filteredArray = new string[numberOfFilteredItems];
        int filteredArrayIndex = 0;
        foreach (var item in array)
        {
            if (item.Length <= 3) filteredArray[filteredArrayIndex++] = item;
        }

        return filteredArray;
    }
    

    // рекурсивная версия
    // private string[] FilterArray(string[] array, int startIndex, int arrayLength)
    // {
    //     if (startIndex >= arrayLength)
    //     {
    //         return array;
    //     }
    //
    //     if (array[startIndex].Length <= 3)
    //     {
    //         startIndex++;
    //         return FilterArray(array, startIndex, arrayLength);
    //     }
    //
    //     string[] tmpArray = new string[arrayLength - 1];
    //     int tmpIndex = 0;
    //     for (int i = 0; i < arrayLength; i++)
    //     {
    //         if (i == startIndex)
    //         {
    //             continue;
    //         }
    //
    //         tmpArray[tmpIndex++] = array[i];
    //     }
    //
    //     return FilterArray(tmpArray, startIndex, tmpArray.Length);
    // }
}