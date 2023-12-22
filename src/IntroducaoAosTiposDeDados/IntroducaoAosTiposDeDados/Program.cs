// See https://aka.ms/new-console-template for more information
using IntroducaoAosTiposDeDados;

Console.WriteLine("Hello, World!");

//Numéricos
int exemploInteiro = 10; //32 bits - > -2.147.483.648 a 2.147.483.647
uint exemploUInt = 10; //32 bits - > 0 a 4.294.967.295
long exemploLong = 10; //64 bits - > -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
ulong exemploULong = 10; //64 bits - > 0 a 18.446.744.073.709.551.615

//Pontos flutuantes
float exemploFloat = 10.5f; //32 bits - > -3.402823e38 a 3.402823e38
double exemploDouble = 10.5; //64 bits - > -1.79769313486232e308 a 1.79769313486232e308
decimal exemploDecimal = 10.5m; //128 bits - > ±1.0 × 10e−28 a ±7.9 × 10e28

//caracteres
char exemploChar = 'a'; //16 bits - > U+0000 a U+ffff

//booleanos
bool exemploBool = true; //8 bits - > true ou false


//////////////////////////////
//string
string exemploString = "Hello World!"; //n bits - > qualquer texto



//Console.WriteLine("O A vale" + ('A' + 1));

//Console.WriteLine("O a vale" + ('a' + 36));



int a = 10;
int b = a;
b = b + 1;

Console.WriteLine(b);


Pessoa p1 = new Pessoa();
p1.Nome = "João";
Pessoa p2 = p1;

p2.Nome = "Maria";

Console.WriteLine(p1.Nome);


int exemploInteiro2 = 10;
float exemploFloat2 = exemploInteiro2;


var maximoFloat = float.MaxValue;

int exemploInteiro3 = Convert.ToInt32(maximoFloat);



Pessoa pessoa = new Pessoa();
pessoa.Nome = "João";   


Estudante estudante = new Estudante();
estudante.Nome = "Maria";
estudante.Matricula = "123456";


estudante = (Estudante)pessoa;






