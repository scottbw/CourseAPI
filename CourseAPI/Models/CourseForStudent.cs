using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseAPI.Models
{
    public class CourseForStudent : Course
    {
        public String enrolmentStageCode;
        public String enrolmentStatusCode;
        public String enrolmentTypeCode;
        public String feeStatusCode;

        public CourseForStudent(String aos_code, String acad_year, String occurrence, String student)
            :base(aos_code, acad_year, occurrence);
        {
            this.personalisedFor = student;
            this.version = "Current";
            this.areaOfStudyTypeCode = "C";
        }
        
        public CourseForStudent(String aos_code, String acad_year, String occurrence, String student, String time)
            :base(aos_code, acad_year, occurrence);
        {
            this.personalisedFor = student;
            this.version = "Current";
            this.areaOfStudyTypeCode = "C";
        }
    }
}