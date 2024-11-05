
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero(5);
        FindMinimum(990, 5935, 2680);
        FindMaximum(145, 15, 50);
        IsDivisibleBy5(123);
        CheckEvenOrOdd(2);
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(0);





        // FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number)
    {

        if (number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Your number is negative");
        }
        else if (number == 0)
        {
            Console.WriteLine("Your number is zero");
        }
    }

    public static void FindMinimum(int num1, int num2, int num3)
    {
        //Calculates
        if (num1 <= num2 && num1 <= num3)
        {

            Console.WriteLine(num1 + " is the smallest");
        }

        if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine(num2 + " is the smallest");
        }

        if (num3 <= num1 && num2 <= num1)
        {
            Console.WriteLine(num3 + " is the smallest");
        }
    }

    public static void FindMaximum(int num1, int num2, int num3)
    {
        //Calculates
        if (num1 >= num2 && num1 >= num3)
        {

            Console.WriteLine(num1 + " is the biggest");
        }

        if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine(num2 + " is the biggest");
        }

        if (num3 >= num1 && num3 >= num1)
        {
            Console.WriteLine(num3 + " is the biggest");
        }
    }

    public static void IsDivisibleBy5(int number)
    {
        bool isDivisibleBy5 = number % 5 == 0;
        // boolean expressions

        if (isDivisibleBy5)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    public static void CheckEvenOrOdd(int number)
    {
        bool CheckEvenOrOdd = number % 2 == 0;
        // expressions

        if (CheckEvenOrOdd)
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Odd number, it's even");
        }
    }

    public static void CheckVowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
                Console.WriteLine("a is a vowel");
                break;

            case 'A':
                Console.WriteLine("A  is a consonant");
                break;


            case 'e':
                Console.WriteLine("e is a vowel");
                break;

            case 'E':
                Console.WriteLine("E  is a consonant");
                break;


            case 'i':
                Console.WriteLine("i is a vowel");
                break;

            case 'I':
                Console.WriteLine("I  is a consonant");
                break;


            case 'o':
                Console.WriteLine("o is a vowel");
                break;

            case 'O':
                Console.WriteLine("O  is a consonant");
                break;


            case 'u':
                Console.WriteLine("u is a vowel");
                break;

            case 'U':
                Console.WriteLine("U  is a consonant");
                break;
            
            case 'b':
                Console.WriteLine("b is a consonat");
                break;

            case 'B':
                Console.WriteLine("B  is a consonant");
                break;

            case 'c':
                Console.WriteLine("c is a consonat");
                break;

            case 'C':
                Console.WriteLine("C is a consonant");
                break;

            case 'd':
                Console.WriteLine("d is a consonat");
                break;

            case 'D':
                Console.WriteLine("D  is a consonant");
                break;

            case 'f':
                Console.WriteLine("f is a consonat");
                break;

            case 'F':
                Console.WriteLine("F is a consonant");
                break;  

            case 'g':
                Console.WriteLine("g is a consonat");
                break;

            case 'G':
                Console.WriteLine("G is a consonant");
                break;

            case 'h':
                Console.WriteLine("h is a consonat");
                break;

            case 'H':
                Console.WriteLine("H is a consonant");
                break;

            case 'j':
                Console.WriteLine("j is a consonat");
                break;

            case 'J':
                Console.WriteLine("J is a consonant");
                break;

            case 'k':
                Console.WriteLine("k is a consonat");
                break;

            case 'K':
                Console.WriteLine("K is a consonant");
                break;

            case 'l':
                Console.WriteLine("l is a consonat");
                break;

            case 'L':
                Console.WriteLine("L is a consonant");
                break;

            case 'm':
                Console.WriteLine("m is a consonat");
                break;

            case 'M':
                Console.WriteLine("M is a consonant");
                break;

            case 'n':
                Console.WriteLine("n is a consonat");
                break;

            case 'N':
                Console.WriteLine("N is a consonant");
                break;

            case 'p':
                Console.WriteLine("p is a consonat");
                break;

            case 'P':
                Console.WriteLine("P is a consonant");
                break;

            case 'q':
                Console.WriteLine("q is a consonat");
                break;

            case 'Q':
                Console.WriteLine("Q is a consonant");
                break;   

            case 'r':
                Console.WriteLine("r is a consonat");
                break;

            case 'R':
                Console.WriteLine("R is a consonant");
                break;

            case 's':
                Console.WriteLine("s is a consonat");
                break;

            case 'S':
                Console.WriteLine("S is a consonant");
                break;

            case 't':
                Console.WriteLine("t is a consonat");
                break;

            case 'T':
                Console.WriteLine("T is a consonant");
                break;

            case 'v':
                Console.WriteLine("v is a consonat");
                break;

            case 'V':
                Console.WriteLine("V is a consonant");
                break;

            case 'w':
                Console.WriteLine("w is a consonat");
                break;

            case 'W':
                Console.WriteLine("W is a consonant");
                break;

            case 'x':
                Console.WriteLine("x is a consonat");
                break;

            case 'X':
                Console.WriteLine("X is a consonant");
                break;

            case 'y':
                Console.WriteLine("y is a consonat");
                break;

            case 'Y':
                Console.WriteLine("Y  is a consonant");
                break;

            case 'z':
                Console.WriteLine("z is a consonat");
                break;

            case 'Z':
                Console.WriteLine("Z is a consonant");
                break;                                                                                                    
        }
    }

    public static void DisplayDayOfWeek(int dayCode)
    {
        switch(dayCode)
        {
            case 0:
            Console.WriteLine("Sunday");
            break;

            case 1:
            Console.WriteLine("Monday");
            break;

            case 2:
            Console.WriteLine("tuesday");
            break;

            case 3:
            Console.WriteLine("Wednesday");
            break;

            case 4:
            Console.WriteLine("Thursday");
            break;

            case 5:
            Console.WriteLine("Friday");
            break;

            case 6:
            Console.WriteLine("Saturday");
            break;
        }

    }
}