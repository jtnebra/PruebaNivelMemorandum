using System.Timers;

class Ejercicio1
{
    static void Main(string[] args)
    {
        // Hago la recogida de datos mediante la consola y guardo los datos en la variables que luego usaremos
        double numero1 = PedirNumero("Introduce el primer número de la operacion: ");
        double numero2 = PedirNumero("Introduce el segundo número de la operacion: ");
        char operacion = PedirOperacion();

        // Llamo al metodo para realizar la operacion con los parametros
        double resultado = RealizarOperacion(numero1, numero2, operacion);

        // Muestro el resultado obtenido
        Console.WriteLine("El resultado obtenido es: "+ resultado);

        // Me encargo de ver si el numero es primo o no y generar la alerta
        if (!EsPrimo((int)resultado))
        {
            Console.WriteLine("Alerta: El resultado no es un numero primo");
        } else 
        {
            Console.WriteLine("El resultado es un numero primo");
        }



    }
    // Realizo esta funcion para asegurarme que los datos de la operacion estan bien introducidos
    static char PedirOperacion()
    {
        char operacion;
        bool esValido = false;

        // Bucle para seguir pidiendo la operacion
        while (!esValido)
        {
            Console.Write("Introduce el operador (+, -, *, /): ");
            string input = Console.ReadLine();

            
            if (input.Length == 1 && (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/'))
            {
                operacion = input[0];
                esValido = true;  
                return operacion;
            }
            else
            {
                Console.WriteLine("Error: Esta operación no es válida. Inténtalo de nuevo.");
            }
        }

        return '+';   
    }
    // Realizo esta funcion para asegurarme que los numeros estan bien introducidos
    static double PedirNumero(string mensaje)
    {
        double numero;
        bool esValido = false;

        // Bucle para seguir pidiendo el numero
        while (!esValido)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            try
            {
                numero = Convert.ToDouble(input);
                esValido = true;  
                return numero;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Esto no es un número. Inténtalo de nuevo.");
            }
        }

        return 0; 
    }
    // Realizo esta funcion para saber si el numero es primo o no 
    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    // Hago esta funcion que es la que realiza la operacion dependiendo de los parametros introducidos
    static double RealizarOperacion(double numero1, double numero2, char operacion)
    {
        switch (operacion)
        {
            case '+':
                return numero1 + numero2;
            case '-':
                return numero1 - numero2;
            case '*':
                return numero1 * numero2;
            case '/':
                if (numero2 != 0)
                {
                    return numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero. ");
                    return 0;
                }
            default:
                Console.WriteLine("El caracter de la operacion no es valido.");
                return 0;

        }
    }
}
