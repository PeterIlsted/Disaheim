using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        StreamReader sr;
        StreamWriter sw;
        private string docPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        List<IValuable> valuables = new List<IValuable>();
        Course course;
        Amulet amulet;
        Book book;
        Level level;
        public IValuable AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
            return valuable;
        }
        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merchandise)
                {
                    if (merchandise.ItemId == id) 
                        return valuable; 
                }
                else if (valuable is Course course)
                {
                    if (course.Name == id)
                        return valuable; 
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double value = 0;
            double totalValue = 0;
            foreach (var valuable in valuables)
            {
                value = valuable.GetValue();
                totalValue = totalValue + value;
            }
            return totalValue;
        }
        public int Count()
        {
            int count = 0;
            count = valuables.Count;
            return count;
        }

        public void Save()
        {
            using (sw = new StreamWriter(Path.Combine(docPath, "ValuableRepository.txt;"), false))
            {
                foreach (IValuable valuable in valuables)
                {
                    if (valuable is Merchandise merchandise)
                    {
                        sw.WriteLine(merchandise.ToString());
                    }
                    else if (valuable is Course course)
                    {
                        sw.WriteLine(course.ToString());
                    }
                }
            }
        }

        public void Save(string fileName)
        {
            using (sw = new StreamWriter(Path.Combine(docPath, fileName), false))
            {
                foreach (IValuable valuable in valuables)
                {
                    if (valuable is Merchandise merchandise)
                    {
                        sw.WriteLine(merchandise.ToString());
                    }
                    else if (valuable is Course course)
                    {
                        sw.WriteLine(course.ToString());
                    }
                }
            }
        }

        public List<IValuable> Load()
        {
            string line = " ";
            using (sr = new StreamReader(Path.Combine(docPath, "ValuableRepository.txt;"))) 
            {
                while(sr.ReadLine != null)
                {
                    string s1, s2;
                    int duration;
                    double price;
                    Level quality;
                    string[] splitKolon;
                    string[] splitComma = sr.ReadLine().Split(",");
                    if (splitComma[0].Contains("ItemId:"))
                    {
                        splitKolon = splitComma[0].Split(":");
                        s1 = splitKolon[1];
                        if (splitComma[1].Contains("Quality:"))
                        {
                            splitKolon = splitComma[1].Split(":");
                            Enum.TryParse(splitKolon[1], out quality);
                            splitKolon = splitComma[2].Split(":");
                            s2 = splitKolon[1];
                            amulet = new Amulet(s1, quality, s2);
                            this.valuables.Add(amulet);
                        }
                        else
                        {
                            splitKolon = splitComma[1].Split(":");
                            s2 = splitKolon[1];
                            splitKolon = splitComma[2].Split(":");
                            double.TryParse(splitKolon[1], out price);
                            book = new Book(s1, s2, price);
                            this.valuables.Add(book);
                        }
                    }
                    else
                    {
                        splitKolon = splitComma[0].Split(":");
                        s1 = splitKolon[1];
                        splitKolon = splitComma[1].Split(":");
                        Int32.TryParse(splitKolon[1], out duration);
                        course = new Course(s1, duration);
                        this.valuables.Add(course);
                    }
                }
                return this.valuables;
            }
        }

        public List<IValuable> Load(string fileName)
        {
            string line = " ";
            using (sr = new StreamReader(Path.Combine(docPath, fileName)))
            {
                while (sr.ReadLine != null)
                {
                    level = 0;
                    string s1, s2, s3;
                    int i1;
                    double d1;
                    line = sr.ReadLine();
                    string[] firstSplit = line.Split(",");
                    if (firstSplit[0].Contains("Name:"))
                    {
                        string[] name = firstSplit[0].Split(":");
                        s1 = name[1];
                        string[] min = firstSplit[1].Split(":");
                        int minute = 0;
                        if (min[1] != null)
                        {
                            Int32.TryParse(min[1], out minute);
                        }
                        course = new Course(s1, minute);
                        AddValuable(course);
                    }
                    else
                    {
                        string[] strings = firstSplit[0].Split(":");
                        s1 = strings[1];
                        if (firstSplit[1].Contains("Quality:"))
                        {
                            strings = firstSplit[1].Split(':');
                            Enum.TryParse(strings[1], out level);
                            strings = firstSplit[2].Split(":");
                            if (strings[1] != null)
                                s2 = strings[1];
                            else s2 = null;
                            amulet = new Amulet(s1, level, s2);
                            AddValuable(amulet);
                        }
                        else if (firstSplit[1].Contains("Title:"))
                        {
                            strings = firstSplit[1].Split(":");
                            if (strings[1] != null)
                                s2 = strings[1];
                            else
                                s2 = null;
                            strings = firstSplit[2].Split(":");
                            if (strings[1] != null)
                                double.TryParse(strings[1], out d1);
                            else d1 = 0;
                            book = new Book(s1, s2, d1);
                            AddValuable(book);
                        }
                    }
                }
                return this.valuables;
            }
        }
    }
}
