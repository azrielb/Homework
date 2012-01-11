using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War
{
    public enum E_color : byte {Red, Blue};

    class Card : IComparable
    {
        //fields
        private E_color color;
        private int number;

        //Properties
        public E_color Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Number
        {
            get { return number; }
            set
            {
                if (2 <= value && value <= 14)
                    number = value;
            }
        }
        public string CardName // Another property of "number"
        {
            get
            {
                switch (number)
                {
                    case 11: return "Jack";
                    case 12: return "Queen";
                    case 13: return "King";
                    case 14: return "Ace";
                    default: return number.ToString();
                }
            }
        }

        //Constructor
        public Card(E_color c, int num)
        {
            color = c;
            number = num;
        }

        //Overridden functions
        public override string ToString()
        {
            return string.Format("{0} {1}", color ,CardName);
        }
        public override bool Equals(object obj)
        {
            return obj is Card ? this.number == ((Card)obj).number : false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //The class is "IComparable"...
        public int CompareTo(object obj)
        {
            if (obj is Card)
                return (Card)obj == this ? 0 : ((Card)obj < this ? -1 : 1);
            throw new NotImplementedException();
        }

        //Comparing operators
        public static bool operator ==(Card left, Card right) {
            return left.Equals(right);
        }
        public static bool operator !=(Card left, Card right)
        {
            return !(left.Equals(right));
        }
        public static bool operator <(Card left, Card right)
        {
            return left.number < right.number;
        }
        public static bool operator >(Card left, Card right)
        {
            return left.number > right.number;
        }
    }
}
