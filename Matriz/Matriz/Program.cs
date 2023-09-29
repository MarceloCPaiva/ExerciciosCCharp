// Matriz

int M, N;
int[,] A; //declaração da Matriz


string[] s1 = Console.ReadLine().Split(' ');

M = int.Parse(s1[0]);
N = int.Parse(s1[1]);

A = new int[M, N]; // instancia a matriz

for (int i = 0; i < M; i++) //percorrer as linhas
{
    string[] S = Console.ReadLine().Split(' '); //para ler vários números na mesma linha
    for (int j = 0; j < N; j++) //percorrer as colunas
    {
        A[i,j] = int.Parse(S[j]);
    }
}

for (int i = 0; i < M; i++) // percorrer as linhas
{
    for (int j = 0; j < N; j++) // percorrer as colunas
    {
        Console.Write(A[i,j] + " ");
    } 
    Console.WriteLine();
}