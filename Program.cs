using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone();
Console.WriteLine("Insira o número de telefone: ");
iphone.Numero = Console.ReadLine();
Console.WriteLine("Insira o modelo do telefone: ");
iphone.Modelo = Console.ReadLine();
Console.WriteLine("Insira o IMEI do telefone: ");
iphone.IMEI = Console.ReadLine();
Console.WriteLine("Insira o valor da memória do telefone: ");
iphone.Memoria = Convert.ToInt32(Console.ReadLine());
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone nokia = new Nokia();
Console.WriteLine("Insira o número de telefone: ");
nokia.Numero = Console.ReadLine();
Console.WriteLine("Insira o modelo do telefone: ");
nokia.Modelo = Console.ReadLine();
Console.WriteLine("Insira o IMEI do telefone: ");
nokia.IMEI = Console.ReadLine();
Console.WriteLine("Insira o valor da memória do telefone: ");
nokia.Memoria = Convert.ToInt32(Console.ReadLine());
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatApp");
