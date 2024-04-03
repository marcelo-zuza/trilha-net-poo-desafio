using DesafioPOO.Models;

// Implementado!
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "96325998", modelo: "c-df-63", imei: "55451242", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Hora de dormir");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "569325654", modelo: "kl-963558", imei: "HJ-9875", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Donkey Kong");
