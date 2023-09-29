//ESTRUTURA DE REPETIÇÃO WHILE - É USADO QUANDO NÃO SABE QUANTAS VEZES SERÁ NECESSÁRIO REPETIR
//
//CALCULAR A IDADE

using System.Globalization;

double idade,soma, media;
int cont;

idade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

soma = 0.0;
cont = 0;

while (idade >= 0)
{
    soma += idade;
    cont++;
    idade = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
}

if (cont == 0)
{
    Console.WriteLine("Impossível calcular");
}
else
{
    media = soma / cont;
    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
}


Console.ReadKey();  
