// PROVA PRÁTICA 4

//Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax² + bx + c = 0)
//Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja abaixo).
//Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser negativo),
//mostrar uma mensagem "Impossivel calcular".  

//Fórmula: x = -b±√∆    onde: ∆= b²−4ac
//               2a

//Exemplos: 

// Entrada:                                     Saída: 
// 10.0 20.1 5.1                               X1 = -0.29788     X2 = -1.71212 
// 10.0 3.0 5.0                                Impossivel calcular 


using System.Globalization;

double A, B, C, delta, x1, x2;

string[] vetor = Console.ReadLine().Split(' ');
A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

delta = B * B - 4 * A * C;

if (A != 0)
{
    if (delta >= 0)
    {
        // Calcular as raízes usando a fórmula de Bhaskara
         x1 = (-B + Math.Sqrt(delta)) / (2 * A);
         x2 = (-B - Math.Sqrt(delta)) / (2 * A);

        Console.WriteLine("x1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
        Console.WriteLine("x2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
    }
    else
    {
        Console.WriteLine("Impossível calcular. Delta é negativo.");
    }
}
else
{
    Console.WriteLine("Impossível calcular. O coeficiente 'a' não pode ser zero.");
}

