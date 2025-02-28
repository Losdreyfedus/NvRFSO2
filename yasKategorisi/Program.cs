int[] ages = { 5, 17, 25, 70 };
foreach (var age in ages)
{
    string category;
    if (age <= 12) category = "Çocuk";
    else if (age <= 19) category = "Genç";
    else if (age <= 64) category = "Yetişkin";
    else category = "Yaşlı";
    Console.WriteLine($"Yaş {age}: {category}");
}
