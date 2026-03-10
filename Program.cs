//// CHALLENGE 1: Multi-condition Exam Eligibility
// A student can take the final exam only if they meet at least one of the following conditions:
//- Paid fees AND has ID card - OR has done matriculation - OR is a citizen
//Task: - Use boolean variables: paidFees, hasIDCard, hasDoneMatric, isCitizen - Write a
//logical expression using && and || - Predict the output for: paidFees = true, hasIDCard = //true,
//hasDoneMatric = false, isCitizen = false - Explain step by step


/*bool paidFees = true;
bool hasIDCard = true;
bool hasDoneMatric = false;
bool isCitizen = false;

if (paidFees && hasIDCard || hasDoneMatric || isCitizen)
{
Console.WriteLine("a student can take final exam");
}
else
{
    Console.WriteLine("a student can not take final exam");
}*/
// step 1; paidFees && hasIDCard has the same variables which are "true".
// true && true == true
// While hasDoneMatric && isCitizen are "false" values.
// moreover this makes the full expression to be "true||false||false"
// step 2: since the expression is "true||false||false",
// and true is in the statement authomatically the result is "true",
// because the student has met two conditions (paidFees && hasIDCard)

//Challenge 2 – ACCESS TO SCHOOL PORTAL

/*A student can access the school portal if: - They have completed registration AND paid
fees - OR they are a citizen AND have an ID card
Task: - Use boolean variables: paidFees, hasIDCard, hasDoneRegistration, isCitizen -
    Evaluate the expression using: paidFees = false, hasIDCard = true,
hasDoneRegistration = true, isCitizen = false - Explain the output*/

/*bool paidFees = false;
bool hasIDCard = true;
bool hasDoneRegistration = true;
bool isCitizen = false;

if (hasIDCard && hasDoneRegistration || paidFees || isCitizen)
{
    Console.WriteLine("a student can access the school portal");
}
else
{
    Console.WriteLine("a student can not access the school portal");
}*/
/// The output statement was "a student can access the school portal" which is true.
//The output is true because "hasIDCard && hasDoneRegistration"
    
    
/*CHALLENGE3 - GRADING SYSTEM
Write a program to assign grades based on score: - A if score ≥ 80 - B if score ≥ 60 and < 80 - C 
if score ≥ 50 and < 60 - Fail if score < 50
Task: - Use if, else if, and comparison operators - Test for scores: 45, 55, 65, 85 - Explain
why each score receives the grade*/

/*int score = 45;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60)
{
  Console.WriteLine("Grade B"); 
}
else if (score >= 50)
{
    Console.WriteLine("Grade C");
}
else if (score < 50)
{
    Console.WriteLine("Fail");
}*/
// score 45 is "fail" because the score is less than 50,
// of which we already compare it that if it is <50 the result should be "fail"

/*int score = 55;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60)
{
    Console.WriteLine("Grade B"); 
}
else if (score >= 50)
{
    Console.WriteLine("Grade C");
}
else if (score < 50)
{
    Console.WriteLine("Fail");
}*/
// score 55 is "Grade C" because the score is more than 50,
// of which we already compare it that if it is >50 the result should be "Grade C"

/*int score = 65;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60)
{
    Console.WriteLine("Grade B"); 
}
else if (score >= 50)
{
    Console.WriteLine("Grade C");
}
else if (score < 50)
{
    Console.WriteLine("Fail");
}*/
// score 65 is "Grade B" because the score is greater than 60,
// of which we already compare it that if it is >=60 the result should be "Grade B"

/*int score = 85;
if (score >= 80)
{
    Console.WriteLine("Grade A");
}
else if (score >= 60)
{
    Console.WriteLine("Grade B"); 
}
else if (score >= 50)
{
    Console.WriteLine("Grade C");
}
else if (score < 50)
{
    Console.WriteLine("Fail");
}*/
// score 85 is "Grade A" because the score is greater than 80,
// of which we already compare it that if it is >=80 the result should be "Grade A"

////CHALLENGE 4 - LIBARY BORROWING RULES
/*A student can borrow a book only if: - They have paid library fees AND have a valid ID -
    OR they are a staff member AND the book is not reserved
    Task: - Use boolean variables: paidFees, hasIDCard, isStaff, bookReserved - Test with:
paidFees = true, hasIDCard = true, isStaff = false, bookReserved = false - Explain the
    output*/
/*bool paidFees = true;
bool hasIDCard = true;
bool isStaff = false;
bool bookReserved = false;

 if (paidFees && hasIDCard || isStaff || bookReserved)
{
 Console.WriteLine("a student can borrow book");
} 
else 
{
   Console.WriteLine("a student can not borrow book"); 
}*/

//The output statement was "a student can borrow book" which is true.
//The output is true because "paidFees && hasIDCard"

///Challenge 5 – Complex 5-Variable Logic

/*Using 5 boolean variables: paidFees, hasIDCard, hasDoneMatric, hasDoneRegistration,
isCitizen, determine if a student is fully verified for all school processes: - Must either
    have paid fees AND has ID card AND (has done matric OR has done registration) - OR be
    a citizen AND has ID card
Task: - Write the logical expression without brackets first - Evaluate using: paidFees =
    true, hasIDCard = true, hasDoneMatric = false, hasDoneRegistration = false, isCitizen =
    false - Show step-by-step evaluation - Explain the result*/
bool paidFees = true;
bool hasIDCard = true;
bool hasDoneMatric = false;
bool hasDoneRegistration = false;
bool isCitizen = false;

if (paidFees && hasIDCard && (hasDoneMatric || hasDoneRegistration) || isCitizen && hasIDCard)
{ 
    Console.WriteLine("student is fully verified");
}
else
{
 Console.WriteLine("student is not fully verified");   
}
/// the output result is "student is not fully verified"and that because;
/// hasDoneMatric || hasDoneRegistration = "false ||false" which make the two statements = false
//likewise, paidFees && hasIDCard = "true && true" which makes the two statements = true
//while isCitizen && hasIDCard = false && true. 
// in summmary, the logical statement = true (false)||false && true
// Therefore, the output answer is false, (student is not fully verified)