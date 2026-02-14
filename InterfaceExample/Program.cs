using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Interface1 obj=new Interface1();//you can 't create object for abstarct class and interface.it will throw error.


            //always create object for child class and access the methods in outside.
         //objectname fallows camecase rule of coding standard.
           Student studentObj = new Student();
           int intresult= studentObj.CalculateData();
            Console.WriteLine(intresult);
            studentObj.DisplayData();
            bool isResult=  studentObj.IsValid();//boolean related variables and methods starts with "Is".this is coding standard rule
            Console.WriteLine(isResult);
            string strResult = studentObj.DisplayName();
            Console.WriteLine(strResult);
            Console.ReadLine();
        }
    }
}
