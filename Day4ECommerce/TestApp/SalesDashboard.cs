using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    //Multiple Interface Inheritance

    internal class SalesDashboard : Dashboard,CustomerDetails,OrderDetails
    {
        public string createdBy { get; set; }
        public string modifiedBy { get; set; }
        public SalesDashboard() {
            this.createdBy = "Ravi";
            this.modifiedBy = "Sachin";
        }
        public SalesDashboard(string creator, string modifer, string dept, int year):base(year,dept)
        {
            this.createdBy = creator;
            this.modifiedBy = modifer;

        }
        public override void Refresh()
        {
            Console.WriteLine("Sales Dashboard data is fetched from database");
            Console.WriteLine("Sales Dashboard is redered with latest data");
        }

         //Explicit Interface Inheritance
        void CustomerDetails.ShowDetails()
        {
            Console.WriteLine("Customer Profile");
            Console.WriteLine("Personal Information");
            Console.WriteLine("Professional Information");
        }

        void OrderDetails.ShowDetails()
        {
            Console.WriteLine("Orders History");
            Console.WriteLine("order id: 45454, status: delivered");
            Console.WriteLine("order id:8989, status: intransit");
        }


        ~SalesDashboard()
        {
            //Release resources which have been blocked
            //during life time of this object
        }
    }
}
