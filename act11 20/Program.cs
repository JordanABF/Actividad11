Console.WriteLine("INGRESE ALGUN TEXTO");
string texto = Console.ReadLine();
static string contarletras(string texto)
{
    int contador = 0;
    for (int i = 0; i < texto.Length; i++)
    {
        if (char.IsLetter(texto[i]))
        {
            contador++;
        }
    }
    return "El numero de letras es: " + contador;
}