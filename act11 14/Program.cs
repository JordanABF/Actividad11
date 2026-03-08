static double dividir(int a, int b)
{
    return a / b;
}
int n1, n2;
double resultado;
Console.WriteLine("INGRESE EL HA DIVIDIR NUMERO:");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE POR CUANTO SE VA A DIVIDIR");
n2 = int.Parse(Console.ReadLine());
resultado = dividir(n1, n2);
Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + resultado);