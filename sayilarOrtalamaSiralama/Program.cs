List<int> numberList = new List<int>();
Console.Write("Sayı girin (0 çıkış): ");
while (true)
{
    Console.Write("Sayı girin (0 çıkış): ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 0) break;
    numberList.Add(num);
}
int sumNumbers = 0;
foreach (int n in numberList) sumNumbers += n;
double average = (double)sumNumbers / numberList.Count;
numberList.Sort();
Console.WriteLine($"Ortalama: {average}, Sıralı liste: {string.Join(", ", numberList)}");