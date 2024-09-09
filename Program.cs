using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Ligar Nokia");
Nokia nokia = new Nokia("123456", "Tijolão", "56789", 64);
nokia.Ligar();
Console.WriteLine($"Nokia está ligado");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\nLigar IPhone");
Iphone iphone = new Iphone("987654", "iPhone 13 Pro Max", "09876", 64);
iphone.Ligar();
Console.WriteLine("Iphone está ligado");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");