/* Faça um programa que solicite 10 frutas e tambem 10 valores de frutas.
   Ao final do programa mostrar a soma total das frutas no carrinho,
   e uma lista com o nome da fruta e seu respectivo valor.
*/



// Uma lista dentro da outra, incremento do valor total, formatação duas casas decimais.
static void ProgramadorFez()
{
List<List<string>> listaFrutas = new List<List<string>>();

for (var i = 0; i < 2; i++)
{
    List<string> lista = new List<string>();
    Console.WriteLine("Digite o nome da fruta:");
    lista.Add(Console.ReadLine());
    Console.WriteLine("Digite a o valor:");
    lista.Add(Console.ReadLine());

    listaFrutas.Add(lista);
}
double total = 0;
foreach (var item in listaFrutas)
{
    Console.WriteLine($"Fruta: {item[0]} Valor R$: {item[1]}");
    Console.WriteLine("==========================");

    total += Convert.ToDouble(item[1]);
}
System.Console.WriteLine($"Valor total da compra R$: {total.ToString("0.00")}");
}



// Duas listas separadas, Valor total usando Linq, Formatação representando moeda em reais.
static void ComoEuFiz()
{
    List<string> frutas = new List<string>();
    List<string> valor = new List<string>();

    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine("Digite o nome da fruta:");
        frutas.Add(Console.ReadLine());
        Console.WriteLine("Digite a o valor:");
        valor.Add(Console.ReadLine());
    }
    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine($"Fruta: {frutas[i]} Preço R$: {valor[i]}");
        Console.WriteLine("=================================");
    }

    decimal total = 0;
    total = valor.Sum(x => Convert.ToDecimal(x));
    Console.WriteLine($"O valor total da compra é  {total.ToString("C")}");
}




