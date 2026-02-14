using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Student : Interface1
    {
        public int CalculateData()
        {
            return 10;
        }

        public void DisplayData()
        {
            //return 10;//Insiide void method don't write return keyword.if you write it will throw compiletime error.
            Console.WriteLine("sample data");
        }

        public string DisplayName()
        {
            return "Hai";
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
