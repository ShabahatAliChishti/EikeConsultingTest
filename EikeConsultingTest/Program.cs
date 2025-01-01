
using EikeConsultingTest;

Console.WriteLine("---------------");
Console.WriteLine("Q1");
Console.WriteLine("---------------");

var stringManipulator = new StringManipulation();
string input = "Hello World!";
string reversed = stringManipulator.ReverseString(input);
Console.WriteLine(reversed);


Console.WriteLine("---------------");
Console.WriteLine("Q2");
Console.WriteLine("---------------");

var validator = new ParenthesesValidator();

Console.WriteLine(validator.IsValid("()"));
Console.WriteLine(validator.IsValid("()[]{}"));
Console.WriteLine(validator.IsValid("(]"));
Console.WriteLine(validator.IsValid("([)]"));
Console.WriteLine(validator.IsValid("{[]}"));



Console.WriteLine("---------------");
Console.WriteLine("Q3");
Console.WriteLine("---------------");

var arrayManipulator = new ArrayManipulation();
List<int> input3 = new List<int> { 1, 2, 3, 2, 4, 1, 5 };
List<int> result2 = arrayManipulator.RemoveDuplicatesWithHashSet(input3);
Console.WriteLine(string.Join(", ", result2)); 



