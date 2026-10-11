//3:  Draw a real picture for single level inheritance.
//Perform following tasks.
//Task 1: Create a class
//Task 2: Add few data members as private, protected and public
//Task 3: Add few methods as public to work on defined data members
//Task 4: Create another applicable class which inherits members from above class
//Task 5: Add few data members as private, protected and public into second class
//Task 6: Add few methods as public to work on defined data members into second class
//Task 7: Create a Demo class with main method.
//Task 8: Create at least two objects of a second class defined in Task 4 into main method and call all methods using that object.
//Task 9: Write comment for each important portion of code like data members’ declaration, methods, some important logic etc.
//Task 10: Summarize above solution in your own few words to visualize the solution to the end user.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practical
{
    class University
    {
        public string uni_name;
        protected string department;
        private string courses;

        public University(string name, string dept, string course)
        {
            uni_name = name;
            department = dept;
            courses = course;
        }

        public void DisplayName()
        {
            Console.WriteLine("University Name: " + uni_name);
        }

        public void DisplayDept()
        {
            Console.WriteLine("Department: " + department);
        }

        public void DisplayCourses()
        {
            Console.WriteLine("Courses: " + courses);
        }

        public void Display()
        {
            DisplayName();
            DisplayDept();
            DisplayCourses();
        }
    }
        class Engineering : University
        {
            public string CSE;
            private string FOT;
            protected string IT;

            public Engineering(string name,string dept,string course,string cse,string fot,string it) 
                : base(name,dept,course)
            {
                CSE = cse;
                FOT = fot;
                IT = it;
            }

            public void DisplayCSE()
            {
                Console.WriteLine("CSE: " + CSE);
            }

            public void DisplayFOT()
            {
                Console.WriteLine("FOT: " + FOT);
            }

            public void DisplayIT()
            {
                Console.WriteLine("IT: " + IT);
            }

            public void DisplayEng()
            {
                Display();
                DisplayCSE();
                DisplayFOT();
                DisplayIT();
            }
        }
    

    class Class_Tutorial4_3
    {
        public static void Tutorial4_3Main(string[] args)
        {
            Engineering e = new Engineering("RK", "Engineering", "Computer Science", "CSE", "FOT", "IT");
            e.DisplayEng();
            e.Display();

            Console.ReadLine();

            Console.WriteLine("Name:- khush dobariya , Enrollment:- 25SOECE13052");

        }
    }
}
