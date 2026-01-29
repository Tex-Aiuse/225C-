Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap chuoi: ");
string s = Console.ReadLine();
if (string.IsNullOrEmpty(s) == true)
    Console.WriteLine("Chuoi trong");
string[] tu = s.Split(' ');
int dem = tu.Length;
Console.WriteLine($"Co {dem} tu trong chuoi");
