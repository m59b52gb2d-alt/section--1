Console.Write("Enter Student Name: ");
string name = Console.ReadLine();

Console.Write("Enter Exam Score: ");
double score = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Attendance Rate: ");
double attendance = Convert.ToDouble(Console.ReadLine());

if (score < 0 || score > 100 || attendance < 0 || attendance > 100)
{
    Console.WriteLine("Invalid Input: Values must be between 0 and 100.");
}
else if (attendance < 75)
{
    Console.WriteLine("Status: Failed - Reason: Low Attendance Rate");
}
else if (score >= 90)
{
    Console.WriteLine("Grade: A (Excellent)");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B (Very Good)");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C (Good)");
}
else if (score >= 50)
{
    Console.WriteLine("Grade: D (Pass)");
}
else
{
    Console.WriteLine("Grade: F (Fail)");
}


