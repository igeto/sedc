using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class UniversityCard
    {
        public int CardId { get; set; }
        private IStudent StudentLink { get; set; }

        public void LinkCardToStudent(IStudent student)
        {
            StudentLink = student;
        } 
    }
}
