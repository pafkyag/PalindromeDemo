
using Palindrome;

string fileToCheck = @"palindrome.txt";
IEnumerable<string> lines = File.ReadLines(fileToCheck);
foreach (string line in lines)
{
    Console.WriteLine($"Is '{line}' a palindrome? {Util.IsPalindrome(line)}");
}

Console.ReadKey();
