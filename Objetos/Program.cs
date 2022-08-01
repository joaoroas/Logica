using Objetos;

var qtdNotas = 3;

var alunos = new List<Aluno>();

Console.WriteLine("Digite a quantidade de alunos:");
var qtdAlunos = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtdAlunos; i++)
{
    System.Console.WriteLine($"Digite o nome do Aluno: {i + 1}");
    var aluno = new Aluno();
    aluno.Nome = Console.ReadLine();
    aluno.Notas = new List<double>();


    for (int x = 0; x < qtdNotas; x++)
    {
        System.Console.WriteLine($"Digite a nota {x + 1} do {aluno.Nome}");
        aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
    }
    alunos.Add(aluno);
}
foreach (var aluno in alunos)
{
    System.Console.WriteLine("=========================");
    System.Console.WriteLine($"Aluno: {aluno.Nome}");

    double notas = 0;

    foreach (var nota in aluno.Notas)
    {
        notas += nota;
    }
    var media = notas/aluno.Notas.Count;
    System.Console.WriteLine($"Média é de : {media.ToString("0.00")} ");

}
Console.WriteLine("Aperte enter para finalizar");
Console.ReadLine();

