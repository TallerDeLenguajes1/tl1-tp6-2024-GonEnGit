
int indice;
int longitud;
int primerNum;
int segundoNum;
int resultado = 0;
string aBuscarUno = "prueba";
string aBuscarDos = "gato";
char operador;
char[] operadores = { '+', '-', '*', '/'};
string linea = "\nCadena de prueba para Ejercicio 4 TP 6";
string ingreso;
string concatenadas;
string lineaIngresada;
// acordate que los arreglos se declaran al reves
// lo mejor es que C# determina el tamaño solo despues
string[] palabras;
string[] numerosAOperar = null;
bool prueba;


Console.WriteLine($"\nTexto original: {linea}\n");

// para la longitud existe simplemente .Length
longitud = linea.Length;
Console.WriteLine($"Cantidad de caracteres: {longitud}, incluidos los espacios\n");

// ingresar otra cadena y concatenar
Console.WriteLine("Ahora, ingresa alguna linea de texto: ");
lineaIngresada = Console.ReadLine();

// podes usar replace para sacar el salto de linea
lineaIngresada = lineaIngresada.Replace("\r\n", "");

// para concatenar podes usar += como si fuera matematicas
concatenadas = linea + " " + lineaIngresada;
Console.WriteLine("\nConcatenadas: " + concatenadas);


// implementa una parte corta de la calculadora...
do
{
    Console.WriteLine("\nIngrese el primer Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out primerNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

do
{
    Console.WriteLine("\nIngrese el segundo Numero: ");
    ingreso = Console.ReadLine();
    prueba = int.TryParse(ingreso, out segundoNum);

    if (!prueba)
    {
        Console.WriteLine("Esta Calculadora solo puede usar numero.");
    }

} while (prueba == false);

do
{
    Console.WriteLine("\nElija una operacion (+, -, *, /): ");
    ingreso = Console.ReadLine();
    prueba = char.TryParse(ingreso, out operador);
    if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
    {
        Console.WriteLine("Solo se pueden usar estos 4 operadores.");
        prueba = false;
    }
} while (!prueba);

switch (operador)
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

Console.WriteLine($"\nEl resultado de {primerNum} {operador} {segundoNum} es {resultado}\n");

// recorrer con foreach y mostrar
Console.WriteLine("Mostrando la frase letra por letra:");
foreach (char caracter in concatenadas)
{
    Console.WriteLine($"{caracter}");
}

// para comparar strings hay dos funciones: Compare(stringA, stringB) y CompareTo(stringB)
// ambas funciones actuan como en C, devuelven 0 si las cadenas son iguales, un numero positivo
// si A es mas grande que B o un numero negativo si A es mas chico que B
palabras = concatenadas.Split(' ');

// comparando con String.Compare()
foreach (string palab in palabras)
{
    resultado = String.Compare(palab, aBuscarUno);
    if(resultado == 0)
    {
        prueba = true;
    }
}
if (prueba)
{
    Console.WriteLine($"\nLa palabra '{aBuscarUno}' está en la cadena concatenada.\n");
}
else
{
    Console.WriteLine($"\nLa palabra '{aBuscarUno}' no está en la cadena concatenada.\n");
}

// comparando con .CompareTo()
prueba = false;
foreach (string palab in palabras)
{
    resultado = palab.CompareTo(aBuscarDos);
    if (resultado  == 0)
    {
        prueba = true;
    }

}
if (prueba)
{
    Console.WriteLine($"\nLa palabra '{aBuscarDos}' está en la cadena concatenada.\n");
}
else
{
    Console.WriteLine($"\nLa palabra '{aBuscarDos}' no está en la cadena concatenada.\n");
}


// .ToUpper y .ToLower
concatenadas = concatenadas.ToUpper();
Console.WriteLine("\nLa cadena en mayusculas: " + concatenadas);

concatenadas = concatenadas.ToLower();
Console.WriteLine("\nLa cadena En minusculas: " + concatenadas);

// .Split() en un punto
Console.WriteLine("\nAhora, ingresa alguna linea de texto que contenga varios puntos: ");
lineaIngresada = Console.ReadLine();

palabras = lineaIngresada.Split('.');
Console.WriteLine("\n");
foreach (string palab in palabras)
{
    Console.WriteLine($"{palab}");
}


// hacer una operacion de un string
Console.WriteLine("\nPor ultimo una operacion simple (+, -, *, /): ");
lineaIngresada = Console.ReadLine();

foreach (char op in operadores)
{
    indice = lineaIngresada.IndexOf(op);
    if (indice != -1)                       // .IndesOf() devuelve -1 si no encuentra el char que buscas
    {
        operador = lineaIngresada[indice];
        numerosAOperar = lineaIngresada.Split(operador);
    }
}

int.TryParse(numerosAOperar[0], out primerNum);
int.TryParse(numerosAOperar[1], out segundoNum);

// no podes concatenar para hacer la operacion, no te queda otra que un switch o if...
switch (operador)
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

Console.WriteLine($"\n{primerNum} {operador} {segundoNum} = {resultado}\n");
