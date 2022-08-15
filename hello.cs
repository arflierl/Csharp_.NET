/*
This is based on the C# interactive tutorial 
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/
*/


Console.WriteLine("Hello World!");

string aFriend = "Hank";  // type and variable declaration

Console.WriteLine(aFriend);  // pass the variable as argument

aFriend = "Peggy";      // variable can be reassigned a different value of the same type

Console.WriteLine("Hello " + aFriend);  // simple string concatenation

/* 
String interpolation: 
You can place a variable between { and } characters to tell C# to replace 
that text with the value of the variable 
If you add a $ before the opening quote of the string, you can then include variables, 
like aFriend, inside the string between curly braces
*/

Console.WriteLine($"Hello {aFriend}!");

// We can do this with more than one string variable

string musicianONE = "Doc Watson";
string musicianTWO = "Mississippi John Hurt";

Console.WriteLine($"My guitar playing has been most influenced by {musicianONE} and {musicianTWO}.");

// the .Length method simply returns the length of the string

Console.WriteLine($"{musicianONE} has {musicianONE.Length} letters in their name");

// the .Substring method takes an integer parameter as the starting index of the substring to be returned.

Console.WriteLine($"another method is .Substring(index) where index is the starting index of the substring to be returned {musicianONE.Substring(4)}");


