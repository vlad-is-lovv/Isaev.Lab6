 static void Show(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,-3}" + "  ", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
 static void Random(int[,] array)
{
    Random r = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(-100, 100);
        }
    }
}

int n = Convert.ToInt32(Console.ReadLine());

int[,] Z = new int[n, n];

Random(Z);

Show(Z);
int Max = 0;

for (int i = 0;i < Z.GetLength(0); i++ )
{
    for (int j = 0; j < Z.GetLength(1); j++)
    {
        if (Z[i, j] > Max)
        {
           

            Max = Z[i, j];
            Z[i, j] = Z[i, i];
            Z[i, i] = Max ;

        }
    }
    Max = 0;
    
}
Console.WriteLine();
Show(Z);