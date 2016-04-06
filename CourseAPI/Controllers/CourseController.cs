using CourseAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourseAPI.Controllers
{
    public class CourseController : ApiController
    {
        // GET course/aos_code
        [Route("course/{aos_code}")]
        public IEnumerable<Course> GetCourse(String aos_code)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new Course(aos_code, null, null);
            courses.Add(course_occurrence);
            return courses;
        }

        // GET course/aos_code
        [Route("course/{aos_code}/at/{version}")]
        public IEnumerable<Course> GetCourseAtTime(String aos_code, String version)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new Course(aos_code, null, null);
            course_occurrence.version = version;
            courses.Add(course_occurrence);
            return courses;
        }

        // GET course/aos_code/acad_year
        [Route("course/{aos_code}/{acad_period}")]
        public IEnumerable<Course> GetCourseOccurenceGroup(String aos_code, String acad_period)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new Course(aos_code, acad_period, "1");
            courses.Add(course_occurrence);

            Course course_occurrence2 = new Course(aos_code, acad_period, "2");
            courses.Add(course_occurrence2);

            Course course_occurrence3 = new Course(aos_code, acad_period, "3");
            courses.Add(course_occurrence3);

            return courses;
        }

        // GET course/aos_code/acad_period/occurrence_code
        [Route("course/{aos_code}/{acad_period}/{occurrence_code}")]
        public IEnumerable<Course> GetCourseOccurrence(String aos_code, String acad_period, String occurrence_code)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new Course(aos_code, acad_period, occurrence_code);
            courses.Add(course_occurrence);
            return courses;
        }

        // GET course/aos_code/acad_period/occurrence_code/for/{student}
        [Route("course/{aos_code}/{acad_period}/{occurrence_code}/for/{student}")]
        public IEnumerable<Course> GetCourseOccurrenceForStudent(String aos_code, String acad_period, String occurrence_code, String student)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new CourseForStudent(aos_code, acad_period, occurrence_code, student);
            courses.Add(course_occurrence);
            return courses;
        }

        // GET course/aos_code/acad_period/occurrence_code/at/{time}
        [Route("course/{aos_code}/{acad_period}/{occurrence_code}/at/{time}")]
        public IEnumerable<Course> GetCourseOccurrenceAtTime(String aos_code, String acad_period, String occurrence_code, String time)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new Course(aos_code, acad_period, occurrence_code);
            course_occurrence.version = time;
            courses.Add(course_occurrence);
            return courses;
        }

        // GET course/aos_code/acad_period/occurrence_code/for/{student}/at/{time}
        [Route("course/{aos_code}/{acad_period}/{occurrence_code}/for/{student}/at/{time}")]
        public IEnumerable<Course> GetCourseOccurrenceForStudent(String aos_code, String acad_period, String occurrence_code, String student, String time)
        {
            List<Course> courses = new List<Course>();
            Course course_occurrence = new CourseForStudent(aos_code, acad_period, occurrence_code, student, time);
            course_occurrence.version = time;
            courses.Add(course_occurrence);
            return courses;
        }

    }
}
