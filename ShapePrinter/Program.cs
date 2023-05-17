using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool exit = false;

            while (!exit)
            {
                PrintMenu();

                Console.Write("Chọn một lựa chọn: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintRectangle();
                        break;
                    case "2":
                        Console.Write("Chọn góc của tam giác vuông (1: top-left, 2: top-right, 3: botton-left, 4: botton-right): ");
                        int cornerChoice = int.Parse(Console.ReadLine());
                        PrintSquareTriangle(cornerChoice);
                        break;
                    case "3":
                        PrintIsoscelesTriangle();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;

                }
                Console.WriteLine();
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. In hình chữ nhật");
            Console.WriteLine("2. In tam giác vuông");
            Console.WriteLine("3. In tam giác cân");
            Console.WriteLine("4. Thoát");
        }

        static void PrintRectangle()
        {
            Console.Write("Nhập chiều dài: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintSquareTriangle(int cornerChoice)
        {
            Console.Write("Nhập chiều cao: ");
            int height = int.Parse(Console.ReadLine());

            switch (cornerChoice)
            {
                case 1: // top-left
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2: // top-right
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j <= height - i; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3: // bottom-left
                    for (int i = height; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 4: // bottom-right
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j <= height - i; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
        static void PrintIsoscelesTriangle()
        {
            Console.Write("Nhập chiều cao: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = height; i >= 1; i--)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}