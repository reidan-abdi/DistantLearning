//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistantLearningSystem.Models.DataModels
{
    using System;
    using System.Collections.Generic;

    public partial class StudentGroup
    {
        public StudentGroup()
        {
            this.Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> LecturerId { get; set; }

        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public int GetGroupCourse()
        {
            string[] strs = Name.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime dt = new DateTime(2000 + Convert.ToInt32(strs[1]), 9, 1);
            DateTime now = DateTime.Now;
            var rez = now.Subtract(dt);
            return ((int)(rez.TotalDays + 365 - 1)) / 365;
        }
    }
}
