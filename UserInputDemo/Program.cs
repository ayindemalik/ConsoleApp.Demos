// Practice With Variables
string name = string.Empty;
int age = 0;

int retirementAge = 65;

// Prompt the user for input 
Console.WriteLine("Please enter your full name");
name = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Process the results to the user;
int workingAgeRemaining = retirementAge - age;


// Output the result
Console.WriteLine($" Full name : {name}");
Console.WriteLine($" Age : {age}");
Console.WriteLine($" Working years remainig is : {workingAgeRemaining}");
