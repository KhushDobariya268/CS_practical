using System;

namespace CS_practical
{
    class Student3
    {
        public int id;
        public string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student3()
        {
            name = "Unknown";
        }

        public Student3(int i, string n)
        {
            id = i;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
        }
    }

    class Class2
    {
        public static void Tutorial3_3main(string[] args)
        {
            Student3 student = new Student3(101, "Khush");

            student.Display();

            Console.ReadLine();
        }
    }
}