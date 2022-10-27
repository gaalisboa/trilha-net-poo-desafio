using DesafioPOO.Models;

Nokia nokia = new Nokia("988006655", "NOKIA M2", "001970-01-010000-0", 64);
Console.WriteLine("INFORMAÇÕES SOBRE O CELULAR:");
Console.WriteLine(
    $"Número: {nokia.Numero}\n" +
    $"Modelo: {nokia.Modelo}\n" +
    $"IMEI: {nokia.IMEI}\n" +
    $"Memória: {nokia.Memoria} GB");
nokia.Ligar("40028922");
nokia.ReceberLigacao();

Console.WriteLine("\n------------------------\n");

Iphone iphone = new Iphone("982449746", "IPHONE X", "001970-01-010000-1", 128);
Console.WriteLine("INFORMAÇÕES SOBRE O CELULAR:");
Console.WriteLine(
    $"Número: {iphone.Numero}\n" +
    $"Modelo: {iphone.Modelo}\n" +
    $"IMEI: {iphone.IMEI}\n" +
    $"Memória: {iphone.Memoria} GB");
iphone.Ligar("40028922");
iphone.ReceberLigacao("39290304");