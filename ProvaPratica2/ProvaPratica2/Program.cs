// PROVA PRÁTICA 2

//Faça um programa para ler o valor do raio de um círculo, 
//e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.

//Entrada:
//Digite o valor do raio de um círculo: 2.00
//Saída:
//O valor da área é: 12.5664

using System.Globalization;

double raio, pi, area;

Console.WriteLine("Digite o valor do raio de um círculo: ");
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

pi = 3.14159;

area = pi * Math.Pow(raio, 2);

Console.WriteLine("O valor da área é: " + area.ToString("F4", CultureInfo.InvariantCulture));