using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public static class Utility
    {
        private static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;
        public static double CourseHourValue = 875.0;
        //public static double GetValueOfBook(Book book)
        //{
        //    double price = 0;
        //    if (book.Price != 0)
        //    {
        //        price = book.Price;
        //    }
        //    return price;
        //}
        //public static double GetValueOfAmulet(Amulet amulet)
        //{
        //    double price = 0;
        //    if (amulet.Quality == Level.low)
        //        price = 12.5;
        //    if (amulet.Quality == Level.medium)
        //        price = 20.0;
        //    if (amulet.Quality == Level.high)
        //        price = 27.5;
        //    return price;
        //}
        public static double GetValueOfCourse(Course course)
        {
            double price = 0;
            double time = 0;
            time = course.DurationInMinutes / 60;

            if (course.DurationInMinutes == null)
            {
                price = 0;
            }
            else if (course.DurationInMinutes % 60 >= 1)
            {
                time = time + 1;
                price = time * CourseHourValue;
            }
            else
                price = time * CourseHourValue;
            return price;
        }
        public static double GetValueOfMerchandise(Merchandise merchandise) 
        {
            double price = 0;
            return price; 
        }
        public static double GetValueOfMerchandise(Amulet amulet)
        {
            double price = 0;
            if (amulet.Quality == Level.low)
                price = LowQualityValue;
            else if(amulet.Quality == Level.medium)
                price = MediumQualityValue;
            else if (amulet.Quality == Level.high)
                price = HighQualityValue;
            return price;
        }
        public static double GetValueOfMerchandise(Book book)
        {
            double price = 0;
            if (book.Price != 0)
            {
                price = book.Price;
            }
            return price;
        }
    }
}
