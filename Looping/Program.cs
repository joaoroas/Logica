using System.Collections.Generic;

//Tabuada();
//VarrerLista();
//LoopingWhile();
//LoopingDoWhile();

static void Tabuada()
{
    System.Console.WriteLine("Digite até qual número quer a tabuada:");
    var mult = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Você quer a tabuada de qual número?");
    var numero = Convert.ToInt32(Console.ReadLine());

    for(var i = 1; i <= mult; i++)
    {
        System.Console.WriteLine($"{numero} X {i} = {numero * i}");
    }
}

static void VarrerLista()
{
    List<int> listaDados = new List<int>();
    listaDados.Add(1);
    listaDados.Add(2);
    listaDados.Add(3);
    listaDados.Add(4);
    listaDados.Add(5);
    listaDados.Add(6);

    foreach (var dados in listaDados)
    {
        System.Console.WriteLine(dados);
    }

}

static void LoopingWhile()
{
    var i = 0;
    while (i < 10)
    {
        System.Console.WriteLine("Fazendo While");
        i += 1;
    }
}

static void LoopingDoWhile()
{
    var i = 0;
    do
    {
        System.Console.WriteLine("Fazendo DoWhile!");
        i += 1;
    }
    while(i < 10);
}