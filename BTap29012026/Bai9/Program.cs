Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap mot cau: ");
string cau = Console.ReadLine();
int dem = 0;
if (cau != null)
    for (int i = 0; i < cau.Length; i++)
        if (cau[i] != ' ')
            dem++;
Console.WriteLine("So ky tu khac null va rong la: " + dem);
