using Library;
using System;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void RectangleDemo()
        {
            Rectangle rectangle;
            try
            {
                rectangle = Rectangle.Create(5, 10);
                Console.WriteLine(rectangle);
                Rectangle test = rectangle * 1.5;
                Console.WriteLine(test.Perimetr);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void AnimalDemo()
        {
            Animal animal = new Cat(0);
            Console.WriteLine(animal.Weight);
            Console.WriteLine(animal.SaySound());
            Console.WriteLine(animal.GetColor());
        }

        static void AbstractForeachDemo()
        {
            Animal[] animals = new Animal[5];
            for (int i = 0; i < animals.Length; i++)
            {
                if (i % 2 == 0)
                {
                    animals[i] = new Cat(i);
                }
                else
                {
                    animals[i] = new Dog(i);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType());
                Console.WriteLine(animal.Weight);
                Console.WriteLine(animal.SaySound());
                Console.WriteLine(animal.GetColor());
                Console.WriteLine();
            }
        }

        static void InterfacesDemo()
        {
            IShape[] shapes = new IShape[5];

            for (int i = 0; i < shapes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    shapes[i] = Rectangle.Create(3, 5);
                }
                else
                {
                    shapes[i] = Triangle.Create(3, 4, 5);
                }
            }

            double sumSquares = 0;
            foreach (var shape in shapes)
            {
                sumSquares += shape.GetSquare();
            }

            Console.WriteLine(sumSquares);
        }

        static void WhatToDo()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                arrayList.Add(i);
            }

            arrayList.Print();
        }

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(i);
            }

            arrayList.Print();

            arrayList.DeleteByValue(0);
            arrayList.DeleteByValue(3);
            arrayList.DeleteByValue(4);

            Console.WriteLine();
            arrayList.Print();
        }
    }
}
