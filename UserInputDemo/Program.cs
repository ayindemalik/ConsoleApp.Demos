// Practice With Variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;

int retirementAge = 65;

// Prompt the user for input 
Console.WriteLine("Please enter your first name");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your last name");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Process the results to the user;
int workingAgeRemaining = retirementAge - age;


// Output the result
Console.WriteLine($" Full name : {firstName} {lastName}");
Console.WriteLine($" Age : {age}");
Console.WriteLine($" Working years remainig is : {workingAgeRemaining}");
