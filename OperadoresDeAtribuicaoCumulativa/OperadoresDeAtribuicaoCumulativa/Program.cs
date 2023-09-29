using System.Globalization;
//Operadores de Atribuição Cumulativa

int minutos;
double fatura;

Console.Write("Qual a Quantidade de minutos usada nesse mês? ");
minutos = Convert.ToInt32(Console.ReadLine());

fatura = 50.0;

if(minutos > 100)
{
    fatura = fatura + (minutos - 100) * 2.0;
    //pode ser escrito assim:
    //fatura += + (minutos - 100) * 2.0;
}

Console.WriteLine("Valor a pargar: R$ " + fatura.ToString("F2", CultureInfo.InvariantCulture));  
Console.ReadKey();  