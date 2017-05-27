using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformasProprietarias1
{
    class Slide8
    {
        public class People
        {
        }

        public class Student : People
        {
            public Student(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

            public int Id { get; }
            public string Name { get; set; }
        }

        public class Exercise
        {
        }

        public class Course
        {
            public Course(string name, int numberOfLesson, List<Exercise> exercises)
            {
                this.Name = name;
                this.NumberOfLesson = numberOfLesson;
                this.Exercises = exercises;
            }

            public string Name { get; set; }
            public int NumberOfLesson { get; set; }
            public List<Exercise> Exercises { get; set; }
        }

        public class Professor : People
        {
            public Professor(string name, List<Course> courses)
            {
                this.Name = name;
                this.Courses = courses;
            }

            public string Name { get; set; }
            public List<Course> Courses { get; set; }
        }

        public class Class
        {
            public Class(string identifier, List<Professor> professors, List<Student> students)
            {
                this.Identifier = identifier;
                this.Professors = professors;
                this.Students = students;
            }

            public string Identifier { get; }
            public List<Professor> Professors { get; set; }
            public List<Student> Students { get; set; }
        }

        public class School
        {
            public School(List<Class> classes)
            {
                this.Classes = classes;
            }

            public List<Class> Classes { get; set; }
        }

        public abstract class Shape
        {
            public Shape(int width, int height)
            {
                this.Width = width;
                this.Height = height;
            }

            public int Width { get; set; }
            public int Height { get; set; }

            public abstract double CalculateSurface();
        }

        public class Triangle : Shape
        {
            public Triangle(int width, int height) : base(width, height)
            {
            }

            public override double CalculateSurface()
            {
                return (Width * Height) / 2;
            }
        }

        public class Rectangle : Shape
        {
            public Rectangle(int width, int height) : base(width, height)
            {
            }

            public override double CalculateSurface()
            {
                return Width * Height;
            }
        }

        public class Circle : Shape
        {
            public Circle(int diameter) : base(diameter, diameter)
            {
            }

            public override double CalculateSurface()
            {
                return Math.PI * Math.Pow((Width / 2), 2);
            }
        }

        public void TestShapes()
        {
            List<Shape> shapes = new List<Shape>() {
                new Triangle(2, 3),
                new Rectangle(5, 5),
                new Circle(4)
            };

            foreach(Shape shape in shapes)
            {
                Console.WriteLine("Área da forma " + shape.CalculateSurface());
            }
        }
    }
}
