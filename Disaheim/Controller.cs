using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        Book book = new Book();
        Amulet amulet = new Amulet();
        Course course = new Course();
        public List<Book> Books;
        public List<Amulet> Amulets;
        public List<Course> Courses;
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }
        public List<Book> AddToList(Book book)
        {
            Books.Add(book);
            return Books;
        }
        public List<Amulet> AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
            return Amulets;
        }
        public List <Course> AddToList(Course course)
        {
            Courses.Add(course);
            return Courses;
        }
    }
}
