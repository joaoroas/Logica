
static void CalcularTroco()
{
    /* João é cobrador de ônibus, ao atender um passageiro.
     João recebe um valor em dinheiro.
     Faça um programa que solicite o dado de entrada, menos o 
     dado de saída, mostrando o troco que ele precisa dar ao passageiro.
    */

    var valorPassagem = 10;

    System.Console.WriteLine("Digite o valor recebido:");
    var valorPago = Convert.ToDouble(Console.ReadLine());


    if (valorPago < valorPassagem)
    {
        System.Console.WriteLine("A quantia não está completa:");
        System.Console.WriteLine($"O valor da passagem é: {valorPassagem}");
        return;
    }
    else
    {
        var troco = valorPago - valorPassagem;

        System.Console.WriteLine($"O troco deve ser de: {troco}");
        System.Console.WriteLine("Pressione enter para finalizar:");
        Console.ReadLine();
    }
}