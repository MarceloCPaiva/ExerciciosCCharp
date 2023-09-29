// PROVA 1
//Exercício 1.1:  
//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1 
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
//Calcule e mostre o valor a ser pago. 

//Entrada:
//Digite o código da peça, o número de peças e o valor unitário de cada peça: 12 1 5.30 
//Digite o código da peça, o número de peças e o valor unitário de cada peça: 16 2 5.10 

//Saída:
//VALOR A PAGAR: R$ 15.50 

using System.Globalization;
int codigoDaPeca;
double valorUnitarioDaPeca, numeroDePecas, calculo1, calculo2;

Console.WriteLine("Digite o código da peça, o número de peças e o valor unitário de cada peça:");
string[] array1 = Console.ReadLine().Split(' ');

Console.WriteLine("Digite o código da peça, o número de peças e o valor unitário de cada peça:");
string[] array2 = Console.ReadLine().Split(' ');

codigoDaPeca = int.Parse(array1[0]);
numeroDePecas = double.Parse(array1[1]);
valorUnitarioDaPeca = double.Parse(array1[2], CultureInfo.InvariantCulture);

calculo1 = 0.0;

if (numeroDePecas > 1)
{
    calculo1 = valorUnitarioDaPeca * numeroDePecas;
}
else
{
    calculo1 = valorUnitarioDaPeca;
}

codigoDaPeca = int.Parse(array2[0]);
numeroDePecas = double.Parse(array2[1]);   
valorUnitarioDaPeca = double.Parse(array2[2], CultureInfo.InvariantCulture);

calculo2 = 0.0;

if(numeroDePecas > 1)
{
    calculo2 = valorUnitarioDaPeca * numeroDePecas;
}
else
{
    calculo2 = valorUnitarioDaPeca;
}

double resultado  = calculo1 + calculo2;

Console.WriteLine("VALOR A PAGAR: R$ " +  resultado.ToString("F2", CultureInfo.InvariantCulture));