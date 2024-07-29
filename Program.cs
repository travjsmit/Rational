using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new Rational object and test WriteRational
        Rational r = new Rational();
        r.WriteRational();

        // Set fields to some values and test WriteRational
        Rational r1 = new Rational(3, 4);
        r1.WriteRational();

        // Test Negate method
        r1.Negate();
        r1.WriteRational();

        // Test Invert method
        r1.Invert();
        r1.WriteRational();

        // Test ToDouble method
        Console.WriteLine(r1.ToDouble());

        // Test Reduce method
        Rational r2 = new Rational(8, 12);
        r2.WriteRational();

        // Test Add method
        Rational r3 = r1.Add(r2);
        r3.WriteRational();
    }
}
