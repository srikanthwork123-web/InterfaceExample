using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class SipDashboard : Interface1
    {//Implement the interface methods in the child class
        public int CalculateData()
        {
            // throw new NotImplementedException();
            return 20;//Int always return the integerdata
        }

        public void DisplayData()
        {
            //throw new NotImplementedException();
            Console.WriteLine("SipDashboard");
        }//void method does not return anything

        public string DisplayName()
        {
            // throw new NotImplementedException();
            return "sipDashboard";
        }//string method return the stringdata;

        public bool IsValid()
        {
            // throw new NotImplementedException();
            return false;
        }//bool method always return the booleandata.
    }
}
