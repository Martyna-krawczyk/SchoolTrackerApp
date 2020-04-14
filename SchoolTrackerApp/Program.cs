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
            Payroll payroll = new Payroll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");

                    newStudent.Grade = (Util.Console.AskInt("Student Grade: "));

                    //(School) below is cast -??  More info required here
                    newStudent.School = (School) Util.Console.AskInt("Student SchoolName: (type the corresponding number): 0: Hogwarts High \n 1: Harvard \n 2: MIT \n ");

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
                    Console.WriteLine(msg.Message); //much more specific - needs to be first .Message will clean up the error
                }
                catch (Exception)
                {
                    Console.WriteLine("Error - please try again");
                }
            }

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
    }
}