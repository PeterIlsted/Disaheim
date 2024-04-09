using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        private string _itemId;
        private string _title;
        private double _price;
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
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
        public Book(string itemId)
        {
            _itemId = itemId;
        }
        public Book(string itemId, string title)
        {
            _itemId = itemId;
            _title = title;
        }
        public Book(string itemId, string title, double price)
        {
            _itemId = itemId;
            _title = title;
            _price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}"; 
        }
    }
}
