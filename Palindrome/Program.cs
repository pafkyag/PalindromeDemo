
using Palindrome;

string fileToCheck = @"palindrome.txt";
IEnumerable<string> lines = File.ReadLines(fileToCheck);
char[] splitByChars = { ',' , ' ', '\b'};
foreach (string line in lines)
{
    var words = line.Split(splitByChars);
    foreach(string word in words)
        Console.WriteLine($"Is '{word}' a palindrome? {Util.IsPalindrome(word)}");
}

Console.ReadKey();
