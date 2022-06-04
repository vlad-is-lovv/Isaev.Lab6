int n = Convert.ToInt32(Console.ReadLine());
int[] Q = new int[n];
Random(Q);
Show(Q);
int quantity = 0;
int sum = 0;

for (int i = 0; i < Q.Length; i++)
{
    if (Q[i] % 7 != 0 && Q[i] % 5 ==0)
    {
        quantity += 1;
        sum+=Q[i];
    }
}   
Console.WriteLine($"Количество чисел: {quantity}. Cумма чисел: {sum}.");







static void Show(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}" + "  ");

    }

}
 static void Random(int[] array)
{
    Random r = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = r.Next(0, 100);
    }

}