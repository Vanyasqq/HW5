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

void PositivArrayNum(int[] array)
{
    int Count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if( array[i] % 2 ==0  )
        {
            Count = Count +1;
            Console.Write(array[i] +"; ");
        }
    }
    Console.WriteLine("Количество четных чисел= "+ Count);
}

int[] input = CreateArray(8,100,999);
СonclusionArray(input);
Console.WriteLine("Четные числа:");
PositivArrayNum(input);
;