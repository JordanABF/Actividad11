Console.WriteLine("INGRESE EL PRIMER NUMERO");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
int n2 = int.Parse(Console.ReadLine());
static string menor(int n1, int n2)
{
    string resultado = "";
    if (n1 < n2)
    {
        resultado = "El numero menor es: " + n1;
    }
    else if (n2 < n1)
    {
        resultado = "El numero menor es: " + n2;
    }
    else
    {
        resultado = "Los numeros son iguales";
    }
    return resultado;
}

Console.WriteLine(menor(n1, n2));