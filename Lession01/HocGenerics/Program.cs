static void printArray<T>(T[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}

int[] a = { 1, 2, 3, 4, 5, 6, };
double[] b = { 1.3, 3.5, 3.1 };
string[] c = { "Hung", "Anh", "Dung" };
printArray(a);
printArray(b);
printArray(c);

