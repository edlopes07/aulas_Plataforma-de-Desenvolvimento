
using System.Diagnostics;
using Aula2;

Console.WriteLine("Hello, World!");

var x = Console.ReadLine();

if (x.Contains("a"))
{

}
else
{

}

var objeto = new Aula2.Pacote.MinhaClasse();
var outro = new Aula2.Pacote.OutraClasse();

Console.WriteLine("Digite um numero: ");
var numero = int.Parse(Console.ReadLine());

var primo = new Primo();
var count = 0;
var stop = new Stopwatch();
stop.Start();
for (int i = 1; i <= numero; i++)
{
    if (primo.NumeroPrimo(i))
    {
        count++;
    }
}
stop.Stop();

Console.WriteLine("{0} em {1}ms", count, stop.ElapsedMilliseconds);
