using Figures;
using System.Formats.Asn1;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        int answer;
        int answer2;
        List<Figure> figures = new List<Figure>();

        do
        {
            Console.WriteLine("===================== MENU =====================");
            Console.WriteLine("1. Show all figures\n2. Create a figure\n");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                foreach (var item in figures)
                {
                    item.CalcArea();
                    item.CalcPerimetr();
                    item.CalcCenter();
                    Console.WriteLine(item.ToString());
                }
            }
            else if (answer == 2)
            {
                Console.WriteLine("Choose figure:\n1.Square");
                answer2 = Convert.ToInt32(Console.ReadLine());
                switch (answer2)
                {
                    case 1:
                        Square square = new Square(new List<Point>());
                        Console.WriteLine("Please enter the lenght of square's side");
                        square.Side = Convert.ToDouble(Console.ReadLine());
                        figures.Add(square);
                        break;
                    default:
                        break;
                }
            }


        } while (answer != 0);
    }
}