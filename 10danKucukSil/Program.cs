List<int> numberList = new List<int> { 1, 2, 3, 4, 5, 10, 15, 20};
for (int i = numberList.Count - 1; i >= 0; i--)
{
    if (numberList[i] < 10) numberList.RemoveAt(i);
}
Console.WriteLine("10’dan küçükler silindi: " + string.Join(", ", numberList));