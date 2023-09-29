// PROVA PRÁTICA 3

//Com base na tabela de preços abaixo,
//faça um programa que leia o código de um item e a quantidade deste item.
//A seguir, calcule e mostre o valor da conta a pagar. 

//   CODIGO       ESPECIFICAÇÃO            PREÇO
//     1          cachorro quente          R$ 4.00
//     2          X-salada                 R$ 4.50
//     3          X-bacon                  R$ 5.00
//     4          Torrada simples          R$ 2.00
//     5          Refrigerante             R$ 1.50

//Exemplo:
//Entrada: 3 2 
//Saída: Total: R$ 10.00 

using System;
using System.Globalization;

int quantidade;
double codigo, cachorroQuente, xSalada, xBacon, torradaSimples, refrigerante;

Console.WriteLine("Digite o código e a quantidade desse item: ");

string[] array = Console.ReadLine().Split(' ');

codigo = Convert.ToInt32(array[0]);
quantidade = Convert.ToInt32(array[1]);

switch (codigo)
{
    case 1:
        codigo = 4.00;
        break;
    case 2:
        codigo = 4.50;
        break;
    case 3:
        codigo = 5.00;
        break;
    case 4:
        codigo = 2.00;
        break;
    case 5:
        codigo = 1.50;
        break;
    default:
        Console.WriteLine("Código inexistente.");
        break;
}


if(quantidade > 1)
{
    codigo = codigo * quantidade;
}
else
{
    codigo = codigo;
}

Console.WriteLine("Total a pagar: " + codigo.ToString("F2", CultureInfo.InvariantCulture));    