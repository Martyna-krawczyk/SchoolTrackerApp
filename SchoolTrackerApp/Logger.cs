using System;

namespace SchoolTrackerApp
{
    public class Logger //Logger will be logging exception handling - low, high or critical priority
    {
        const string DefaultSystemName = "SchoolTracker";
        public static void Log(string msg, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Message: {2}", system, priority, msg);
        }
    }
}