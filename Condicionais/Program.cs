/*Dado que eu leia 2 números, se o primeiro número for maior que 100, mostre "Nossa que número alto".
Se o valor do segundo número for maior que 10, atualize o primeiro número e verifique se é maior que 100,
se for mostre "Nossa que número alto".
se o primeiro número for menor ou igual a 100 mostre "ok está tudo certo".
se o segundo número for menor ou igual a 10 mostre "Eita que número pequeno".
*/

System.Console.WriteLine("Digite o primeiro número:");
var a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o segundo número:");
var b = Convert.ToInt32(Console.ReadLine());

if (a > 100)
{
    System.Console.WriteLine("Nossa que número alto!");
}
if (b > 10)
{
    System.Console.WriteLine($"O primeiro número é: {a}");

}
if (a > 100)
{
    System.Console.WriteLine("Nossa que número alto!");
}
if (a <= 100)
{
    System.Console.WriteLine($"número: {a} ok está tudo certo ");
}
if (b <= 10)
{
    System.Console.WriteLine($"Numero: {b} Eita que número pequeno");
}