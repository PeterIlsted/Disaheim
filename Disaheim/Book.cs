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
        public Book() : this(null) { }
        public Book(string itemId) : this(itemId, null) { }
        public Book(string itemId, string title) : this(itemId, title, 0) { }
        public Book(string itemId, string title, double price)
        {
            base.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}"; 
        }
    }
}
