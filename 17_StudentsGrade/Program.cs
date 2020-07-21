using System;

namespace _17_StudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstExam, secondExam, thirdExam;
            string grade;
            Console.WriteLine("Enter the first grade between 0 and 100:");
            firstExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second grade between 0 and 100:");
            secondExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third grade between 0 and 100:");
            thirdExam = int.Parse(Console.ReadLine());
            double average = (Convert.ToDouble(firstExam) + Convert.ToDouble(secondExam) + Convert.ToDouble(thirdExam)) / 3;
            average = Math.Round(average);
            if(average <= 50)
            {
                grade = "Not enough";
            } else if(average >= 51 && average <= 60)
            {
                grade = "Six";
                Console.WriteLine($"Student's grade is {grade}");
            }
            else if (average >= 61 && average <= 70)
            {
                grade = "Seven";
                Console.WriteLine($"Student's grade is {grade}");
            }
            else if (average >= 71 && average <= 80)
            {
                grade = "Eight";
                Console.WriteLine($"Student's grade is {grade}");
            }
            else if (average >= 81 && average <= 90)
            {
                grade = "Nine";
                Console.WriteLine($"Student's grade is {grade}");
            }
            else if (average >= 91 && average <= 100)
            {
                grade = "Ten";
                Console.WriteLine($"Student's grade is {grade}");
            }
        }
    }
}
