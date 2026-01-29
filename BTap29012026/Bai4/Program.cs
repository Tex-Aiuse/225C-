Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap so phan tu n: ");
int n = int.Parse(Console.ReadLine());
int[] a;
if (n <= 0)
    Console.WriteLine("Loi");
else
{
    a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap a[" + i + "]: ");
        a[i] = int.Parse(Console.ReadLine());
    }
    int tong = 0;
    for (int i = 0; i < n; i++)
        tong += a[i];
    Console.WriteLine("Tong cac phan tu trong mang = " + tong);
}
