using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab7_zad4
{
    class MyRoom : IRoom, IComparable, IComparer<MyRoom>
    {
        protected double length;
        protected double width;
        protected double area;
        protected int amountOfWindows;
        public MyRoom() // пустой конструктор
        {
            length = 0;
            width = 0;
            area = 0;
            amountOfWindows = 0;
        }
        
        public double Length
        {
            get { return length; } 
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public int AmountOfWindows
        {
            get { return amountOfWindows; }
            set { amountOfWindows = value; }
        }
        public int CompareTo(object o)
        {
            MyRoom myroom1 = o as MyRoom;
            return this.Area.CompareTo(myroom1.Area);
        }

        public int Compare(MyRoom myroom1, MyRoom myroom2)
        {
            if (myroom1.AmountOfWindows > myroom2.AmountOfWindows)
                return -1;
            else if (myroom1.AmountOfWindows < myroom2.AmountOfWindows)
                return 1;
            else
                return 0;
        }
    }
}
