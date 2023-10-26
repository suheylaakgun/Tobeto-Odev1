using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //Field
        //public string FirstName; 
        
        //Property
        public int Id { get; set; }

        //Bu örnek single responsibilitye aykırı bir durum.
        private string _firstName; //Encapsuliton: Güvenlik için, nesne kullanıcısından get ve set işlemlerinin soyutlanması için kullanılan özelliktir.
        public string FirstName { 
            get 
            {
                return "Mrs." + _firstName; //Ör: Kullanıcı adı önüne oto takma ad koysun
            } 
            set 
            { 
                _firstName = value;
            } 
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
