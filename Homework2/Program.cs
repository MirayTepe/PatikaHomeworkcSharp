using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // Soru-1 için methodu çağır
        Soru1();
        Soru2();
        Soru3();
    }

    public static void Soru1()
    {
        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        int count = 0;
        while (count < 20)
        {
            Console.Write($"Lütfen {count + 1}. pozitif sayıyı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    nonPrimeNumbers.Add(number);
                }
                count++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı giriniz.");
            }
        }

        primeNumbers.Sort();
        nonPrimeNumbers.Sort();

        Console.WriteLine("Asal Sayılar:");
        PrintArrayList(primeNumbers);

        Console.WriteLine("Asal Olmayan Sayılar:");
        PrintArrayList(nonPrimeNumbers);

        Console.WriteLine($"Asal Sayılar Toplamı: {CalculateSum(primeNumbers)}");
        Console.WriteLine($"Asal Olmayan Sayılar Toplamı: {CalculateSum(nonPrimeNumbers)}");

        Console.WriteLine($"Asal Sayılar Ortalaması: {CalculateAverage(primeNumbers)}");
        Console.WriteLine($"Asal Olmayan Sayılar Ortalaması: {CalculateAverage(nonPrimeNumbers)}");
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public static void PrintArrayList(ArrayList list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static int CalculateSum(ArrayList list)
    {
        int sum = 0;
        foreach (int item in list)
        {
            sum += item;
        }
        return sum;
    }

    public static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0)
            return 0;

        int sum = CalculateSum(list);
        return (double)sum / list.Count;
    }
    public static void Soru2()
    {
        int[] numbers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
                i--;
            }
        }

        Array.Sort(numbers);

        Console.WriteLine("En Küçük 3 Sayı:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("En Büyük 3 Sayı:");
        for (int i = numbers.Length - 1; i >= numbers.Length - 3; i--)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int smallestAverage = (numbers[0] + numbers[1] + numbers[2]) / 3;
        int largestAverage = (numbers[numbers.Length - 1] + numbers[numbers.Length - 2] + numbers[numbers.Length - 3]) / 3;

        Console.WriteLine($"En Küçük 3 Sayı Ortalaması: {smallestAverage}");
        Console.WriteLine($"En Büyük 3 Sayı Ortalaması: {largestAverage}");
        Console.WriteLine($"Ortalama Toplamı: {smallestAverage + largestAverage}");
    }
    public static void Soru3()
    {
        Console.Write("Bir cümle giriniz: ");
        string input = Console.ReadLine();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] inputChars = input.ToCharArray();
        char[] foundVowels = Array.FindAll(inputChars, c => Array.IndexOf(vowels, c) != -1);

        Array.Sort(foundVowels);

        Console.WriteLine("Sesli Harfler:");
        foreach (char vowel in foundVowels)
        {
            Console.Write(vowel + " ");
        }
        Console.WriteLine();
    }
}

