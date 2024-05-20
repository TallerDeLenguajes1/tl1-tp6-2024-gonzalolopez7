int opcion;
bool z;
double a, b;

do
{
    
    Console.WriteLine("\n1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. dividir");
    Console.WriteLine("5. valor absoluto");
    Console.WriteLine("6. cuadrado");
    Console.WriteLine("7. raiz");
    Console.WriteLine("8. seno");
    Console.WriteLine("9. coseno");
    Console.WriteLine("10. parte entera de un float");
    Console.WriteLine("11. salir");


    z = int.TryParse(Console.ReadLine(), out opcion);
    if (z && 0 < opcion && opcion < 11)
    {

        do
        {
            Console.WriteLine("a: ");
            z = double.TryParse(Console.ReadLine(), out a);
            if (!z)
                Console.WriteLine("numero no valido");

            if (opcion == 7 && a < 0)
            {
                Console.WriteLine("no se puede calcular raiz de un numero < 0");
                z = false;
            }

        } while (!z);
        if (opcion < 5)
        {

            do
            {
                Console.WriteLine("b:");
                z = double.TryParse(Console.ReadLine(), out b);
                if (!z)
                    Console.WriteLine("numero no valido");

            } while (!z);
            
        } else
        {
            b = 0;
        }
        
        calculadora(opcion, a, b);

    } else
    {
        if (opcion != 11)
            Console.WriteLine("opcion no valida");
    }

} while (opcion != 11);

do
{
    
    Console.WriteLine("\nnumero 1: ");
    z = double.TryParse(Console.ReadLine(), out a);
    if (!z)
        Console.WriteLine("numero no valido");

} while (!z);

do
{
    
    Console.WriteLine("numero 2: ");
    z = double.TryParse(Console.ReadLine(), out b);
    if (!z)
        Console.WriteLine("numero no valido");

} while (!z);

if (a > b)
    Console.WriteLine("mayor: " + a + " - menor: " + b);
else
    Console.WriteLine("mayor: " + b + " - menor: " + a);

double sumar(double a, double b) {

    return a+b;
}

double multiplicar(double a, double b) {

    return a*b;
}

double dividir(double a, double b) {

    return a/b;
}

double valorAbsoluto(double a) {

    if (a > 0)
    {
        return a;
    } else
    {
        return -a;
    }
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

        case 5:
            Console.WriteLine("resultado: " + valorAbsoluto(a));
            break;
        
        case 6:
            Console.WriteLine("resultado: " + a*a);
            break;

        case 7:
            Console.WriteLine("resultado: " + Math.Sqrt(a));
            break;
        
        case 8:
            Console.WriteLine("resultado: " + Math.Sin(a * Math.PI/180));
            break;

        case 9:
            Console.WriteLine("resultado: " + Math.Cos(a * Math.PI/180));
            break;

        case 10:
            Console.WriteLine("resultado: " + Math.Truncate(a));
            break;

        default:
            Console.WriteLine("error");
            break;
    }

}
