using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public enum Level
    {
        low,
        medium,
        high,
    }
    public class Amulet
    {
        private string _itemId;
        private string _design;
        private Level _quality;
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }
        public Level Quality
        {
            get { return this._quality; }
            set { _quality = value; }
        }
        public Amulet() { }
        public Amulet(string itemId)
        {
            _itemId = itemId;
            Quality = Level.medium;
        }
        public Amulet(string itemId, Level quality)
        {
            _itemId = itemId;
            this.Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            this.ItemId = itemId;
            this.Design = design;
            this.Quality = quality;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";

        }
    }
}
