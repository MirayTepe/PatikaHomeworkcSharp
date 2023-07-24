using System;

public class ShapeCalculator
{
    public static double CalculateArea(string shape, params double[] sides)
    {
        if (string.IsNullOrEmpty(shape))
            throw new ArgumentException("Shape should not be empty.", nameof(shape));

        double area = 0;

        switch (shape.ToLower())
        {
            case "daire":
                if (sides.Length == 1)
                {
                    double radius = sides[0];
                    area = Math.PI * radius * radius;
                }
                else
                {
                    throw new ArgumentException("Daire için sadece yarıçap bilgisi gereklidir.");
                }
                break;

            case "üçgen":
                if (sides.Length == 3)
                {
                    double a = sides[0];
                    double b = sides[1];
                    double c = sides[2];

                    double s = (a + b + c) / 2;
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                }
                else
                {
                    throw new ArgumentException("Üçgen için üç kenar bilgisi gereklidir.");
                }
                break;

            case "kare":
                if (sides.Length == 1)
                {
                    double side = sides[0];
                    area = side * side;
                }
                else
                {
                    throw new ArgumentException("Kare için sadece kenar bilgisi gereklidir.");
                }
                break;

            case "dikdörtgen":
                if (sides.Length == 2)
                {
                    double width = sides[0];
                    double height = sides[1];
                    area = width * height;
                }
                else
                {
                    throw new ArgumentException("Dikdörtgen için genişlik ve yükseklik bilgisi gereklidir.");
                }
                break;

            default:
                throw new ArgumentException("Geçersiz şekil bilgisi.");
        }

        return area;
    }

    public static double CalculatePerimeter(string shape, params double[] sides)
    {
        if (string.IsNullOrEmpty(shape))
            throw new ArgumentException("Shape should not be empty.", nameof(shape));

        double perimeter = 0;

        switch (shape.ToLower())
        {
            case "daire":
                if (sides.Length == 1)
                {
                    double radius = sides[0];
                    perimeter = 2 * Math.PI * radius;
                }
                else
                {
                    throw new ArgumentException("Daire için sadece yarıçap bilgisi gereklidir.");
                }
                break;

            case "üçgen":
                if (sides.Length == 3)
                {
                    double a = sides[0];
                    double b = sides[1];
                    double c = sides[2];

                    perimeter = a + b + c;
                }
                else
                {
                    throw new ArgumentException("Üçgen için üç kenar bilgisi gereklidir.");
                }
                break;

            case "kare":
                if (sides.Length == 1)
                {
                    double side = sides[0];
                    perimeter = 4 * side;
                }
                else
                {
                    throw new ArgumentException("Kare için sadece kenar bilgisi gereklidir.");
                }
                break;

            case "dikdörtgen":
                if (sides.Length == 2)
                {
                    double width = sides[0];
                    double height = sides[1];
                    perimeter = 2 * (width + height);
                }
                else
                {
                    throw new ArgumentException("Dikdörtgen için genişlik ve yükseklik bilgisi gereklidir.");
                }
                break;

            default:
                throw new ArgumentException("Geçersiz şekil bilgisi.");
        }

        return perimeter;
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Geometrik şekil girin (daire, üçgen, kare, dikdörtgen):");
            string shape = Console.ReadLine();

            Console.WriteLine("Kenar bilgilerini virgülle ayırarak girin:");
            string input = Console.ReadLine();
            string[] sidesStr = input.Split(',');

            double[] sides = new double[sidesStr.Length];
            for (int i = 0; i < sidesStr.Length; i++)
            {
                if (!double.TryParse(sidesStr[i], out sides[i]))
                {
                    throw new ArgumentException("Geçersiz kenar bilgisi.");
                }
            }

            Console.WriteLine("Hesaplamak istediğiniz boyutu girin (alan, çevre):");
            string size = Console.ReadLine().ToLower();

            double result = 0;
            if (size == "alan")
            {
                result = ShapeCalculator.CalculateArea(shape, sides);
                Console.WriteLine($"Alan: {result}");
            }
            else if (size == "çevre")
            {
                result = ShapeCalculator.CalculatePerimeter(shape, sides);
                Console.WriteLine($"Çevre: {result}");
            }
            else
            {
                throw new ArgumentException("Geçersiz boyut bilgisi.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

