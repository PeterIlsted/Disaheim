using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            double price = 0;
            if (book.Price != 0)
            {
                price = book.Price;
            }
            return price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            double price = 0;
            if (amulet.Quality == Level.low)
                price = 12.5;
            if (amulet.Quality == Level.medium)
                price = 20.0;
            if (amulet.Quality == Level.high)
                price = 27.5;
            return price;
        }
        public double GetValueOfCourse(Course course)
        {
            double price = 0;
            double time = 0;
            time = course.DurationInMinutes / 60;

            if (course.DurationInMinutes == null)
            {
                price = 0;
            }
            else if (course.DurationInMinutes % 60 > 1)
            {
                time = time + 1;
                price = time * 875.00;
            }
            else
                price = time * 875.00;
            return price;
        }
    }
}
