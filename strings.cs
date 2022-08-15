/*
This is based on the C# interactive tutorial 
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/
*/

/*
Console is a type that represents the console window. 
WriteLine is a method of the Console type that prints a line of text to that text console
*/

Console.WriteLine("Hello World!");

/*
type and variable declaration
*/

string aFriend = "Hank";  

/*
pass the variable as an argument
*/

Console.WriteLine(aFriend); 

/*
variable can be reassigned a different value of the same type
*/

aFriend = "Peggy";      

/*
simple string concatenation
*/

Console.WriteLine("Hello " + aFriend); 

/* 
String interpolation: 
You can place a variable between { and } characters to tell C# to replace 
that text with the value of the variable
If you add a $ before the opening quote of the string, you can then include variables, 
like aFriend, inside the string between curly braces
*/

Console.WriteLine($"Hello {aFriend}!");

/*
We can do this with more than one string variable
*/

string musicianONE = "Doc Watson";
string musicianTWO = "Mississippi John Hurt";

Console.WriteLine($"My guitar playing has been most influenced by {musicianONE} and {musicianTWO}.");

/*
the .Length method simply returns the length of the string
*/

Console.WriteLine($"{musicianONE} has {musicianONE.Length} letters in their name");

/*
the .Substring method takes an integer parameter as the starting index of the substring to be returned
*/

Console.WriteLine($"another method is .Substring(index) where index is the starting index of the substring to be returned {musicianONE.Substring(4)}");

/*
the .ToUpper() and .ToLower() methods return a string in all upper or lower case respectively
*/

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

/*
The other part of search and replace is to find text within a given string.
the Contains method does just that, and returns a Boolean value
*/

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

/* 
Note we need to be mindful of capitalization when using the Contains method
We can use the ToLower or ToUpper methods if we want our contains method
to work regardless.
*/

Console.WriteLine(songLyrics.Contains("you"));
Console.WriteLine(songLyrics.ToLower().Contains("you"));

/*
The StartsWith and EndsWith methods return boolean values.
These find a substring at the beginning or the end of the string. 
Try to modify the previous sample to use StartsWith and EndsWith instead of Contains. 
Search for "You" or "goodbye" at the beginning of a string. Search for "hello" or "goodbye" at the end of a string.
*/

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));

/*
Here is an example of putting it all together
*/

Console.WriteLine($"it is {songLyrics.ToUpper().EndsWith("HELLO")} the lyrics end with 'hello', but {songLyrics.ToLower().Contains("hi")} that they contain 'hi'");




