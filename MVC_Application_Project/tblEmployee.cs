//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Application_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<long> Phone { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<int> RoleTypeId { get; set; }
    
        public virtual tblcountry tblcountry { get; set; }
        public virtual tblRoleMaster tblRoleMaster { get; set; }
    }
}
