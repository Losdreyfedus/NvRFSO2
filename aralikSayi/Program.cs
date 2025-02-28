int userInput;
    Console.Write("10 ile 100 arasında bir sayı giriniz: ");
    userInput = Convert.ToInt32(Console.ReadLine());

while (userInput < 10 || userInput > 100){
    Console.Write("Geçerli bir sayı giriniz (10-100): ");
    userInput = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Geçerli Sayı");