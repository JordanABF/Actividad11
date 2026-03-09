Console.WriteLine("INGRESE EL PRIMER NUMERO");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
int n2=int.Parse(Console.ReadLine());
static string multiplo(int n1, int n2)
{
    string resultado = "";
    if (n1 % n2 == 0)
    {
        resultado = n1 + " es multiplo de " + n2;
    }
    else
    {
        resultado = n1 + " no es multiplo de " + n2;
    }
    return resultado;
}

Console.WriteLine(multiplo(n1, n2));
