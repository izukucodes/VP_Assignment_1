using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Press 1 to Add new Student");
            Console.WriteLine("Press 2 to Display Youngest Student");
            Console.WriteLine("Press 3 Delete a Student after taking as input");
            Console.WriteLine("Press 4 Create a new List from given list containing only 3rd Semester Students");
        }     
        public static void Display(Student s)
        {
            Console.WriteLine($"ID: {s.ID}");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine($"Age: {s.Age}");
            Console.WriteLine($"Semester: {s.Semester}");
        }


static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student{ ID = 1, Name = "Hassan", Age = 21, Semester = 5  },
                new Student{ ID = 2, Name = "Amna", Age = 20, Semester = 4  },
                new Student{ ID = 3, Name = "Binyamin", Age = 20, Semester = 4  },
                new Student{ ID = 4, Name = "Tahir", Age = 1, Semester = 2  },
                new Student{ ID = 5, Name = "Talha", Age = 20, Semester = 4  },
            };

            int choice = 0;
            while (true)
            {
                Menu();
                Console.Write("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    // Taking Student Input

                    Student newStd = new Student();
                    Console.Write("Enter ID: ");
                    newStd.ID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    newStd.Name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    newStd.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Semester: ");
                    newStd.Semester = Convert.ToInt32(Console.ReadLine());

                    // Adding to List
                    students.Add(newStd);
                }
                else if (choice == 2)
                {
                    Student YoungestStd = students[0];
                    foreach (var std in students)
                    {
                        YoungestStd = std.Age < YoungestStd.Age ? std : YoungestStd;
                    }
                    Display(YoungestStd);
                }

                else if (choice == 3)
                {
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Student s = students.FirstOrDefault(c => c.ID == id);


                    students.Remove(s);
                    
                    // For Testing
                    //Console.WriteLine("Removed Successfully");
                    //foreach(var a in students)
                    //{
                    //    Display(a);
                    //}    
                }

                else if (choice == 4)
                {
                    List<Student> newStds = new List<Student>();
                    foreach (var s in students)
                    {
                        if (s.Semester == 3)
                        {
                            newStds.Add(s);
                        }
                    }

                    //foreach (var a in newStds)
                    //{
                    //    Display(a);
                    //}
                }

                else if (choice == 5)
                {
                    break;
                }

            }


            // Q3

            //MyArrayList a = new MyArrayList();
            //a.Add("Hassan");
            //a.Add("Hassan");
            //a.Add("Hassan");
            //a.Add("Hassan");
            //a.Add("Hassan");
            //a.Add("Hassan");
            //a.Add("Hassan");

            ////foreach(var s in a)
            ////{
            ////    Console.WriteLine(s);
            ////}

            ////a.Remove(a);
            ////foreach (var s in a)
            ////{
            ////    Console.WriteLine(s);
            ////}

            Console.ReadKey();
        }
    }
}
