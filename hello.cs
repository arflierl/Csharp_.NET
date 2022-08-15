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

// the .ToUpper() and .ToLower() methods return a string in all upper or lower case respectively

Console.WriteLine($"we can also use the ToUpper method to return a string in all caps {musicianONE.ToUpper()}");

/*
Suppose our strings have leading or trailing spaces that we don't want to display. The Trim method and related methods 
TrimStart and TrimEnd do that work.  We can use those methods to remove leading and trailing spaces.
*/

string greeting = "            Go Bills!      ";
Console.WriteLine($"this is our string: {greeting} note the leading and ending spaces");
Console.WriteLine($"lets use TrimStart to remove leading spaces {greeting.TrimStart()} and observe ending spaces");
Console.WriteLine($"lets use TrimEnd to remove the spaces on the end of the string {greeting.TrimEnd()} and observe the end spaces removed");
Console.WriteLine($"lets use the Trim method to remove leading and ending spaces {greeting.Trim()} and observe all spaces removed");

/*
We can also replace substrings using the replace method as shown below
*/

greeting = greeting.Replace("Bills", "Sabres");
Console.WriteLine($"here we use the replace method to change our greeting to {greeting.Trim()}");

