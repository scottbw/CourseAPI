using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseAPI.Models
{
    public class Course
    {
       public  String areaOfStudyCode;
       public  String academicYear;
       public  String occurrenceCode;
        public String customisedFor;
        public String version;
        public Strign areaOfStudyTypeCode;

        public Course(String aos_code, String acad_year, String occurrence)
        {
            this.areaOfStudyCode = aos_code;
            this.academicYear = acad_year;
            this.occurrenceCode = occurrence;
            this.customisedFor = "Anyone";
            this.version = "Current";
        }
    }
}