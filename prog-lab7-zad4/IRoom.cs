using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab7_zad4
{
    interface IRoom
    {
        double Length { get; set; } // длина
        double Width { get; set; } // ширина
        double Area { get; } // площадь
        int AmountOfWindows { get; set; } // количество окон
    }
}
