using SchoolTracker;

namespace SchoolTrackerApp
{
    class Student : Member
    {
        static public int Count = 0;
        public int Grade;
        public string Birthday;
        public School School;


        public Student()
        {
        } //another constructor which allows the new student to be initialised without passing all of the properties
    
        public Student(string name, int grade, string birthday, string address, int phone) //constructor
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
