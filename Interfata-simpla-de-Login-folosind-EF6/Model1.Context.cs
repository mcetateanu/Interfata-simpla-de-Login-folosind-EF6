﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Login_MagazinEntities : DbContext
    {
        public Login_MagazinEntities()
            : base("name=Login_MagazinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Users_1> Users_1 { get; set; }
    
        public virtual int uspNewUser_Name(string user_Name, string password_, Nullable<int> type, ObjectParameter user_ID)
        {
            var user_NameParameter = user_Name != null ?
                new ObjectParameter("User_Name", user_Name) :
                new ObjectParameter("User_Name", typeof(string));
    
            var password_Parameter = password_ != null ?
                new ObjectParameter("Password_", password_) :
                new ObjectParameter("Password_", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspNewUser_Name", user_NameParameter, password_Parameter, typeParameter, user_ID);
        }
    }
}
