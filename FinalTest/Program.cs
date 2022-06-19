string CreateArray (int size )
{
    string[] array = new string[size];
    
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

void ShowArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string SolveTask (string[] array)
{
    int size = 0;
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        if (array[i] / 100 < 10)
        {
            newArray[i] = array[i];
            size += 1;
        }
    }
    return newArray;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateArray(size);
ShowArray(myArray);
string[] reNewArray = SolveTask(myArray);
ShowArray(reNewArray);