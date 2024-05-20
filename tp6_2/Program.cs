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
