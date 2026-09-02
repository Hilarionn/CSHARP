List<string> nomes = ["<nome>", "Ana", "Felipe"];
foreach (var nome in nomes)
{
    Console.WriteLine($"Olá, {nome.ToUpper()}!");
}

Console.WriteLine();
nomes.Add("Maria");
nomes.Add("Joao");
nomes.Remove("Ana");
int contador = 0;
foreach(var nome in nomes)
{
    Console.WriteLine($"Olá, {nome.ToUpper()}!");
    contador++;
}
Console.WriteLine($"Existem {contador} nomes na lista!");