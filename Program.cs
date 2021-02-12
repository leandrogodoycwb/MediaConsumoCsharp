using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double consumo;

            Console.WriteLine("Qual distância você vai percorrer?");
            distancia = int.Parse(Console.ReadLine());

            consumo = distancia/12.00;

            Console.WriteLine(string.Format("{0:0.000} litros de gasolina", consumo));
        }
    }
}
