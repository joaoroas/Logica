/* Faça um programa que solicite 10 frutas e tambem 10 valores de frutas.
   Ao final do programa mostrar a soma total das frutas no carrinho,
   e uma lista com o nome da fruta e seu respectivo valor.
*/

List<string> frutas = new List<string>();
List<int> quantidade = new List<int>();

for (var i = 0; i < 10; i++)
{
    System.Console.WriteLine("Digite o nome da fruta:");
    frutas.Add(Console.ReadLine());
    System.Console.WriteLine("Digite a o valor:");
    int a = Convert.ToInt32(Console.ReadLine());
    quantidade.Insert(i, a);
}


for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"Fruta: {frutas[i]} Quantidade: {quantidade[i]}");
}

System.Console.WriteLine($"A quantidade de frutas no carrinho é: {quantidade.Sum()}");


