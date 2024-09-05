class Ejercicio2
{
    static void Main(string[] args)
    {
        // Creo los array para almacenar los nombres y las edades de la personas
        string[] nombres = new string[5];
        int[] edades = new int[5];

        // Hago un bucle for para introducir todos los datos 
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona " + i + ":");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("_____________________________");

            Console.WriteLine("Ingrese la edad de la persona " + i + ":");
            edades[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_____________________________");

        }

        // Muestro los datos filtrando por la edad que en este caso son mayor o igual de 18 años
        Console.WriteLine("Personas mayores de 18 años.");
        Console.WriteLine("------------------------------");
        for (int i = 0;i < 5; i++)
        {
            if (edades[i] >= 18)
            {
                Console.WriteLine(nombres[i] + " tiene " + edades[i]);
            }
        }


    }
}