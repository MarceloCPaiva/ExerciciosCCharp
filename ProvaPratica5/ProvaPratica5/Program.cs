// PROVA PRÁTICA 5

// Escreva um programa que repita a leitura de uma senha até que ela seja válida.
// Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
// Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
// Considere que a senha correta é o valor 2002.

//Exemplos:
//ENTRADA        SAÍDA
//2200           Senha Invalida
//1020           Senha Invalida
//2022           Senha Invalida
//2002           Acesso Permitido 

int senha, n;

senha = 2002;

Console.Write("Digite a Senha: ");
n = int.Parse(Console.ReadLine());


while (n != senha)
{
    Console.WriteLine("Senha Inválida\n");
    Console.Write("Digite a Senha: ");
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");
