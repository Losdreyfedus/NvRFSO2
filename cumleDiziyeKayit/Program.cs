Console.Write("Bir cümle girin: ");
string sentence = Console.ReadLine();
string[] wordArray = sentence.Split(' ');
Array.Sort(wordArray);
Console.WriteLine("Alfabetik sıralı kelimeler: " + string.Join(", ", wordArray));