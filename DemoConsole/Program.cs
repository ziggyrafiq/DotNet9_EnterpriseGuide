Console.WriteLine("Hello, from Ziggy Rafiq!");

int[] numbers = { 1, 2, 3, 4, 5 };

if (numbers is [1, .., 5])
{
    Console.WriteLine("Array starts with 1 and ends with 5!");
}
else
{
    Console.WriteLine("Array does not match the pattern.");
}


var numbersLinq = Enumerable.Range(1, 10);
var squares = numbersLinq.Select(static x => x * x);

Console.WriteLine("Squares of numbers from 1 to 10:");

foreach (var square in squares)
    Console.WriteLine(square);



Span<int> span = stackalloc int[] { 1, 2, 3, 4, 5 };
span[0] = 42;

Console.WriteLine("Elements in the span:");
for (int i = 0; i < span.Length; i++)
    Console.WriteLine(span[i]);
