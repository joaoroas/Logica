/*Seu Roberto era o maioral, ele tinha um amigo jhony que era um cara legal.
jhony perguntou para o roberto. Roberto qual das opções você prefere escolher.
1, 2, 3 ou 4.Se o roberto escolher o 1 mostre banana, se o 2 maçã, se o 3 mamão e
se o 4 mostre melão. Faça um programa que leia os dados e mostre o resultado.
*/

Console.WriteLine("Qual opção você deseja escolher: 1, 2, 3 ou 4?");
var opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Banana");
        break;

    case 2:
        Console.WriteLine("Maçã");
        break;

    case 3:
        Console.WriteLine("Mamão");
        break;

    case 4:
        Console.WriteLine("Melão");
        break;


}