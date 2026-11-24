// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("qual o nome do seu personagem:");
string nome = Console.ReadLine() ?? ""; 
int vida = 100;
int moedas = 20;
int nivel = 1;

Console.WriteLine($"nome:{nome} vida:{vida}, moedas:{moedas}, nivel:{nivel}");