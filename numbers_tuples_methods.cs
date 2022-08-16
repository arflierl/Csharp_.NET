/*
This is based on the following interactive tutorial:
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp
*/

/*
note as with strings and all variables
C# requires type declaration when first declaring a variable
but assignment is not required.
*/

int a, b, c;
a = 4;
b = 5;

/*
Below are some basic integer operations
note that the result of a / b is 0
as opposed to 0.8 if '/' were float division
*/

c = a + b;
Console.WriteLine(c);
c = a - b;
Console.WriteLine(c);
c = a * b;
Console.WriteLine(c);
c = a / b;Console.WriteLine(c);
c = ( a * b ) + a;
Console.WriteLine(c);

/*
note here that the value for c is updated after 
the mathematical operation is performed
*/

c = ( a + b ) * c;
Console.WriteLine(c);

c = b / a;
Console.WriteLine($"quotient: { c }");
c = b % a;
Console.WriteLine($"remainder: { c }");

/*
standard range of integer values
*/

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

/*
obviously if we add to max or subtract from min
overflow will occur
*/

int flowed_over = max + 3;
Console.WriteLine($"An example of overflow: {flowed_over}");

/*
doubles provide a much larger range of values
*/

double max_dub = double.MaxValue;
double min_dub = double.MinValue;
Console.WriteLine($"The range of double is {min_dub} to {max_dub}");

double d = 78;
double e = 55;
double f = -349876;

/*
belowe shows the declaration of a tuple
which contains two doubles
and they can be accessed with the
Item# method as shown below
*/

(double, double) double_tuple;
double_tuple = (d / e, d % e);
double g = double_tuple.Item1;
double h = double_tuple.Item2;
Console.WriteLine(double_tuple);

/*
C# also has a decimal type
which is more precise for decimal operation
than a double, as shown below.  You must 
include the 'M' suffix to instruct the 
compiler to use this number as a decimal
when performing calculations, else it will
treat it as a double
*/

decimal min_decimal = decimal.MinValue;
decimal max_decimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min_decimal} to {max_decimal}");

double i = 1.0;
double j = 3.0;
Console.WriteLine($"this is 1 / 3 using double: {i / j}");

decimal k = 1.0M;
decimal l = 3.0M;
Console.WriteLine($"this is 1 / 3 using decimal: {k / l}");

/*
challenge: write code which calculates are of a circle
use Math.Pi which is a double
with a radius of 2.50 the answer will be between 19 and 20
*/

double circle_area(double radius) 
{
    return Math.PI * Math.Pow(radius, 2);
}

Console.WriteLine(circle_area(2.50));