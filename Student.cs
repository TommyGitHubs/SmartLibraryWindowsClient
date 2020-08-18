using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Library
{
    class Student
    {
        public string name { get; set; }
        public string username { get; set; } // for admin
        public string id { get; set; }
        public string major { get; set; }
        public string image { get; set; }
        public string RollNo { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string passwordBcrypt { get; set; }
    }
}
