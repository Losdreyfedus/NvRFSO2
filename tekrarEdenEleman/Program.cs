int[] numbers = { 1, 2, 3, 4, 2, 5, 3, 6, 1 };
List<int> duplicates = new List<int>();
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j] && !duplicates.Contains(numbers[i]))
        {
            duplicates.Add(numbers[i]);
        }
    }
}
Console.WriteLine("Tekrar eden elemanlar: " + string.Join(", ", duplicates));