//inicioif();
//explorandoif();
//loopwhile
//loopfor();
testandomaisloops();

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

void testandomaisloops()
{
    
for (int linha = 1 ; linha < 11; linha++)
    {
        for (char coluna = 'a'; coluna < 'k'; coluna++)
        {
         Console.WriteLine ($"A célula é: ({linha},{coluna})");
        }
    }

/*Agora que você usou a if instrução e os constructos de loop na linguagem C#, veja se você pode escrever código C# para encontrar a soma de todos os inteiros de 1 a 20 que são divisível por 3. Aqui estão algumas dicas:

O operador % retorna o restante de uma operação de divisão.
A instrução if especifica a condição para determinar se um número deve fazer parte da soma.
O loop for pode ajudá-lo a repetir uma série de etapas para todos os números de 1 a 20.
Experimente você mesmo. Em seguida, verifique como você fez. Como dica, você deve obter 63 como resposta.
*/










}