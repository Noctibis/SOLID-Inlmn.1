using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Inlmn._1
{
    class Customer : ICustomer
    {
        public string Fullname { get ; set ; }
        public int Userid { get ; set ; }
        public string Petname { get ; set ; }
        public string Status { get ; set ; }
        public string Service { get ; set ; }
        public string Total { get ; set ; }

        public Customer(string fullname, int userid, string petname, string status, string service, string total)
        {
            Fullname = fullname;
            Userid = userid;
            Petname = petname;
            Status = status;
            Service = service;
            Total = total;

        }
        public Customer(string fullname, int userid, string petname, string status, string service)
        {
            Fullname = fullname;
            Userid = userid;
            Petname = petname;
            Status = status;
            Service = service;

        }
    }
}
