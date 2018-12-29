using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class SubjectGrade
    {
        public long Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
