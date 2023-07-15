using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal abstract class Dashboard
    {
        public int financialYear;
        public string department;

        public Dashboard() { }
        public Dashboard(int financialYear, string department)
        {
            this.department = department;
            this.financialYear = financialYear;
            
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public abstract void Refresh();
       


    }
}
