var pt = (X: 1, Y:4);

var slope = (double)pt.Y / (double)pt.X;

Console.WriteLine ($"Uma linha da origem do ponto {pt} tem uma inclinação de {slope}.");
// Exemplo, se var pt = (X: 1, Y:4); podemos considerar da seguinte maneira:
// Para cada avanço no eixo Y, a linha sobe 4 no eixo x. slope = 4
// se var pt = (X: 2, Y:4); para cada avanço no eixo Y, a linha sobe 2 unidades no eixo Y. slope = 2
// Deste modo é calculado a inclinação. Fórmula geral(Partindo da origem) m= y/x desde que "x != 0"
// Se Y aumenta e X aumenta, inclinação positiva, se Y diminui e X aumenta, inclinação negativa. Se x=0 -> Linha vertical / (inclinação indefinida ou infinita)

pt.X = pt.X + 5;
Console.WriteLine($"O ponto agora está em {pt}");

var pt2 = pt with {Y = 10};
Console.WriteLine($"O ponto 'pt2' está em {pt2}");

var subscript = (A: 0, B: 0);
Console.WriteLine(subscript);
subscript = pt;
Console.WriteLine(subscript);

var dadosNomeados = (Nome: "Observações matinais", Temperatura: 17, Vento: 4);
var pessoa = (PrimeiroNome: "", UltimoNome: "");
var pedido = (Produto: "Palheta de guitarra", style: "Triangular", quantidade: 500, PrecoUnitario: 0.10m);
Console.WriteLine(pedido.PrecoUnitario);


public record Point(int X, int Y);