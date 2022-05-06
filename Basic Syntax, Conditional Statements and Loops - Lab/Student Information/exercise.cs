// See https://aka.ms/new-console-template for more information
string studentName;
int age;
double studentGrade;
Console.WriteLine("Enter student's Name: ");
studentName = Console.ReadLine();
Console.WriteLine("Enter student's Age: ");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter student's Grade: ");
studentGrade = int.Parse(Console.ReadLine());
Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", studentName,age,studentGrade);
