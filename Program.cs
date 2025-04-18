using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();  

            while (true)  
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1 - Треугольник");
                Console.WriteLine("2 - Круг");
                Console.WriteLine("3 - Выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("Выход из программы...");
                    return;  
                }

                IShape shape = null;

                try
                {
                    if (choice == "1")
                    {
                        Console.Write("Введите сторону a: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите сторону b: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите сторону c: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        shape = new Triangle(a, b, c);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Введите радиус: ");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        shape = new Disk(radius);
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                        continue; 
                    }

                    PrintShapeInfo(shape);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();  
            }
        }

        static void PrintShapeInfo(IShape shape)
        {
            Console.WriteLine($"\nФигура: {shape.Name}");
            Console.WriteLine(shape.Parameters);
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
        }
    }
}
    
