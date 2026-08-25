using System.IO.Pipes;
//TrabalhandoComInteiros();
//OrdemDePrecedencia();
//Quocientes();
//TrabalhandoComDouble();
//TrabalhandoComDecimais();
//Desafio();


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

void TrabalhandoComDouble()
{
    


double z = 5;
Console.WriteLine(z - 1.2);

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);


double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"O alcance da 'Double' é de {min} até {max}");

double terço = 1.0 / 3.0;
Console.WriteLine(terço);  // 0.3 é 3/10 e não exatamente o mesmo que 1/3. 0.33 é 33/100
//  esse valor está mais próximo de 1/3 mas ainda não é exato. Não importa quantas casas decimais sejam adicionadas, um erro de arredondamento permanece
}

void TrabalhandoComDecimais() // O decimal trabalha com mais precisão do que o Double, mas tem um intervalo menor
{
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"O alcance da decimal é de {min} até {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
  
}


void Desafio(){
/*Desafio

Agora que você conhece os diferentes tipos numéricos, escreva o código que calcula a área de um círculo cujo raio é de 2,50 centímetros.
Lembre-se de que a área de um círculo é o raio quadrado multiplicado por PI. Uma dica: o runtime contém uma constante para PI, Math.PI que você pode usar para esse valor.
Math.PI, como todas as constantes declaradas no System.Math namespace, é um double valor. 
or esse motivo, você deve usar os valores de double em vez de decimal para esse desafio.
Você deve obter uma resposta entre 19 e 20.*/

double raioCirculo = 2.5;
// Área = PI.r.2
double areaCirculo = Math.PI * (raioCirculo * raioCirculo);
Console.WriteLine($"Sem arredondamento: {areaCirculo}");
areaCirculo = Math.Round(areaCirculo);
Console.WriteLine($"Com arredontamento: {areaCirculo}");
}
