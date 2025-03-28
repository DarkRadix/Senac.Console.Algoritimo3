using System.Globalization;

Console.Write("Informe seu nome completo: ");
string nomecompleto = Console.ReadLine();
//criar a variavel nome e recebe o seu valor
Console.Write(" Quantos quartos tem na sua casa ?");
Console.WriteLine();
//RAFAEL VIEIRA(WRITE)
//RAFAEL(WRITELINE)
//VIEIRA(WRITELINE)
//converte o texto digitado para um numero int
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Informe o preco da sua internet:");
double precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("Informe seu ultimo nome, idade e altura");
//SUARES 32 1.81
string linha = Console.ReadLine();
//vetor de texto---divisao quando encontrar um espaço
String[] vetor = linha.Split(' ');
string sobrenome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
Console.WriteLine(nomecompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));


