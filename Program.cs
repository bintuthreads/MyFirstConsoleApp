// See https://aka.ms/new-console-template for more information

using System.Net.Security;

Console.WriteLine("Hello, This is Fatimah assessment.");

string name = "Fatimah Balogun";
int age = 23;
double height = 5.21;
bool isStudent = true;

/////////////////////
/// String Concatenation.
Console.WriteLine($"My name is {name}, i am {age} years old. my height is {height}. Are you from the north? {isStudent}");

/// String Interpolation.
Console.WriteLine("my name is " + name + ". i am " + age + " years old. My height is " + height + ". Are you from the north?" + isStudent);