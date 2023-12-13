int n = 10;
int[] arr = new int[n];
Random random = new Random();
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < n; i++)
{
    arr[i] = random.Next(10, 100);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
void PrintArray(int i, int[] arr)
{
    Console.Write($"{arr[i]} ");
    if (i > 0)
    {
       PrintArray(i - 1, arr); 
    }    
}
Console.WriteLine("Перевернутый массив: ");
PrintArray(n-1, arr);
