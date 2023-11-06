using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99292-8080", modelo: "C30", imei:"123123123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "99191-0000", modelo: "13 Pro Max", imei:"999999999", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");