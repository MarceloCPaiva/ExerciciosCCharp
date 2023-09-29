// Matriz 2
//Ler 2 números Inteiros M e N.
//Em seguida ler uma matriz de M linhas e N colunas
//Gerar um vetor de modo que cada elemento do vetor seja a soma dos elementos da linha correspondente da Matriz

int M, N;
int[,] matriz; // declaração da Matriz

string[] linha = Console.ReadLine().Split(' '); // para ler dois dados na mesma linha com espaço
M = int.Parse(linha[0]); // quantidade de linhas
N = int.Parse(linha[1]); // quantidade de colunas   

matriz = new int[M, N]; //Instanciando a Matriz

for (int i = 0; i < M; i++) // percorrer as linhas
{
    linha = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) //percorrer as colunas
    {
        matriz[i, j] = int.Parse(linha[j]); // leitura da matriz
    }
}

int[] vetor = new int[M];

for (int i = 0;i < M; i++)
{
    int soma = 0;
    for (int j = 0;j < N; j++)
    {
        soma = soma + matriz[i, j];
    }
    vetor[i] = soma;
}

for (int i = 0; i < M; i++)
{
    Console.WriteLine(vetor[i]);
}