using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public SubjectStatus Status { get; set; }
        public List<SubjectGrade> SubjectGrades { get; set; }
        public List<Mark> Marks { get; set; }
    }
    public enum SubjectStatus {
        Pass = 1,
        Fail = 0
    }


}
