﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Biil> Biils { get; set; }
        public virtual DbSet<Cleaner> Cleaners { get; set; }
        public virtual DbSet<CleanerSalary> CleanerSalaries { get; set; }
        public virtual DbSet<Exam2> Exam2 { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<GradeList> GradeLists { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<OfficeSalary> OfficeSalaries { get; set; }
        public virtual DbSet<StaffNotice> StaffNotices { get; set; }
        public virtual DbSet<StudentFee> StudentFees { get; set; }
        public virtual DbSet<StudentSubject> StudentSubjects { get; set; }
        public virtual DbSet<StudentTB> StudentTBs { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<SubjectDetail> SubjectDetails { get; set; }
        public virtual DbSet<SubjectTB> SubjectTBs { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<teacher_grade> teacher_grade { get; set; }
        public virtual DbSet<teacher_subject> teacher_subject { get; set; }
        public virtual DbSet<TeacherList> TeacherLists { get; set; }
        public virtual DbSet<TeacherSalary> TeacherSalaries { get; set; }
        public virtual DbSet<Timetable> Timetables { get; set; }
        public virtual DbSet<upload_file> upload_file { get; set; }
        public virtual DbSet<upload_file_teacher> upload_file_teacher { get; set; }
        public virtual DbSet<UserFeedback> UserFeedbacks { get; set; }
    }
}
