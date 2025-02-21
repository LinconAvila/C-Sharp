using System;

class StudentGrade
{
    static void Main()
    {
        Console.Write("Enter the student's grade: ");
        float grade;
        bool isValidGrade = float.TryParse(Console.ReadLine(), out grade);

        Console.WriteLine(isValidGrade);
        Console.WriteLine(grade);

        if (!isValidGrade)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        if (grade >= 60)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            if (grade >= 50)
            {
                Console.WriteLine("Remedial exam");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
