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
            //===========Calling the Sipdashboard Methods==========
    SipDashboard sdObj=new SipDashboard();
            sdObj.DisplayData();//calling the void returntype method
            //method retun data we need to store in one variable and you can use that variable data as per your requirment.
        string sdObjResult=sdObj.DisplayName();//calling string return type method
            Console.WriteLine(sdObjResult);
         int intsdResult=sdObj.CalculateData();//calling int returntype method
            Console.WriteLine(sdObj.CalculateData());//direct callinging the method and return data we are printing at a time.
            bool sdResult=sdObj.IsValid();//calling the bool returntype method.
//==============calling EmailRepository Methods===========
            EmailRespositrory  emailRespositrory = new EmailRespositrory();

            string resultValue=emailRespositrory.SendEmailToCustomer();
            Console.WriteLine(resultValue);



            Console.ReadLine();
        }
    }
}
