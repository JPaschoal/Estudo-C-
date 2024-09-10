//1
using StringOkimoto;

string str = "ABCTPX";

bool hasTPX = true;

hasTPX = str.Contains("TPX");

Console.WriteLine(hasTPX);

//2

//.1
var posicao = str.IndexOf("TPX");

Console.WriteLine(posicao);

//.2
List<string> stringList = new List<string>
{
    str.Substring(0, posicao),
    str.Substring(posicao)
};

foreach (var substring in stringList)
{
    Console.WriteLine(substring);
}


//.3
for (int i = 0; i < stringList.Count; i++)
{
    stringList[i] = stringList[i].Replace("X", "");
}

//3

//.1

stringList.Sort();

foreach (var substring in stringList)
{
    Console.WriteLine(substring);
}

//.2

var newList = stringList.Where(x => x.Contains("ABC")).ToList();

//.3
foreach (var substring in newList)
{
    Console.WriteLine(substring);
}

//4

//.1
string strNumber = "123";
int number = 0;

if (int.TryParse(strNumber, out number))
{
    Console.WriteLine(number);
}

decimal numDecimal = 3.14m;
double numDouble = 3.14;
float numFloat = 3.14f;

Console.WriteLine(numDecimal);
Console.WriteLine(numDouble);
Console.WriteLine(numFloat);

List<Conversor> conversorList = new List<Conversor>
{
    new Conversor(1, 1.1m, 1.1, 1.1f),
    new Conversor(2, 2.2m, 2.2, 2.2f),
    new Conversor(3, 3.3m, 3.3, 3.3f),
    new Conversor(4, 4.4m, 4.4, 4.4f),
    new Conversor(5, 5.5m, 5.5, 5.5f)
};

conversorList.Add(new Conversor(6, 6.6m, 6.6, 6.6f));

foreach (var item in conversorList)
{
    Console.WriteLine(item.IntNumber);
    Console.WriteLine(item.DecimalNumber);
    Console.WriteLine(item.DoubleNumber);
    Console.WriteLine(item.FloatNumber);
}

for (int i = 0; i < conversorList.Count; i++)
{
    Console.WriteLine(conversorList[i].IntNumber);
    Console.WriteLine(conversorList[i].DecimalNumber);
    Console.WriteLine(conversorList[i].DoubleNumber);
    Console.WriteLine(conversorList[i].FloatNumber);
}

int iterator = 0;

while (iterator < conversorList.Count)
{
    Console.WriteLine(conversorList[iterator].IntNumber);
    Console.WriteLine(conversorList[iterator].DecimalNumber);
    Console.WriteLine(conversorList[iterator].DoubleNumber);
    Console.WriteLine(conversorList[iterator].FloatNumber);
    iterator++;
}


ClasseTeste teste = new ClasseTeste();
Console.WriteLine(teste.str);
ClasseTeste teste2 = new ClasseTeste("QWE", "STR", "TESTE");
Console.WriteLine(teste2.str);


teste2.PrintarEnum(EnumTeste.PrimeiraStr);
teste2.PrintarEnum(EnumTeste.SegundaStr);
teste2.PrintarEnum(EnumTeste.TerceiraStr);

