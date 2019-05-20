using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab7_zad4
{
    class ClassRoom : MyRoom, IRoom, IComparable, IComparer <ClassRoom>
    {
        private int amountOfTables;
        public int AmountOfTables
        {
            get { return amountOfTables; }
            set { amountOfTables = value; }
        }

        public new int CompareTo(object o)
        {
            ClassRoom myroom1 = o as ClassRoom;
            return this.Area.CompareTo(myroom1.Area);
        }

        public int Compare(ClassRoom myroom1, ClassRoom myroom2)
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
