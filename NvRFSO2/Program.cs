Console.WriteLine("Sayı Giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int temp = number; temp > 0; temp /= 10)
{
    sum += temp % 10;
}
Console.WriteLine($"Rakamlar toplamı: {sum}");