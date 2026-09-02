using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

// IMPRIMIR NA TELA UMA PIRÂMIDE, COM UM VALOR 5 DE BASE
// IMPRIMIR NA TELA UMA PIRÂMIDE INVERTIDA, COM TOPO 5
// DEIXAR O USUÁRIO ESCOLHER O NÚMERO DA BASE
//PIRÂMIDE EXATA, UTILIZANDO ESPAÇO

PrimeiroDesafio();
//SegundoDesafio();
//TerceiroDesafio();

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
 int x, y;
    int contador = 4;
    char caractere = '#';

    for (x = 1; x <= 9; x = x + 2)
    {
  
        for (y = 0; y < contador; y++)
        {
            Console.Write(" ");
        }

        for (y = 0; y < x; y++)
        {
            Console.Write(caractere);
        }

        Console.WriteLine();

        contador--;
    }
}


void TerceiroDesafio()
{
    Console.WriteLine("Permitindo que o usuário insira o valor da pirâmide");
Console.WriteLine("Digite o valor da base da pirâmide:");
int x,y; //= int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
int contador = (num / 2) -1;
char caractere = '#';
for (x = 1 ; x <= num; x = x + 2)
    {
        for (y =0; y < contador ; y++)
        {
            Console.Write(' ');
        }
        for (y = 0; y < x; y++)
        {
            Console.Write(caractere);
        }
        Console.WriteLine();
        contador --;
    }



}