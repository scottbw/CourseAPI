using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseAPI.Models
{
    public class CourseForStudent : Course
    {
        public String personalisedFor;
        public String enrolmentStageCode;
        public String enrolmentStatusCode
        public String enrolmentTypeCode
        public String feeStatusCode

        public CourseForStudent(String aos_code, String acad_year, String occurrence, String student)
        {
            this.areaOfStudyCode = aos_code;
            this.academicYear = acad_year;
            this.occurrenceCode = occurrence;
            this.customisedFor = student;
            this.version = "Current";
            this.areaOfStudyTypeCode = "C";
        }
    }
}