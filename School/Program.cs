using System;
using System.Collections.Generic;


namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        // Class Fields
        private static int nextStudentID = 1;

        // Properties
        protected string Name { get; set; }
        protected internal int StudentID { get; set; }
        protected int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        // Methods
        private int GetStudentID()
        {
            return StudentID;
        }

        private void SetStudentID(int value)
        {
            //This method is used in the Constructor below
            StudentID = value;
        }

        // Constructors - Overloaded
        public Student(string name, int numberOfCredits, double gpa)
        {
            SetStudentID(++nextStudentID);
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name)
            : this(name, 0, 0) { }


        public void AddGrade(int CourseCredits, double grade)
        {
            //set NumberOfCredits and Gpa
            NumberOfCredits += CourseCredits;
            Gpa = grade / NumberOfCredits;
        }

        public string GetGradeLevel(int CourseCredits)
        {
            if (CourseCredits< 30) 
            {
                return "Freshman";
            } else if (CourseCredits < 60) 
            {
                return "Sophomore"; 
            } else if (CourseCredits < 90)
            {
                return "Junior";
            } else
            {
                return "Senior";
            }
        }
    }
    

    public class Course
    {
        // Class Fields
        private static int nextCourseID = 1;

        // Properties
        string Name { get; set; }
        private int CourseID { get; set; }
        public const int Credits = 3;
        List<string> Prerequisits { get; set; }
        List<Student> Students { get; set; }

        // Methods
        private int GetCourseID()
        {
            return CourseID;
        }

        private void SetCourseID(int value)
        {
            //This is used in the constructor below
            CourseID = value;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public void SetStudents(Student student)
        {
            Students.Add(student);
        }

        // Constructors - Overloaded
        public Course(string name, List<string> prereqs)
        {
            SetCourseID(++nextCourseID);
            Name = name;
            Prerequisits = prereqs;
        }

    }


}




