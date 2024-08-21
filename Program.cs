using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "141234123", modelo: "Iphone 7", imei: "4329876128367", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Iphone nokia = new Iphone(numero: "321432131", modelo: "Tijolão", imei: "7638216789234", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");