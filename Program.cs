// See https://aka.ms/new-console-template for more information

using AssignmentC;

Console.WriteLine("Simple Properties Demo");
SimpleProperties people = new SimpleProperties("Merry", true, 25);
Console.WriteLine("Person Details : " + "Name = " + people.Name + ", Gender = " + (people.Gender ? "Male" : "Female" )+ ", Age = " + people.Age);
Console.WriteLine("Person Details (after incrementing age) : Name =" + people.Name + ", Gender = " + (people.Gender ? "Male" : "Female" ) + ", Age = " + (people.Age+10));
Console.WriteLine("----------------------");
CountIndex countIndex = new CountIndex();
Console.WriteLine("Search a Word");
Console.WriteLine("Enter a String");
string input = Console.ReadLine();
Console.WriteLine("Enter a word to search in string");
string searchWord = Console.ReadLine();
int count = countIndex.countString(input, searchWord);
Console.WriteLine("Word found"+ count + "times in the string");
