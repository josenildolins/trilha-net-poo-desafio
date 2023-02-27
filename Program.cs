using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Console.WriteLine();
Nokia celularNokia = new Nokia("81","Nokia C01", "888985854584LJKS",128);
celularNokia.InstalarAplicativo("DuoLingo");
celularNokia.Ligar();
celularNokia.ReceberLigacao();
Console.WriteLine();


Console.WriteLine("Smartphone iPhone: ");
Console.WriteLine();
Iphone iphone = new Iphone("81", "iPhone 14 Pro", "5474897899858GRS", 128);
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();
