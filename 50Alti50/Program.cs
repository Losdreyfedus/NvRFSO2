List<int> grades = new List<int> { 45, 60, 30, 80, 49, 70, 31, 19};
for (int i = 0; i < grades.Count; i++)
{
    if (grades[i] < 50) grades[i] = 50;
}
Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", grades));