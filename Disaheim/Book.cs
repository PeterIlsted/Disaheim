using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        //Merchandise merchandise;
        private string _title;
        private double _price;
        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public Book() { }
        public Book(string itemId)
        {
            ItemId = itemId;
        }
        public Book(string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}"; 
        }
    }
}
