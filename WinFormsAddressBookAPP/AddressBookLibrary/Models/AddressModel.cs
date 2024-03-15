using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLibrary.Models
{
    public class AddressModel(string streetAddress, string state, string zipCode)
    {
        public string StreetAddress { get; set; } = streetAddress;
        public string State { get; set; } = state;
        public string ZipCode { get; set; } = zipCode;
        public string FullAddress { get; private set; } = $"{streetAddress}, {state}, {zipCode}";
    }
}
