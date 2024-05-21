int primerNum;
int segundoNum;
float resultado = 0;
char operacion;
string ingreso;
bool prueba;

do
{
    Console.WriteLine("Ingrese el primer Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out primerNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

do
{
    Console.WriteLine("Ingrese el segundo Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out segundoNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

do
{
    Console.WriteLine("Elija una operacion (+, -, *, /): ");
    ingreso = Console.ReadLine();
    prueba = char.TryParse(ingreso, out operacion);
    if (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
    {
        Console.WriteLine("Solo se pueden usar estas 4 operaciones.");
        prueba = false;
    }
} while (!prueba);

switch (operacion)
{
    case '+':
        resultado = primerNum + segundoNum;
        break;

    case '-':
        resultado = primerNum - segundoNum;
        break;
    
    case '*':
        resultado = primerNum * segundoNum;
        break;

    case '/':
        resultado = primerNum / segundoNum;
        break;
}

Console.WriteLine("Resultado = " + resultado);

int primerNum;
int segundoNum;
int tercerNum;
int absoluto;
double cuadrado;
double raiz;
double seno;
double coseno;
int parteEntera;
string ingreso;
bool prueba;

do
{
    Console.WriteLine("Ingrese un numero: ");
    ingreso = Console.ReadLine();

    prueba = int.TryParse(ingreso, out primerNum);
    if (!prueba)
    {
        Console.WriteLine("Debe ingresar un numero.");
    }
} while (!prueba);

// busca si existen funciones para esto
absoluto = Math.Abs(primerNum);
cuadrado = Math.Pow(primerNum, 2);
raiz = Math.Sqrt(primerNum);
seno = Math.Sin(primerNum);
coseno = Math.Cos(primerNum);

Console.WriteLine("Valor Absoluto = " + absoluto);
Console.WriteLine("Cuadrado = " + cuadrado);
Console.WriteLine("Raiz = " + raiz);
Console.WriteLine("Seno = " + seno);
Console.WriteLine("Coseno = " + coseno);

Console.WriteLine("Ahora ingrese 2 numeros para buscar mayor y menor.");
do
{
    Console.WriteLine("Ingrese el primer Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out primerNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

do
{
    Console.WriteLine("Ingrese el segundo Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out segundoNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

if(primerNum > segundoNum)
{
    Console.WriteLine("Maximo: " + primerNum);
    Console.WriteLine("Minimo: " + segundoNum);
}
else
{
    Console.WriteLine("Maximo: " + segundoNum);
    Console.WriteLine("Minimo: " + primerNum);
}