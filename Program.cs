using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "1111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "48782", modelo: "Modelo 2", imei: "222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
