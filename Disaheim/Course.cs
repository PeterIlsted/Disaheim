using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course //:Merchandise
    {
        string _name;
        int durationInMinutes;
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
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
