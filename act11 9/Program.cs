static int sumar(int a,int b)
{
    return a + b;
}
int n1, n2,resultado;
Console.WriteLine("INGRESE EL PRIMER NUMERO:");
n1=int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
n2=int.Parse(Console.ReadLine());
resultado=sumar(n1,n2);
Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + resultado);

