List<string> wordsList = new List<string>();
Console.Write("Kelime girin (çıkış = space + enter): ");
string input;
while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
{
    Console.Write("Kelime girin (çıkış = space + enter): ");
    wordsList.Add(input);
}
wordsList.Reverse();
Console.WriteLine("Ters sıralı kelimeler: " + string.Join(", ", wordsList));
