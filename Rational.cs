using System;

public class Rational
{
    private int numerator;
    private int denominator;

    // Step 2: Default constructor
    public Rational()
    {
        numerator = 0;
        denominator = 1;
    }

    // Step 6: Parametric constructor
    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
        Reduce();
    }

    // Step 3: WriteRational method
    public void WriteRational()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    // Step 7: Negate method
    public void Negate()
    {
        numerator = -numerator;
    }

    // Step 8: Invert method
    public void Invert()
    {
        if (numerator == 0)
        {
            throw new InvalidOperationException("Cannot invert a rational number with a numerator of zero.");
        }

        int temp = numerator;
        numerator = denominator;
        denominator = temp;
    }

    // Step 9: ToDouble method
    public double ToDouble()
    {
        return (double)numerator / denominator;
    }

    // Step 10: Reduce method
    public void Reduce()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    private static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }

    // Step 11: Add method
    public static Rational Add(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }
}
