Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap chuoi: ");
string s = Console.ReadLine();

if (string.IsNullOrEmpty(s))
{
    Console.WriteLine("Chuoi khong doi xung");
    return;
}
string tam = s.Trim();
string[] A = tam.Split();
string chuoiMoi = "";
for (int i = 0; i<A.Length; i++)
    chuoiMoi =chuoiMoi + A[i];
int ktra = 0;
for (int i = 0; i < chuoiMoi.Length/2; i++)
{
    if (chuoiMoi[i] != chuoiMoi[chuoiMoi.Length-i-1])
        ktra = 1;
}
if (ktra == 1)
    Console.WriteLine("Chuoi khong doi xung");
else
    Console.WriteLine("Chuoi doi xung");
