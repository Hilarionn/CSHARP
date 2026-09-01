using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

// IMPRIMIR NA TELA UMA PIRÂMIDE, COM UM VALOR 5 DE BASE
// IMPRIMIR NA TELA UMA PIRÂMIDE INVERTIDA, COM TOPO 5
// DEIXAR O USUÁRIO ESCOLHER O NÚMERO DA BASE
//PIRÂMIDE EXATA, UTILIZANDO ESPAÇO

PrimeiroDesafio();
SegundoDesafio();

void PrimeiroDesafio(){ 
Console.WriteLine("Este é o primeiro desafio, imprimir uma pirâmide decrescente");
    // A cada vez que o loop interno rodar, tenho que imprimir um caractere
// A cada vez que o loop externo rodar, tenho que quebrar a linha
int x, y;
char caractere = '#';

for (x = 1; x <= 5 ; x++)
{
    for(y = 0; y < x; y++)
    {
        Console.Write(caractere);
    }
    Console.WriteLine();
}
}


void SegundoDesafio()
{

    Console.WriteLine("Este é o segundo desafio, imprimir uma pirâmide com os espaços");
// Preciso incrementar 2 de uma vez
// Preciso imprimir espaço, a cada incremento, incrementar espaço
int x,y;
char caractere = '#';
char espaco = '_';
for (x = 1; x <= 5; x++)
    {
        for (y = 0; y < x; y++)
        {
            Console.Write(caractere);
        }
        Console.WriteLine();
        Console.WriteLine(espaco);
    }




}