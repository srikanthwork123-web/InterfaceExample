using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal interface IEmailSystem
    {
        //this is one abstarct method.it contains method heading only.no method body
        //by default interface methods are public abstarct.due that no need to write public abtarct before return type.
        String SendEmailToCustomer();

        //void EmailReporStatus();
        
    }
}
