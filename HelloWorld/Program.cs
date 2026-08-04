using System.Net.Security;

Console.WriteLine("Hello, World!");     //WriteLine quebra linhas automaticamente, diferente do Write.

string aFriend = "Bill";
Console.WriteLine(aFriend);


aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Olá, " + aFriend + "."); 

//interpolação de cadeia de caracteres. Adicionando $ antes das aspas, podemos chamar a variável com {} 
Console.WriteLine($"Olá {aFriend}! este é um exemplo de interpolação");

//

string firstFriend = "maria";
string seconfFriend = "Sage";
Console.WriteLine($"Meus amigos são {firstFriend} e { seconfFriend}");

// Para contar caracteres de uma string, podemos utilizar:
Console.WriteLine($"O nome {firstFriend} possui {firstFriend.Length} caracteres");
Console.WriteLine($"O nome {seconfFriend} possui {seconfFriend.Length} caracteres");

// Trimm (Remover espaços vazios)

string greeting = "    Mensagem    ";
Console.WriteLine($"[{greeting}]");  // --> Os colchetes abertos já estão dentro da mensagem , nos ajuda a ver os espaços removidos da variável greeting.


string trimmedGreeting = greeting.TrimStart();  // Trimm no começo da string
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();    // Trimm no Final da String
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();   // Trimm geral
Console.WriteLine($"[{trimmedGreeting}]");

// Pesquisas e substituição em cadeias de caracteres

string sayHello = "Hello World!"; 
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Olá");  // "Traduzindo" o Hello para olá, utilizando o Replace. É necessário depois imprimir a variável
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("World", "Mundo");
Console.WriteLine(sayHello);

// Tornando caracteres maiúsculos ou minúsculos

Console.WriteLine(sayHello.ToUpper()); // Maiúsculo
Console.WriteLine(sayHello.ToLower());// Minúsculo

string letraDeMusica = "They'll be callin' me royalty";

Console.WriteLine(letraDeMusica.Contains("callin"));
Console.WriteLine(letraDeMusica.Contains("alone"));
Console.WriteLine(letraDeMusica.Contains("Royalty", StringComparison.OrdinalIgnoreCase));  // O StringComparsion retira a característica de CaseSensitive. Booleana = True
Console.WriteLine($"Contém 'Royalty?' {letraDeMusica.Contains("Royalty", StringComparison.OrdinalIgnoreCase)}"); // Imprime uma mensagem antes de comparar a variável
