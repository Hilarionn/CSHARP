using System.Globalization;

Console.WriteLine("Digite seu número de telefone:");

string numero = Console.ReadLine();

Console.WriteLine("Qual é o tipo do seu telefone?\n 1. Fixo\n 2. Móvel");

int tipo = int.Parse(Console.ReadLine()); // O Console.ReadLine retorna STRING, para retornar int, precisamos especificar.

var telefone = (

    A: 0,

    B: 0,

    C: 0,

    D: 0,

    E: 0,

    F: 0,

    G: 0,

    H: 0,

    I: 0,

    J: 0,

    K: 0

);

if (tipo != 1 && tipo != 2)

{

    Console.WriteLine("Tipo inválido!");

}

else if (numero.Length != 11 && tipo == 2)

{

    Console.WriteLine("O número deve ter 11 dígitos, sendo dois deles o DDD, um o '9' adicional e o restante.");

}

else if (numero.Length != 10 && tipo == 1)

{

    Console.WriteLine("O número fixo deve ter 10 dígitos");

}

else{

//var telefone = (A: 3, B: 1, C:9,  D:9,  E:1 , F:1,  G:8, H:4,  I:5,  J:9,  K:9);

if (tipo == 1)

    {

         telefone = (

    A: int.Parse(numero[0].ToString()),

    B: int.Parse(numero[1].ToString()),

    C: int.Parse(numero[2].ToString()),

    D: int.Parse(numero[3].ToString()),

    E: int.Parse(numero[4].ToString()),

    F: int.Parse(numero[5].ToString()),

    G: int.Parse(numero[6].ToString()),

    H: int.Parse(numero[7].ToString()),

    I: int.Parse(numero[8].ToString()),

    J: int.Parse(numero[9].ToString()),

    K: 0

    /*char representa um caractere, e int representa um número.

    Por exemplo, o caractere '3' internamente tem um código Unicode,

    então uma conversão direta poderia significar o código do caractere, e não o valor numérico 3.*/

);

    }

else if(tipo == 2)

    {

        telefone = (

    A: int.Parse(numero[0].ToString()),

    B: int.Parse(numero[1].ToString()),

    C: int.Parse(numero[2].ToString()),

    D: int.Parse(numero[3].ToString()),

    E: int.Parse(numero[4].ToString()),

    F: int.Parse(numero[5].ToString()),

    G: int.Parse(numero[6].ToString()),

    H: int.Parse(numero[7].ToString()),

    I: int.Parse(numero[8].ToString()),

    J: int.Parse(numero[9].ToString()),

    K: int.Parse(numero[10].ToString())

);

    }

int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0;



for ( num1 = 0; num1 < telefone.A ; num1 ++ ){}

    for ( num2 = 0; num2 < telefone.B ; num2 ++ ){}

if ( num1 == telefone.A && num2 == telefone.B)

{

    Console.WriteLine($"O DDD é: {num1}{num2}");

}

if(tipo == 1)

    {

 Console.WriteLine("O restante do número é:");

    for ( num3 = 0; num3 < telefone.C ; num3 ++ ){}

            for ( num4 = 0; num4 < telefone.D ; num4 ++ ){}

                    for ( num5 = 0; num5 < telefone.E ; num5 ++ ){}

                        for ( num6 = 0; num6 < telefone.F ; num6 ++ ){}

                                  for ( num7 = 0; num7 < telefone.G ; num7 ++ ){}

                                        for ( num8 = 0; num8 < telefone.H ; num8 ++ ){}

                                                 for ( num9 = 0; num9 < telefone.I ; num9 ++ ){}

                                                        for ( num10 = 0; num10 < telefone.J ; num10 ++ ){}

    }

if (tipo == 2)

    {

 Console.WriteLine("O restante do número é:");

    for ( num3 = 0; num3 < telefone.C ; num3 ++ ){}

            for ( num4 = 0; num4 < telefone.D ; num4 ++ ){}

                    for ( num5 = 0; num5 < telefone.E ; num5 ++ ){}

                        for ( num6 = 0; num6 < telefone.F ; num6 ++ ){}

                                  for ( num7 = 0; num7 < telefone.G ; num7 ++ ){}

                                        for ( num8 = 0; num8 < telefone.H ; num8 ++ ){}

                                                 for ( num9 = 0; num9 < telefone.I ; num9 ++ ){}

                                                        for ( num10 = 0; num10 < telefone.J ; num10 ++ ){}

                                                              for ( num11 = 0; num11 < telefone.K ; num11 ++ ){}

    }

if(tipo == 2)

    {

Console.WriteLine($"{num3}{num4}{num5}{num6}{num7}-{num8}{num9}{num10}{num11}");        

    }

else if(tipo == 1)

    {

Console.WriteLine($"{num3}{num4}{num5}{num6}-{num7}{num8}{num9}{num10}");         

    }

}