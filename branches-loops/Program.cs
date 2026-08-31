//inicioif();
//explorandoif();
//loopwhile
loopfor();


void inicioif()
{
    

int a = 5;
int b = 3;
int c = 4;


if ((a + b + c > 10) && (a ==b))
{
    

    Console.WriteLine("A resposta é maior que 10");
    Console.WriteLine("E o primeiro número é igual ao segundo");
}
else
{
    Console.WriteLine("A resposta não é maior que 10");
    Console.WriteLine("Ou o primeiro número não é igual ao segundo");
}
}

void explorandoif()
{
    
int a = 5;
int b = 3;
if (a + b > 10)
    {
        Console.WriteLine("A resposta é maior que 10");
    }
else
    {
        Console.WriteLine("A resposta não é maior que 10");

    }

int c = 4;
if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("A resposta é maior que o número 10");
        Console.WriteLine("E o primeiro número é maior que o segundo");
    }
    else
    {
        Console.WriteLine("A resposta não é maior que 10");
        Console.WriteLine("Ou o primeiro número não é maior que o segundo");
    }
if ((a + b + c > 10) || (a > b)) // Se uma ou se outra, o primeiro bloco. Se cair no Else, significa - Nem uma, nem outra.
    {
        Console.WriteLine("A resposta é maior que 10");
        Console.WriteLine("Ou o primeiro número é maior que o segundo");
    }

    else
    {
        Console.WriteLine("A resposta não é maior que 10");
        Console.WriteLine("E o primeiro número não é maior que o segundo");
    }

}
void loopwhile(){
int contador = 0;
while (contador < 10)
{
    Console.WriteLine($"O contador está em: {contador}");
    contador ++;

}
}
void loopfor()
{
    for (int contador = 0; contador < 10; contador++)
    {
        Console.WriteLine($"O contador está em {contador}");
    }

}