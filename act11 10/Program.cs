Console.WriteLine("INGRESE UN TEXTO: ");
string texto = Console.ReadLine();
Console.WriteLine("INGRESE CUANTAS VECES DESEA REPETIR EL TEXTO: ");
int repetir = int.Parse(Console.ReadLine());
string imprimirrepetido(string texto, int veces)
{
    string resultado = "";
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine((i+1) + " " + texto);
    }
    return resultado;

}
Console.WriteLine(imprimirrepetido(texto, repetir));
