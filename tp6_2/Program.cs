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