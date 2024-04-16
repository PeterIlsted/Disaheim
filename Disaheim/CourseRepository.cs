using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Disaheim
{
    public class CourseRepository
    {
        Course course;



        private List<Course> courses;
        public List<Course> AddCourse(Course course)
        {
            courses.Add(course);
            return courses;
        }
        public Course GetCourse(string Name)
        {
            foreach (var course in courses)
            {
                if (course.Name == Name)
                {
                    return course;
                    break;
                }
            }
            return course;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (var course in courses)
            {
                value = course.GetValue();
                totalValue = totalValue + value;
            }
            return totalValue;
        }
    }
}
