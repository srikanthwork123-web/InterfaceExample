using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    //if you create any class or interface default access modiifer in "Internal";
    internal class EmailRespositrory : IEmailSystem
    {
        public string SendEmailToCustomer()
        {
            Console.WriteLine("Here i am writing email sending logic");
            return "emailsent successfully";
        }
    }
}
