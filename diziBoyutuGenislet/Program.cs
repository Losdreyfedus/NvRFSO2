string[] stringArray = new string[2] { "elma", "armut" };
Array.Resize(ref stringArray, stringArray.Length + 1);
stringArray[stringArray.Length - 1] = "çilek";
Console.WriteLine("Dizi: " + string.Join(", ", stringArray));