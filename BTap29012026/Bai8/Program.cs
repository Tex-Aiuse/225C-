Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap mot cau: ");
string cau = Console.ReadLine();
string[] mangTu = null;
string tuDaiNhat = "";
if (cau != null && cau != "")
{
    cau = cau.Trim();
    mangTu = cau.Split(' ');
}

if (mangTu != null)
{
    for (int i = 0; i < mangTu.Length; i++)
        if (mangTu[i] != null && mangTu[i] != "")
            if (tuDaiNhat == "" || mangTu[i].Length > tuDaiNhat.Length)
                tuDaiNhat = mangTu[i];

    if (tuDaiNhat != "")
        Console.WriteLine("Tu dai nhat la: " + tuDaiNhat);
}
