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

int[] Array = CreateArray(8,10,100);
int PositivSum = 0;
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i] %2 == 0)
    {
        PositivSum += Array[i];
    }
}


СonclusionArray(Array);
Console.WriteLine("PositivSum ="+ PositivSum);
