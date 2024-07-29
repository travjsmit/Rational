#3 - Exercise 9.3. (page 111-112) A rational number is a number that can be represented as the ratio of two integers. For example, 2/3 is a rational number, 355/133 is a good approximation of PI and you can think of 7 as a rational number with an implicit 1 in the denominator (7/1). For this assignment, you are going to write a class definition for rational numbers. 
1. Create a new program called Rational.cs that defines a class named Rational. A Rational object should have two integer fields to store the numerator and denominator.
2. Write a default constructor, one that takes no arguments, and that sets the numerator to 0 and denominator to 1.
3. Write a method called WriteRational that takes a Rational object as an argument and outputs it in some reasonable format.
4. Write a Main method that creates a new object with type Rational, sets its fields to some values, and writes the object.
5. At this stage, you have a minimal testable program. Test it and, if necessary, debug it.
6. Write a parametric constructor for your class that takes two arguments and that uses them to initialize the fields.
7. Write a method called Negate that reverses the sign of a rational number. This method should be a modifier, so it should return void. Add lines to Main to test the new method.
8. Write a method called Invert that inverts the number by swapping the numerator and denominator. Add lines to Main to test the new method.
9. Write a method called ToDouble that converts the rational number to a double(floating-point number) and returns the result. This method is a pure function; it does not modify the object. As always, test the new method.
10. Write a modifier named Reduce that reduces a rational number to its lowest terms by finding the greatest common divisor (GCD) of the numerator and denominator and dividing through. This method should be a pure function; it should not modify the fields of the object on which it is invoked. See Exercise 5.9 for the algorithm to find the GCD.
    static long GCD(long n1, long n2)    {
        if (n2 == 0)
        {
            return n1;
        }
        else
        {
            return GCD(n2, n1 % n2);
        }
    }
11. Write a method called Add that takes two Rational numbers as arguments and returns a new Rational object. The return object should contain the sum of the arguments. There are several ways to add fractions. You can use any one you want, but you should make sure that the result of the operation is reduced so that the numerator and denominator have no common divisor (other than 1).

#4 - Exercise 13.4. (page 158) This exercise is a continuation of Exercise 9.3. The purpose is to practice the syntax of instance methods and get familiar with the relevant error messages.
1. Transform the methods in the Rational class from static methods to instance methods, and make the necessary changes in Main.
2. Make a few mistakes. Try invoking static methods as if they were instance methods and vice-versa. Try to get a sense for what is legal and what is not, and for the error messages that you get when you mess up.
3. Think about the pros and cons of static and instance methods. Which is more concise (usually)? Which is a more natural way to express computation (or, maybe more fairly, what kind of computations can be expressed most naturally using each style)?