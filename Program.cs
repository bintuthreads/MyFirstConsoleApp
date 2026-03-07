////Task 1: Arithmetic Operators
int a = 60;
int b = 25;
int addedresult = a + b;
int subtractionresult = a - b;
int multiplicationresult = a * b;
double divisionresult = (double) a / b;
int modulusresult = a % b;

Console.WriteLine($"adding a and b value = {addedresult}");
Console.WriteLine($"subtracting a and b value = {subtractionresult}");
Console.WriteLine($"multiplying a and b value = {multiplicationresult}");
Console.WriteLine($"dividing a and b value = {divisionresult}");
Console.WriteLine($"modulusing a and b value = {modulusresult}");

//////Task 2 — Integer vs Double Division
int A = 10;
int B = 4;
int diviisionresult = A / B;
double divisionresults = (double)A / B;

//Integer division result
Console.WriteLine($"dividing a and b value =  {diviisionresult}");
//Double division result
Console.WriteLine($"diving a and b value = {divisionresults}");

/////Task 3 — Large Numbers
long population = 10000000;
int increase = 79893;
long longresult = population + increase;
Console.WriteLine($"adding population and increase value = {longresult}");

/////Task 4 — Shop Calculator
decimal price = 1500.75m;
int quantity = 3;
decimal totalcost = price * quantity;
Console.WriteLine($"finding the total cost = {totalcost}");

/////Task 5 — Bonus Challenge
int number1 = 11;
int number2 = 12;
int number3 = 13;
int addednumbers = number1 + number2 +number3;
int averagenumber = addednumbers / 3;
double averagenubers = (double)addednumbers / 3;
Console.WriteLine($"finding the averagenumber = {averagenumber}");
Console.WriteLine($"finding the double averagenumber = {averagenubers}");