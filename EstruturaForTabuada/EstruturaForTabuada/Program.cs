// Tabuada

int n, calc, contador;

n = Convert.ToInt32(Console.ReadLine());
calc = 1;
contador = 1;

for (int i = 1; i <= 10; i++)
{
    calc = n * contador;
    Console.WriteLine(contador + " x " + n + " = " + calc);
    contador++;
}

