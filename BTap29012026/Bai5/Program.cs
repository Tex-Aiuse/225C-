Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());
int[] a;
if (n <= 0)
    Console.WriteLine("Mang rong hoac null, khong xu ly");
else
{
    a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap a[" + i + "]: ");
        a[i] = int.Parse(Console.ReadLine());
    }
    int max = a[0];
    for (int i = 1; i < n; i++)
    {
        if (a[i] > max)
            max = a[i];
    }
    Console.WriteLine("Gia tri lon nhat trong mang = " + max);
}
