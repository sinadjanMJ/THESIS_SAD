﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullScreenAppDemo.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class studentPortalEntities : DbContext
    {
        public studentPortalEntities()
            : base("name=studentPortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assign_Instructor> assign_Instructor { get; set; }
        public virtual DbSet<assignSubject> assignSubjects { get; set; }
        public virtual DbSet<Class_S> Class_S { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Dean> Deans { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<S_Subject> S_Subject { get; set; }
        public virtual DbSet<Student_Profile> Student_Profile { get; set; }
        public virtual DbSet<studentBackground> studentBackgrounds { get; set; }
        public virtual DbSet<userLogin> userLogins { get; set; }
        public virtual DbSet<transactionGrade> transactionGrades { get; set; }
        public virtual DbSet<regisGrade> regisGrades { get; set; }
    }
}
