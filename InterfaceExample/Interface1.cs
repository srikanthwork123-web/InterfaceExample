using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal interface Interface1
    {
//In interface you will write only abstarct members.this is the rule
//interface members are abstract members.
//In interface only write abstarct methods(it conatins only method heading).no method body
//By default public abstract is availble before method return type.no need write public abstratct to before return type.
//If you write public abstarct it will throw compiletime error.
        //public abstract void DisplayEmpData();

//Synatx of interface method:
//==========================
//returntype methodname();//method heading


        void DisplayData();//method heading
        string DisplayName();//returntype methodname();  //these are abstarct methods.
        int CalculateData();//returntype methodname();
        bool IsValid();//returntype methodname();

    }
}
