//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManyToManyBridgeTable
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.StudentCourses = new HashSet<StudentCourse>();
        }
    
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
