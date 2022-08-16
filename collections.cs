/*
This is based on the interactive tutorial:
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection
*/

/* 
Here, we initialize a list of type string
*/

var musicians = new List<string> {"Doc Watson", "Jerry Garcia", "Hank Williams Sr.", "Blaze Foley", "Townes Van Zandt", "John Prine", "Mississippi John Hurt"};

foreach (var musician in musicians)
{
    Console.WriteLine($"one of my favorite musicians is { musician }");
}

/*
the Add method is used to append new items of the correct type to the list
*/

musicians.Add("Eric Clapton");
musicians.Add("Jimi Hendrix");
musicians.Add("Ian Noe");

/*
The Contains method searches for an item in a list
note when making a list of strings, it might be
wise to use ToUpper or ToLower when adding strings to the list
and then doing the same for searching with the Contains method
to avoid confusion about capitalization, or for instance
having multiple usernames which are the same
*/

if (musicians.Contains("Tupac Shakur"))
{
    Console.WriteLine("Tupac Shakur is in the list");
}
else
{
    musicians.Add("Tupac Shakur");
}

/*
The RemoveAt method removed an item from a specified index
and the Count method returns the length of the list
*/

musicians.Add("Mumble Rapper A");
Console.WriteLine($"The last item in the list is { musicians[musicians.Count - 1] }");
musicians.RemoveAt(musicians.Count - 1);
Console.WriteLine($"The last item in the list is { musicians[musicians.Count - 1] }");

/*
The Index of method returns the index of an element
and if the element is not found, it returns -1
*/

Console.WriteLine($"The index of Blaze Foley is { musicians.IndexOf("Blaze Foley") } and the index of and item not in the list is { musicians.IndexOf("Not listed") }");

/*
we can sort a list with the Sort method
Also, note a simple one line loop can be done on one line
*/

musicians.Sort();

foreach (var elem in musicians) Console.WriteLine(elem);

/*
Fibonacci numbers, commonly denoted Fₙ, form a sequence, the Fibonacci sequence, 
in which each number is the sum of the two preceding ones. 
The sequence commonly starts from 0 and 1, 
although some authors omit the initial terms and start the sequence from 1 and 1 or from 1 and 2. 
However, I think it should start from 0 and 1
*/

var fib_seq = new List<int> { 0, 1 };

/*
we use dynamic programming instead of straight recursion,
because even though there is an obvious mathematical
recurrence relation, we are wasting a lot of time with repeated
calls for the same inputs.  Dynamic Programming is mainly an optimization over plain recursion. 
Wherever we see a recursive solution that has repeated calls for same inputs, we can optimize it using Dynamic Programming. 
The idea is to simply store the results of subproblems, so that we do not have to re-compute them when needed later. 
This simple optimization reduces time complexities from exponential to polynomial.
*/

/*
This is a simple program to calculate the fibonacci sequence of length n
*/

List<int> calc_fib_seq(int n, List<int> seq)
 {
    for (int counter = 0; counter < n; counter++) 
    {
        seq.Add( ( seq[seq.Count - 1] )+ ( seq[seq.Count - 2] ));
    }
    return seq;
 }

foreach ( var fib_num in calc_fib_seq(25, fib_seq)) Console.Write($"{ fib_num }, ");