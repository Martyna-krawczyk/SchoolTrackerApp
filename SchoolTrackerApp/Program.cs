﻿using System;
using System.Collections.Generic;
using SchoolTrackerApp;

namespace SchoolTracker
{
    enum School
    {
        Hogwarts = 0,
        Harvard = 1,
        MIT = 2
    }
    class Program
    {
        static  List<Student> students = new List<Student>();
        
        static void Main(string[] args)
        {
            Logger.Log("Tracker started", priority: 0 ); //this is called a names argument and saves having
                                                         //to provide the second argument (which is set to default)
            
            
            Payroll payroll = new Payroll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                 Logger.Log("Adding new Student");
                    
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = (Util.Console.AskInt("Student Grade: "));
                    
                    newStudent.School = (School) Util.Console.AskInt("Student SchoolName: " +
                                                                     "(type the corresponding number):\n " +
                                                                     "0: Hogwarts High \n " +
                                                                     "1: Harvard \n " +
                                                                     "2: MIT \n ");

                    newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                    newStudent.Address = Util.Console.Ask("Student Address: ");

                    newStudent.Phone = (Util.Console.AskInt("Student Phone Number: "));

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student Count: {0}", Student.Count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message); //much more specific - needs to be first
                                                    //.Message will clean up the error
                }
                catch (Exception)
                {
                    Console.WriteLine("Error - please try again");
                }
            }
            
            ShowGrade(" Peter "); //here we pass in the name for the search function

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                Exports();
            }
        }


        static void Import() //an example method which allows students to be imported
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }

        //The two methods below are searching the students for the grade of the student named Jim.
        // static void ShowGrade(string name)
        // {
        //     var found = students.Find(Predicate);
        //     Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        // }
        //
        // static bool Predicate(Student student)
        // {
        //     //if
        //     return (student.Name == "Jim"); //This line replaces the if statement as it's
        //                                     //doing the same thing 'syntactic sugar'
        //     //     return true;
        //     // else
        //     //     return false;
        // }
        
        //The above can be replaced with a lambda function:
        static void ShowGrade(string name)
         {
             //anonymous function (no name - predicate - required) in fully condensed form
            var found = students.Find(student => student.Name == name); 
            
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }
}