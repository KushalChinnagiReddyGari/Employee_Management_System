//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpProfile
    {
        public int EmpCode { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public Nullable<int> DeptCode { get; set; }
    
        public virtual DeptMaster DeptMaster { get; set; }
    }
}
