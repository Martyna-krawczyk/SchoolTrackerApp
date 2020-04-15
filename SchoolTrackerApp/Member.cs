namespace SchoolTrackerApp
{
    public class Member //because the other classes are utilising the same fields, Member will now be the parent class
                        //which the Teacher and Student class inherit from.
    {
        public string Name { get; set; } //auto implemented property
        public string Address { get; set; }
        public int Phone { get; set; } //the auto implemented property now needs to be made public
        
        //protected int phone; //can be shared across classes with inheritance if set to protected
                             //(private will not share)
        
        // public int Phone
        // {
        //     set { phone = value; }
        // }
    }
}