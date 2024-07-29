using System;

public class Rational
{
    private int numerator;
    private int denominator;

    // Default constructor
    public Rational()
    {
        numerator = 0;
        denominator = 1;
    }

    // Parametric constructor
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

    // WriteRational method
    public void WriteRational()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    // Negate method
    public void Negate()
    {
        numerator = -numerator;
    }

    // Invert method
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

    // ToDouble method
    public double ToDouble()
    {
        return (double)numerator / denominator;
    }

    // Reduce method
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

    // Add method
    public Rational Add(Rational other)
    {
        int newNumerator = this.numerator * other.denominator + other.numerator * this.denominator;
        int newDenominator = this.denominator * other.denominator;
        return new Rational(newNumerator, newDenominator);
    }
}
