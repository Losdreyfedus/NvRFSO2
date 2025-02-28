string[] words = { "elma", "armut", "karpuz", "kiraz" };
string shortest = words[0], longest = words[0];
foreach (string word in words)
{
    if (word.Length < shortest.Length) shortest = word;
    if (word.Length > longest.Length) longest = word;
}
Console.WriteLine($"En kısa kelime: {shortest}, En uzun kelime: {longest}");