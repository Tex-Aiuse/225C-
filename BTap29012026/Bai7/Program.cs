Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap ho ten: ");
string hoTen = Console.ReadLine();
string[] mangTen = null;
if (hoTen != null && hoTen != "")
{
    hoTen = hoTen.Trim();
    mangTen = hoTen.Split(' ');
}
if (mangTen != null)
{
    for (int i = 0; i < mangTen.Length; i++)
        if (mangTen[i] != null && mangTen[i] != "")
            Console.WriteLine(mangTen[i]);
}
