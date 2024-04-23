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
    public class Amulet : Merchandise, IValuable
    {
        //Merchandise merchandise;
        private string _design;
        private Level _quality;
        private static double _lowQualityValue = 12.5;
        public static double LowQualityValue {  get { return _lowQualityValue; } }
        private static double _mediumQualityValue = 20.0;
        public static double MediumQualityValue { get { return _mediumQualityValue; } }
        private static double _highQualityValue = 27.5;

        public static double HighQualityValue {  get { return _highQualityValue; } }

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
        public Amulet() : this(null) { }
        public Amulet(string itemId) : this(itemId,Level.medium) { }
        public Amulet(string itemId, Level quality) : this(itemId, quality,null) { }
        public Amulet(string itemId, Level quality, string design)
        {
            base.ItemId = itemId;
            this.Design = design;
            this.Quality = quality;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";

        }
        

        public override double GetValue()
        {
            double price = 0;
            if (Quality == Level.low)
                price = Amulet.LowQualityValue;
            else if (Quality == Level.medium)
                price = Amulet.MediumQualityValue;
            else if (Quality == Level.high)
                price = Amulet.HighQualityValue;
            return price;
        }
    }
}
