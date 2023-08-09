//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }
    
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long OIB { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public System.DateTime Since { get; set; }
        public int IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
