Console.WriteLine("ingresar una cadena:");
string cadena = Console.ReadLine();
Console.WriteLine("longitud: " + cadena.Length);
Console.WriteLine("ingresar otra cadena:");
string cadena2 = Console.ReadLine();
Console.WriteLine("cadena concatenada: " + string.Concat(cadena, cadena2));
string cadena3 = cadena.Substring(3);

Console.WriteLine("sub string con for each: ");
foreach (char i in cadena3)
{
    Console.WriteLine(i);
}