static void MostrarNumeroMaior()
{
    /* Dado que eu leia 3 números, após a leitura desses números mostrar
    na tela qual o numero maior.
    */

    Console.WriteLine("Digite o primeiro número:");
    var num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número:");
    var num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o terceiro número:");
    var num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2 && num1 > num3)
    {
        System.Console.WriteLine($"O número maior é: {num1}");
    }
    else if (num2 > num1 && num2 > num3)
    {
        System.Console.WriteLine($"O número maior é: {num2}");
    }
    else if (num3 > num1 && num3 > num2)
    {
        System.Console.WriteLine($"O número maior é: {num3}");
    }
    else
    {
        System.Console.WriteLine("Os números são iguais!");
    }

}