Console.Clear();

int numero1, numero2, somaDosNumeros;

Console.Write("Escreva um número qualquer: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Escreva o número que será somado ao anterior: ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

somaDosNumeros = numero1 + numero2;

Console.Write($"Soma = {somaDosNumeros}");
Console.WriteLine();