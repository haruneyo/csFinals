string[] originalArray = CreateFillArray();
string[] sortedArray = SortedArray(originalArray);
System.Console.WriteLine("The original array is: ");
PrintArray(originalArray);
System.Console.WriteLine("The sorted array is: ");
PrintArray(sortedArray);

string[] CreateFillArray()
{
    System.Console.WriteLine("Enter how many elements there are in the array:");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[numberOfElements];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Enter the {i + 1} element:");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string[] SortedArray(string[] array)
{
    array = array.Where(value => value.Length < 4).ToArray();
    return array;
}