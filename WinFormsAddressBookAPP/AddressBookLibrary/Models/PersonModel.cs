using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.Models
{
    public class PersonModel(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public string FullName { get; private set; } = $"{firstName} {lastName}";
        public List<AddressModel>? Addresses { get; set; } = [];
    }
}
