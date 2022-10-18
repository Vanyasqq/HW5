int[] CreateArray (int N, int Min, int Max)
{
    Random r = new Random();
    int[] array = new int[N];
    for(int i = 0; i<N; i++ )
    {
        array[i] = r.Next(Min,Max+1);
    }
    return array;
}

void СonclusionArray(int[] Array)
{
Console.WriteLine(string.Join(", ", Array));
}

int[] Array = CreateArray(6,10,100);
int min = 50;
int max = 50;
for(int i=0; i<Array.Length;i++)
{
    if(min > Array[i])
    {
        min = Array[i];
    }
    if(max < Array[i])
    {
        max = Array[i];
    }

}

int difference = max - min;
СonclusionArray(Array);
Console.WriteLine("Разница максимального и минимального числа в массиве = " + difference);

