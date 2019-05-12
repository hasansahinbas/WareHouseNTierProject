using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WareHouseNTierProject.UI.Areas.Admin.Models.DTO
{
    public class SupplierDTO:BaseDTO
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}