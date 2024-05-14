
int numero;
int invertido = 0;
int auxiliar;
string ingreso;
bool respuesta;


do
{
    Console.WriteLine("Ingrese un numero: ");
    ingreso = Console.ReadLine();

    // esta funcion ya te guarda lo que esté en ingreso en numero
    // no necesitas volver a igualar mas abajo
    respuesta = int.TryParse(ingreso, out numero);
    if (respuesta == false)
    {
        Console.WriteLine("Este programa solo acepta numeros.");
    }
    
} while (respuesta == false);

while (numero > 0)
{
    auxiliar = numero % 10;
    invertido = (invertido * 10) + auxiliar;
    numero = numero / 10;
}

Console.WriteLine("El numero invertido es: " + invertido);