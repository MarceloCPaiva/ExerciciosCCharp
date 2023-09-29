//Dias da semana

int x;
string dia;

Console.Write("Digite de 1 a 7 para saber o dia da semana: ");
x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Segunda";
        break;
    case 3:
        dia = "Terça";
        break;
    case 4:
        dia = "Quarta";
        break;
    case 5:
        dia = "Quinta";
        break;
    case 6:
        dia = "Sexta";
        break;
    case 7:
        dia = "Sábado";
        break;
    default:
        dia = "Número digitado não é válido!";
        break;
}

Console.WriteLine("Dia da Semana: " + dia);
Console.ReadKey();  