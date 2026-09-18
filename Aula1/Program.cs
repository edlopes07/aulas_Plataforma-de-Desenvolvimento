using System.Threading.Channels;

Console.WriteLine("Hello, World!");

var x = 10;
int y = 11;

string nome = "Texto";
var texto = "Teste";

var input = Console.ReadLine();

Console.WriteLine("Você digitou: {0}", input);
Console.WriteLine($"Você digitou: {input}");

var preco = 10.99;
Console.WriteLine("{0:C}", preco); // Currency

var data = new DateTime(2026, 8, 1);
var agora = DateTime.Now;
var hoje = DateTime.Today;
var amanha = DateTime.Today.AddDays(1);
var meiodia = DateTime.Today.AddHours(12);
Console.WriteLine("{0:dd/MM/yyyy}", hoje);
Console.WriteLine("{0:HH:mm:ss}", agora);
Console.WriteLine("{0} - {1}", 
    hoje.DayOfYear, 
    hoje.DayOfWeek);

var s = "aaaaa" + "baaaa";
var s2 = "2" + "2"; //22
var s3 = 2 + 2; // 4
var letra = 'a';

var array = new int[] { 1, 2, 3 };
var lista = new List<int> { 1, 2, 3 };
var fila = new Queue<int>();
var pilha = new Stack<int>();

Console.WriteLine(array[0]);
Console.WriteLine(lista[2]);
