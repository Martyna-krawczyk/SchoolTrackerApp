using System.Collections.Generic;

namespace SchoolTrackerApp
{
    interface IPayee //The Interface guarantees that each object's classes have a Pay Function.
                     //As student does not inherit interface, it is not a payee.
    {
        void Pay();
    }
    class Payroll
    {
        private List<IPayee> payees = new List<IPayee>(); //single list for many types of classes all inheriting from Interface
        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}