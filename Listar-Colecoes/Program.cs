using Microsoft.Win32.SafeHandles;

List<string> nomes = ["Gabriel", "Lecin", "Arthur"];
foreach (var nome in nomes)
{
    Console.WriteLine($"Olá, {nome.ToUpper()}!");
}

Console.WriteLine();
nomes.Add("Esdras Rocha");
nomes.Add("Fabão");
nomes.Remove("Lecin");
int contador = 0;
foreach(var nome in nomes)
{
    Console.WriteLine($"Olá, {nome.ToUpper()}!");
    contador++;
}
Console.WriteLine($"Existem {contador} nomes na lista!");

Console.WriteLine($"Meu nome é {nomes[0]}");
Console.WriteLine($"Eu adicionei os nomes {nomes[1]} e {nomes[2]} à lista!");