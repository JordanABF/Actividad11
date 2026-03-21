
Console.WriteLine("INGRESE UN NUMERO");
int n=int.Parse(Console.ReadLine());
int espar(int n)
{
    return n % 2;
}
if(espar(n)==0)
{
    Console.WriteLine("EL NUMERO ES PAR");
}
else
{
    Console.WriteLine("EL NUMERO ES IMPAR");
}
