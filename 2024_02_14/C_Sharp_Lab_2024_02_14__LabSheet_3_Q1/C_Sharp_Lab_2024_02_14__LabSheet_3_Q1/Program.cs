using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_14__LabSheet_3_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Course course1 =  new Course("A",30);
            course1.InstructorName = course1.SetInstructorName();

            course1.PrintCourseInfo();
        }
    }

    public class Course
    {
        private string courseName;
        private string instructorNamep;
        private double grade;

        public string InstructorName
        {
            get { return instructorNamep; }
            set { instructorNamep = value; }
        }

      

        public Course(string c_courseName, double c_grade)
        {
            courseName = c_courseName;
            grade = c_grade;
        }
        
        /*public string CourseName { get; set; }
        public double Grade { get; set; }*/

        public string SetInstructorName()
        {
            bool isValideName = false;

            while (!isValideName)
            {
                Console.Write("Enter the instructor's name:");
                string instructorName = Console.ReadLine();

                if (string.IsNullOrEmpty(instructorName))
                {
                    Console.WriteLine("Input is empty or invalide. Try again");
                }
                else
                {
                    isValideName = true;
                    return InstructorName;

                }
            }
            return null;
            
        }

        private string CalculateLetterGrade(double grade)
        {
            string gradeMarks;
            if (grade < 45)
            {
                gradeMarks = "F";
            }
            else if (grade < 55)
            {
                gradeMarks = "S";
            }
            else if (grade < 65)
            {
                gradeMarks = "C";
            }
            else if (grade < 75)
            {
                gradeMarks = "B";
            }
            else if (grade < 100)
            {
                gradeMarks = "A";
            }
            else
            {
                gradeMarks = "Error";
            }

            return gradeMarks;

        }

        public void PrintCourseInfo()
        {
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Instructor Name: {instructorNamep}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Letter Grade: {CalculateLetterGrade(grade)}");
        }
    }
}
