string[] randomArray = new string[4] { "hello", "2", "world", ":=)" };


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
    for(int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i].Length <= 3)
        {
            result[i] = randomArray[i];
        }

    }
    return result;
}


ShowArray(randomArray);
string[] newArray = SolveTask(randomArray);
ShowArray(SolveTask(randomArray));

