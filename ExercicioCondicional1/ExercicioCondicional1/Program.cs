using System.Globalization;

// Média do ALluno


double nota1, nota2, media;

Console.Write("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

media = nota1 + nota2;

if (media > 60.0)
{
    Console.WriteLine("Nota Final: " + media.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Nota Final: " + media.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("Reprovado");
}

Console.ReadKey();  