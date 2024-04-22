using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the user's grade percentage
        Console.Write("Enter your grade percentage: ");
        string gradePercentageAsText = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageAsText);

        // Output the user's letter grade
        char letterGrade;
        if (gradePercentage >= 90) 
        {
            letterGrade = 'A';
        }
        else if (gradePercentage >= 80) 
        {
            letterGrade = 'B';
        }
        else if (gradePercentage >= 70) 
        {
            letterGrade = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = 'D';
        }
        else 
        {
            letterGrade = 'F';
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        // Output if the user's passed or failed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Great Job!! You passed the course.");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}