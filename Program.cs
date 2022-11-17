CreateFillArray();

string[] CreateFillArray()
{
    System.Console.WriteLine("Enter how many elements there are in the array:");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[numberOfElements];
    string line;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Enter the {i+1} element:");
        array[i] = Console.ReadLine();
    }
    return array;
}