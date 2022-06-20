string[] randomArray = new string[] { "hello", "2", "world", ":=)" };


void ShowArray (string[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        Console.Write(randomArray[i] + " ");
    }
    Console.WriteLine();
}

string[] SolveTask (string[] randomArray)
{
    int size = randomArray.Length;
    string[] result = new string[size];
    for (int i = 0; i < randomArray.Length; i++)
        if (randomArray[i].Length <= 3)
        {
            result[i] = randomArray[i];
        }
    return result;
}

string PrintArray (string[] array)
{
    string res = string.Empty;
    res = "[ ";
    for (int i = 0; i < array.Length; i++)
        {
             res += $"{array[i],3} ";
        }
    res = " ]";
        return res;
}



//ShowArray(randomArray);
PrintArray(SolveTask(randomArray));
