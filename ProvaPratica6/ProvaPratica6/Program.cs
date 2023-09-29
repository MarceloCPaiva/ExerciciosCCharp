// PROVA PRÁTICA 6

//Leia um valor inteiro N. 
//Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
//mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 

//Exemplos: 

// Entrada:             Saída:
// 5                    2 in 
// 14                   3 out 
// 123
// 10
// -25
// 32

int n, dentro, fora, x;

Console.Write("Digite a quantidade de valores inteiros X que serão lidos em seguida: ");
n = int.Parse(Console.ReadLine());

dentro = 0;
fora = 0;

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Digite o valor: ");
    x = int.Parse(Console.ReadLine());

    if (x >= 10 && x <= 20)
    {
        dentro++;
    }
    else 
    {
        fora++;
    }
}

Console.WriteLine(dentro + " in");
Console.WriteLine(fora + " out");


