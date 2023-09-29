// Vetores
using System.Globalization;

int n;
double[] vet; //declaração do vetor

n = Convert.ToInt32(Console.ReadLine());
vet = new double[n]; //instanciação do vetor

for (int i = 0; i < n; i++)
{
    vet[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); //acessar elemntos do vetor com um laço de repetição
}

Console.WriteLine();

foreach (double elemento in vet) // EXEMPLO DE FOREACH
{
    Console.WriteLine(elemento.ToString("F2", CultureInfo.InvariantCulture)); //lendo os dados do vetor com um laço de repetição
}