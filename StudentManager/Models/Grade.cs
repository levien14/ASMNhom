using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Grade
    {
        public Grade()
        {
            StartDate = DateTime.Now;
            Status = GradeStatus.Deactived;
        }
        public int Id { get; set; }
        public string GradeName { get; set; }
        public DateTime StartDate { get; set; }
        public List<GradeStudent> GradeStudents { get; set; }
        public List<SubjectGrade> SubjectGrades { get; set; }
        public GradeStatus Status { get; set; }
    }
    public enum GradeStatus {
        Actived = 1,
        Deactived = 0
    }
}
