using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "40404040", modelo: "Teste 1", imei: "0001", memoria: 252);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "50505050", modelo: "Teste 2", imei: "0002", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");