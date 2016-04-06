using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseAPI.Models
{
    public class Course
    {
        public String areaOfStudyCode;
        public String academicYear;
        public String occurrenceCode;
        public String customisedFor;
        public String version;
        public String areaOfStudyTypeCode;
        public String parentAreaOfStudyCode;
        public String name;
        public String description;
        public String category;
        public int credits = 0;
        public String qualificationAim;
        public String facultyCode;
        public String departmentCode;
        public Date startDate;
        public Date endDate;
        public int staffId = 0;
        public String attendanceMode;
        public String jacs;

        public Course(String aos_code, String acad_year, String occurrence)
        {
            this.areaOfStudyCode = aos_code;
            this.academicYear = acad_year;
            this.occurrenceCode = occurrence;
            this.customisedFor = "Anyone";
            this.version = "Current";
            this.areaOfStudyTypeCode = "C";
        }
    }
}