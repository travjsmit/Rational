using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Step 4: Create a new Rational object and test WriteRational
        Rational r = new Rational();
        r.WriteRational();

        // Set fields to some values and test WriteRational
        Rational r1 = new Rational(3, 4);
        r1.WriteRational();

        // Step 7: Test Negate method
        r1.Negate();
        r1.WriteRational();

        // Step 8: Test Invert method
        r1.Invert();
        r1.WriteRational();

        // Step 9: Test ToDouble method
        Console.WriteLine(r1.ToDouble());

        // Step 10: Test Reduce method
        Rational r2 = new Rational(8, 12);
        r2.WriteRational();

        // Step 11: Test Add method
        Rational r3 = Rational.Add(r1, r2);
        r3.WriteRational();
    }
}

