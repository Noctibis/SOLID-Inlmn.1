using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Inlmn._1
{
    interface ICustomer
    {
        string Fullname { get; set; }
        int Userid {get; set;}
        string Petname {get; set;}
        string Status {get; set;}
        string Service {get; set;}
        string Total {get; set;}

    }
}
