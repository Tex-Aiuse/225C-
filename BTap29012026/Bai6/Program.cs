Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());
int[] a;
int dem = 0;
if (n <= 0)
    dem = 0;
else
{
    a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap a[" + i + "]: ");
        a[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
        if (a[i] % 2 == 0)
            dem++;
}
Console.WriteLine("So phan tu chan trong mang = " + dem);
