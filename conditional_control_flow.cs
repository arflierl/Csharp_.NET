/*
This is based on the interactive tutorial
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops
*/

/*
note for an if statement it is best practice to always include the brackets
and we can use '&&' and '||' for AND and OR statements as is typical
*/

int a, b, c, d;
a = 5;
b = 9;
c = 67;
d = 9873;

if ((b * c) < d)
{
    Console.WriteLine($"{b}*{c} is less than {d}");
}
else
{
    Console.WriteLine($"{b}*{c} is greater than {d}");
}

if ((b > a) && (c < d))
{
    Console.WriteLine("expect this to print");
}
else 
{
    Console.WriteLine("don't expect this to print)");
}

if (b < a) 
{
    Console.WriteLine("don't expect this to print");
}
else if ((b < a) || (b < c))
{
    Console.WriteLine("expect this to print");
}
else
{
    Console.WriteLine("don't expect this to print");
}

/*
below is a while loop which iterates through a string
*/

string iterate_me = "ten_chars!";
int counter = 0;

while (counter < iterate_me.Length)
{
    Console.WriteLine($"the character at index { counter } is: { iterate_me[counter].ToString() }");
    counter++;
}

/*
a while loop checks the condition first, and then executes the code
whereas a do....while loop performs the code first and then checks the condition
in this instance, they work the same
*/

counter = 0;

do
{
    Console.WriteLine($"the character at index { counter } is: { iterate_me[counter].ToString() }");
    counter++;
}while (counter < iterate_me.Length);

/*
for loops behave like a while loop but have three parts when declaring them
for ( initializer = value; condition; increment/decrement intializer)
{
    code body of for loop
}
*/

for (int iterator = 0; iterator > -5; iterator--)
{
    Console.WriteLine($"The iterator in the for loop is currently { iterator }");
}

/*
if we want to iterate through a matrix with i rows and j columns
we can do something like this:
*/

int i , j;
i = 4;
j = 6;

for ( int _row = 0; _row < i; _row++)
{
    for ( int _col = 0; _col < j; _col++)
    {
        Console.WriteLine($"We are on row { _row } column { _col }");
    }
}

/*
challenge: see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3
*/

int sum = 0;

for (int num = 1; num <= 20; num++)
{
    if ((num % 3) == 0)
    {
        sum += num;
    }
}

Console.WriteLine($"The sum of #'s 1-20 which are divisible by 3 = { sum }");