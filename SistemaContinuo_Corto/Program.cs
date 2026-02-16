using System;

class Program
{
    static void Main()
    {
        int pisoActual;
        int pisoDestino;

        //  Entrada
        Console.Write("Ingrese piso actual: ");
        pisoActual = int.Parse(Console.ReadLine());

        Console.Write("Ingrese piso destino: ");
        pisoDestino = int.Parse(Console.ReadLine());

        //  Variables continuas
        double posicion = pisoActual;   // x(t)
        double velocidad = 0.0;         // v(t)
        double aceleracion = 0.2;       // a(t)

        Console.WriteLine("\n--- Movimiento del elevador ---");

        //  Subir
        if (pisoDestino > pisoActual)
        {
            while (posicion < pisoDestino)
            {
                velocidad += aceleracion;
                posicion += velocidad * 0.1;

                Console.WriteLine(
                    $"Piso: {(int)posicion} | Velocidad: {velocidad:F2} | Aceleracion: {aceleracion:F2}"
                );
            }
        }

        //  Bajar
        else if (pisoDestino < pisoActual)
        {
            while (posicion > pisoDestino)
            {
                velocidad += aceleracion;
                posicion -= velocidad * 0.1;

                Console.WriteLine(
                    $"Piso: {(int)posicion} | Velocidad: {velocidad:F2} | Aceleracion: {aceleracion:F2}"
                );
            }
        }

        else
        {
            Console.WriteLine("El elevador ya está en ese piso.");
            return;
        }

        //  Llegada
        posicion = pisoDestino;

        Console.WriteLine("\n--- Llegada al piso destino ---");
        Console.WriteLine($"Piso final: {(int)posicion}");
        Console.WriteLine($"Velocidad final: {velocidad:F2}");
        Console.WriteLine($"Aceleracion: {aceleracion}");
    }
}