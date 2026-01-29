Console.WriteLine("Le Trong Tin - 2415053122342");
Console.Write("Nhap ho va ten: ");
string ten = Console.ReadLine();
string ketQua = "";

if (ten != null && ten != "")
{
    ten = ten.Trim();
    string[] arr = ten.Split(' ');
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] != null && arr[i] != "")
        {
            string tu = arr[i];
            string tuMoi = "";
            if (tu.Length == 1) tuMoi = tu.ToUpper();
            else tuMoi = tu[0].ToString().ToUpper() + tu.Substring(1).ToLower();
            ketQua += tuMoi + " ";
        }
}

if (ketQua != "")
    Console.WriteLine("Ten sau khi chuan hoa: " + ketQua.Trim());