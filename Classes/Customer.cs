using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        //public string FirstName { get; set; }
        public string FirstName; //Bu tanım da çalışır ama kullanmama sebebi için encapsuliton dersine git!
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
