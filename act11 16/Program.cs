
Console.WriteLine("Ingrese un numero");
static string espositivo(int n)
{
    string resultado = "";
    if (n > 0)
    {
       resultado="El numero es positivo";
    }
    else
    {
       resultado="El numero es negativo";
    }
    return resultado;
}

int n=int.Parse(Console.ReadLine());
string resultado=espositivo(n);
Console.WriteLine(resultado);