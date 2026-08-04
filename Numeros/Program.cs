//TrabalhandoComInteiros();
//OrdemDePrecedencia();
// Quocientes();


void OrdemDePrecedencia(){

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);
d = (a + b) * c;
Console.WriteLine(d);
d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);  // Repare que o número foi arredondado
}


void TrabalhandoComInteiros()
{
    


int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

// subtração
c = a - b;
Console.WriteLine($"O resultado da subtração é: {c}");


// multiplicação
c = a * b;
Console.WriteLine($"O resultado da multiplicação é: {c}");

// divisão
c = a / b;
Console.WriteLine($"O resultado da divisão é: {c}");

c = a + b - 12 * 17;
Console.WriteLine($"O resultado da expressão é: {c}");

}

void Quocientes()
{
    

///////////////////////////////// Extraindo o Quociente e o resto da divisão
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine("O resultado da divisão (7 + 4) / 3 é:");
Console.WriteLine($"Quociente: {d}");
Console.WriteLine($"Resto: {e}");

///////////////////////////////// Verificando distância mínima e máxima dos valores inteiros
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"O alcance dos inteiros é {min} até {max}");


int what = max + 3;
Console.WriteLine($"Um exemplo de overflow: {what}"); // Observe que a resposta está próxima do min + 2, a operação transbordou os valores.

}

double z = 5;
Console.WriteLine(z - 1.2);

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);


double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");