int opcion;
bool z;
double a, b;

do
{
    
    Console.WriteLine("\n1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. dividir");
    Console.WriteLine("5. salir");

    z = int.TryParse(Console.ReadLine(), out opcion);
    if (z && 0 < opcion && opcion < 5)
    {

        do
        {
            Console.WriteLine("a: ");
            z = double.TryParse(Console.ReadLine(), out a);
            if (!z)
                Console.WriteLine("numero no valido");

        } while (!z);
        do
        {
            Console.WriteLine("b:");
            z = double.TryParse(Console.ReadLine(), out b);
            if (!z)
                Console.WriteLine("numero no valido");

        } while (!z);
        
        calculadora(opcion, a, b);

    } else
    {
        if (opcion != 5)
            Console.WriteLine("opcion no valida");
    }

} while (opcion != 5);

double sumar(double a, double b) {

    return a+b;
}

double multiplicar(double a, double b) {

    return a*b;
}

double dividir(double a, double b) {

    return a/b;
}

void calculadora(int opcion, double a, double b) {

    switch (opcion)
    {
        case 1:
            Console.WriteLine("resultado: " + sumar(a, b));
            break;
        
        case 2:
            Console.WriteLine("resultado: " + sumar(a, -b));
            break;

        case 3:
            Console.WriteLine("resultado: " + multiplicar(a, b));
            break;
        
        case 4:
            Console.WriteLine("resultado: " + dividir(a, b));
            break;

        default:
            Console.WriteLine("error");
            break;
    }

}
