using System;
using SchoolTracker;

namespace SchoolTrackerApp
{
    class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}

