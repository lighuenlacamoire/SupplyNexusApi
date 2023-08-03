using Arithmetic.Domain.DTOs;
using Arithmetic.Domain.Support.Helpers;
using System;
using System.Drawing;
using System.Globalization;

namespace Arithmetic.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menú");
            Console.WriteLine("");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("");
            Console.Write("Indica tu selección: ");
            int.TryParse(Console.ReadLine(), out int selectionId);

            if(selectionId < 4 && selectionId > 0)
            {
                switch (selectionId)
                {
                    case 1:
                        {
                            Console.Write("Indica el radio: ");
                            double radio = Console.ReadLine().FromString();
                            Circulo shape = new Circulo();
                            var area = shape.Area(new double[] { radio }).ToInvariant();
                            var perim = shape.Perimetro(new double[] { radio }).ToInvariant();

                            Console.WriteLine("");
                            Console.WriteLine($"El área del circulo es: {area}");
                            Console.WriteLine($"El perímetro del circulo es: {perim}");

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Indica la longitud: ");
                            double longitude = Console.ReadLine().FromString();
                            Console.Write("Indica el ancho: ");
                            double wide = Console.ReadLine().FromString();

                            var parameters = new double[] { longitude, wide };

                            Rectangulo shape = new Rectangulo();
                            var area = shape.Area(parameters).ToInvariant();
                            var perim = shape.Perimetro(parameters).ToInvariant();

                            Console.WriteLine("");
                            Console.WriteLine($"El área del rectángulo es: {area}");
                            Console.WriteLine($"El perímetro del rectángulo es: {perim}");

                            break;
                        }
                    case 3:
                        {
                            Console.Write("Indica el lado: ");
                            double side = Console.ReadLine().FromString();
                            Cuadrado shape = new Cuadrado();
                            var parameters = new double[] { side };
                            var area = shape.Area(parameters).ToInvariant();
                            var perim = shape.Perimetro(parameters).ToInvariant();

                            Console.WriteLine("");
                            Console.WriteLine($"El área del cuadrado es: {area}");
                            Console.WriteLine($"El perímetro del cuadrado es: {perim}");

                            break;
                        }
                    default:
                        break;
                }
            } else
            {
                Console.WriteLine("El valor ingresado es invalido por favor intente nuevamente.");
            }
        }
    }
}