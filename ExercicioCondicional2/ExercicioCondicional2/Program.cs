//Menor número

int x, y, z;

string[] vet = Console.ReadLine().Split(' ');

x = Convert.ToInt32(vet[0]);
y = Convert.ToInt32(vet[1]);
z = Convert.ToInt32(vet[2]);

if(x < y && x < z)
{
    Console.WriteLine("Menor = " + x);    
}else if(y < z)
{
    Console.WriteLine("Menor = " + y);
}
else
{
    Console.WriteLine("Menor = " + z);
}

Console.ReadKey();  