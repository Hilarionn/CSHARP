var pt = (X: 2, Y:4);

var slope = (double)pt.Y / (double)pt.X;

Console.WriteLine ($"Uma linha da origem do ponto {pt} tem uma inclinação de {slope}.");
// Exemplo, se var pt = (X: 1, Y:4); podemos considerar da seguinte maneira:
// Para cada avanço no eixo Y, a linha sobe 4 no eixo x. slope = 4
// se var pt = (X: 2, Y:4); para cada avanço no eixo Y, a linha sobe 2 unidades no eixo Y. slope = 2
// Deste modo é calculado a inclinação.