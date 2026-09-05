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
Console.WriteLine($"Eu adicionei os nomes {nomes[2]} e {nomes[3]} à lista!");
Console.WriteLine($"A lista de nomes tem {nomes.Count} Pessoas");

// PESQUISAR E CLASSIFICAR LISTAS

var index = nomes.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"Quando um item não é encontrado, o IndexOf retorna {index}");
}
else
{
    Console.WriteLine($"O nome {nomes[index]} está no index {index}");
}

index = nomes.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"Quando um item não é encontrado, IndexOf reotrna {index}");
}
else
{
    Console.WriteLine($"O nome {nomes[index]} está no index {index}");
}

nomes.Sort();
foreach (var nome in nomes)
{
    Console.WriteLine($"Olá, {nome.ToUpper()}!");
}


//LISTAS DE OUTROS TIPOS

