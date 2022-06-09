//-------------------------------------------------------------------------------------------------------
List<int> numeros = new() { 1, 2, 3, 4, 5 };
var numero = numeros.FirstOrDefault(x => x == 6, -1);
Console.WriteLine($"O numero é: {numero}"); //-1

//-------------------------------------------------------------------------------------------------------

List<string> nomes = new() { "Lista01" };
List<string> testes = new List<string> { "A", "B", "C" };
var nome = nomes.SingleOrDefault(x => x == "Lista02", "Não encontrado");
Console.WriteLine(nome); // Não encontrado

//--------------------------------------------------------------------------------------------------------

List<Produto> produtos = new()
{
    new(){id= 1, nome = "produto1", valor= 150},
    new(){id= 1, nome = "produto2", valor = 50},
    new(){id= 1, nome = "produto3", valor = 100}
};
var maisbarato = produtos.MinBy(x => x.valor);
var maiscaro = produtos.MaxBy(x => x.valor);
Console.WriteLine(maisbarato?.valor); //50
Console.WriteLine(maiscaro?.valor); //150

//-------------------------------------------------------------------------------------------------------

var numbers = Enumerable.Range(1, 500);
var chunks = numbers.Chunk(100); 
foreach (var valor in chunks)
{
    Console.WriteLine($"{valor.First()} ... {valor.Last()}"); // mostra de 100 em 100
}

//-------------------------------------------------------------------------------------------------------

List<int> numes = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var teste = numes.ElementAt(^2);
Console.WriteLine(teste); // 8

//-------------------------------------------------------------------------------------------------------

var take = Enumerable.Range(1, 500);
var range = take.Take(50..70);
foreach (var item in range)
{
    Console.WriteLine(item); //51 ... 70
}

//-------------------------------------------------------------------------------------------------------