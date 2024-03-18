﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeDBEntities : DbContext
    {
        public EmployeeDBEntities()
            : base("name=EmployeeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DeptMaster> DeptMasters { get; set; }
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; }
    
        public virtual int sp_InsertDeptMaster(Nullable<int> p_DeptCode, string p_DeptName)
        {
            var p_DeptCodeParameter = p_DeptCode.HasValue ?
                new ObjectParameter("p_DeptCode", p_DeptCode) :
                new ObjectParameter("p_DeptCode", typeof(int));
    
            var p_DeptNameParameter = p_DeptName != null ?
                new ObjectParameter("p_DeptName", p_DeptName) :
                new ObjectParameter("p_DeptName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertDeptMaster", p_DeptCodeParameter, p_DeptNameParameter);
        }
    
        public virtual int sp_InsertEmployeeProfile(Nullable<int> p_EmpCode, Nullable<System.DateTime> p_DateOfBirth, string p_EmpName, string p_Email, Nullable<int> p_DeptCode)
        {
            var p_EmpCodeParameter = p_EmpCode.HasValue ?
                new ObjectParameter("p_EmpCode", p_EmpCode) :
                new ObjectParameter("p_EmpCode", typeof(int));
    
            var p_DateOfBirthParameter = p_DateOfBirth.HasValue ?
                new ObjectParameter("p_DateOfBirth", p_DateOfBirth) :
                new ObjectParameter("p_DateOfBirth", typeof(System.DateTime));
    
            var p_EmpNameParameter = p_EmpName != null ?
                new ObjectParameter("p_EmpName", p_EmpName) :
                new ObjectParameter("p_EmpName", typeof(string));
    
            var p_EmailParameter = p_Email != null ?
                new ObjectParameter("p_Email", p_Email) :
                new ObjectParameter("p_Email", typeof(string));
    
            var p_DeptCodeParameter = p_DeptCode.HasValue ?
                new ObjectParameter("p_DeptCode", p_DeptCode) :
                new ObjectParameter("p_DeptCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertEmployeeProfile", p_EmpCodeParameter, p_DateOfBirthParameter, p_EmpNameParameter, p_EmailParameter, p_DeptCodeParameter);
        }

       

        public virtual int sp_UpdateDeptMaster(Nullable<int> p_DeptCode, string p_DeptName)
        {
            var p_DeptCodeParameter = p_DeptCode.HasValue ?
                new ObjectParameter("p_DeptCode", p_DeptCode) :
                new ObjectParameter("p_DeptCode", typeof(int));
    
            var p_DeptNameParameter = p_DeptName != null ?
                new ObjectParameter("p_DeptName", p_DeptName) :
                new ObjectParameter("p_DeptName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateDeptMaster", p_DeptCodeParameter, p_DeptNameParameter);
        }
    
        public virtual int sp_UpdateEmployeeProfile(Nullable<int> p_EmpCode, Nullable<System.DateTime> p_DateOfBirth, string p_EmpName, string p_Email, Nullable<int> p_DeptCode)
        {
            var p_EmpCodeParameter = p_EmpCode.HasValue ?
                new ObjectParameter("p_EmpCode", p_EmpCode) :
                new ObjectParameter("p_EmpCode", typeof(int));
    
            var p_DateOfBirthParameter = p_DateOfBirth.HasValue ?
                new ObjectParameter("p_DateOfBirth", p_DateOfBirth) :
                new ObjectParameter("p_DateOfBirth", typeof(System.DateTime));
    
            var p_EmpNameParameter = p_EmpName != null ?
                new ObjectParameter("p_EmpName", p_EmpName) :
                new ObjectParameter("p_EmpName", typeof(string));
    
            var p_EmailParameter = p_Email != null ?
                new ObjectParameter("p_Email", p_Email) :
                new ObjectParameter("p_Email", typeof(string));
    
            var p_DeptCodeParameter = p_DeptCode.HasValue ?
                new ObjectParameter("p_DeptCode", p_DeptCode) :
                new ObjectParameter("p_DeptCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateEmployeeProfile", p_EmpCodeParameter, p_DateOfBirthParameter, p_EmpNameParameter, p_EmailParameter, p_DeptCodeParameter);
        }
        public virtual int sp_InsertEmployee(Nullable<int> p_EmpCode, Nullable<System.DateTime> p_DateOfBirth, string p_EmpName, string p_Email, Nullable<int> p_DeptCode)
        {
            var p_EmpCodeParameter = p_EmpCode.HasValue ?
                 new ObjectParameter("p_EmpCode", p_EmpCode) :
                 new ObjectParameter("p_EmpCode", typeof(int));

            var p_DateOfBirthParameter = p_DateOfBirth.HasValue ?
                new ObjectParameter("p_DateOfBirth", p_DateOfBirth) :
                new ObjectParameter("p_DateOfBirth", typeof(System.DateTime));

            var p_EmpNameParameter = p_EmpName != null ?
                new ObjectParameter("p_EmpName", p_EmpName) :
                new ObjectParameter("p_EmpName", typeof(string));

            var p_EmailParameter = p_Email != null ?
                new ObjectParameter("p_Email", p_Email) :
                new ObjectParameter("p_Email", typeof(string));

            var p_DeptCodeParameter = p_DeptCode.HasValue ?
                new ObjectParameter("p_DeptCode", p_DeptCode) :
                new ObjectParameter("p_DeptCode", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertEmployee", p_EmpCodeParameter, p_DateOfBirthParameter, p_EmpNameParameter, p_EmailParameter, p_DeptCodeParameter);
        }
    }
}