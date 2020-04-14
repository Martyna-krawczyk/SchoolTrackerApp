using System;
using SchoolTracker;

namespace SchoolTrackerApp
{
    public class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying the principal");
        }
    }
}