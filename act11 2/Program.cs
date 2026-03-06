void mostrarnombre(string nombre)
{
    Console.WriteLine("Hola, "+nombre );
}

static void main()
{
    Console.WriteLine("Ingrese su nombre:");
    string nombre1 = Console.ReadLine();
    mostrarnombre(nombre1);

}