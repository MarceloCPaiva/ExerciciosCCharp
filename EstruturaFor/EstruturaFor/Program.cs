// ESTRUTURA FOR - USADO QUANDO SABE QUANTAS VEZES IRÃ REPETIR

//Soma dos números lidos

int n, x, soma;

n = Convert.ToInt32(Console.ReadLine());
soma = 0;

for (int i = 1; i <= n; i++ )
{
    x = Convert.ToInt32(Console.ReadLine());
    soma += x;
}

Console.WriteLine(soma);