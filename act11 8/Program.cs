Console.WriteLine("Ingrese el cuadarado de un numero");
double cuadradonumero(int n)
{
   return Math.Pow(n, 2);
}
int numero=int.Parse(Console.ReadLine());
double r;

r = cuadradonumero(numero);
Console.WriteLine(r);
