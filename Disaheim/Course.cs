using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        string _name;
        int durationInMinutes;
        public static double CourseHourValue = 875.0;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int DurationInMinutes 
        {  
            get { return durationInMinutes; } 
            set {  durationInMinutes = value; } 
        }
        public Course() : this(null) { }
        public Course(string name) : this(name,0) { }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public virtual string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            double price = 0;
            double time = 0;
            time = DurationInMinutes / 60;

            if (DurationInMinutes == null)
            {
                price = 0;
            }
            else if (DurationInMinutes % 60 >= 1)
            {
                time += 1;
                price = time * Course.CourseHourValue;
            }
            else
                price = time * Course.CourseHourValue;
            return price;
        }
    }
}
