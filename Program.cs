
// Testando função de regex
using System.ComponentModel.DataAnnotations;
using TestandoAprendizados;

//Variável Global para exemplo
int[] numeros = { 1, 2, 3, 4, 5 };

#region TESTE_REGION

int numero = 5;

int IncrementarNumero(ref int numero)
{
    return numero + 5;
}

//numero =  IncrementarNumero(numero);

Console.WriteLine(numero);
#endregion

#region REGEX
string RemoveSpecialCharacters(string text, bool allowSpace = false)
{
    string ret;

    if (allowSpace)
        ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
    else
        ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

    return ret;
}

static string removerAcentos(string texto)
{
    string comAcentos = "ÁÀÂÃÄÉÈÊËÍÌÎÏÓÒÔÕÖÚÙÛÜÇçáàâãäéèêëíìîïóòôõöúùûü";
    string semAcentos = "AAAAAEEEEIIIIOOOOOUUUUCCaaaaaeeeeiiiiooooouuuu";

    for (int i = 0; i < comAcentos.Length; i++)
    {
        texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
    }

    return texto;
}

string nome = "Otáçio";

nome += removerAcentos(nome);
//Console.WriteLine(nome);
#endregion

#region LINQ
// Consultas LINQ 
//int[] numeros = { 1, 2, 3, 4, 5 };

//var consulta =
//    from n in numeros
//    where n > 2
//    select n;

//foreach(var c in consulta){
//    System.Console.WriteLine(c.ToString());
//}
var teste = new List<string>()
{
    ""
};

#endregion

#region FIRST
//Consultas LAMBDAS
// 1 - Primeiro elemento

//var lambda = numeros.FirstOrDefault(x => x == 6, 5);

//Console.WriteLine(lambda);
#endregion

#region ANY
// 2 - Verificar se um elemento existe na lista

//Console.WriteLine(numeros.Any(x => x == 2));

#endregion

#region ALL
// 3 - Verificar se todos os elementos são de um tipo obs: serve apenas para List, IEnumerable

//var nomes = new List<Pessoa>()
//{
//    new Pessoa("Otavio",15),
//    new Pessoa("Augusto", 16),
//    new Pessoa("Reis", 17),
//    new Pessoa("Almeida", 18)
//};
////Verifica se todos são maiores que 18
//Console.WriteLine(nomes.All(x =>  x.Idade > 14));
#endregion

#region COUNT
// 4 - Contar
//Console.WriteLine(numeros.Count(x => x == 1));
//Console.WriteLine(numeros.Count());
#endregion

#region ELEMENTAT
// 5 - Contador - conta por índice

//Console.WriteLine(numeros.ElementAt(4));

#endregion

#region TAKE
// 6 - Take - pegar
// pegando os 3 primeiros
foreach (int n in numeros.Take(0..3))
{
    //   Console.WriteLine(n);
}
#endregion

#region WHERE
// 7 - Where

var x = numeros.Where(n => n >= 5);
#endregion

#region ULTIMO_ELEMENTO
// 9 - Ultimo elemento
//Tras o último elemento
//Console.WriteLine(numeros.LastOrDefault());
#endregion

#region SKIP
//10 - Skip, pula elementos

foreach (var n in numeros.Skip(2))
{
   // Console.WriteLine(n);
};
#endregion

#region BOAS_PRATICAS
//Uso do ToString()
Pessoa n1 = new Pessoa()
{
    Nome = "Otavio",
    Idade = 19
};

string n2 =  n1;

string p1 = "teste";
Pessoa p2 = p1;

Console.WriteLine(p2);
#endregion