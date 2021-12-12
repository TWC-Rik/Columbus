using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columbus
{
    class Coordinate
    {
        private double _xPos;
        private double _yPos;

        public Coordinate(string xPos, string yPos)
        {
            _xPos = DMStoDD(xPos);
            _yPos = DMStoDD(yPos);
        }

        public double X { get => _xPos; }

        public double Y { get => _yPos; }

        private double DMStoDD(string coordinate)
        {
            double degrees = Convert.ToDouble(coordinate.Substring(0, 2));
            double minutes = Convert.ToDouble(coordinate.Substring(2, 2)) / 60;
            double seconds = Convert.ToDouble(coordinate.Substring(4, 2)) / 3600;
            double decimalSeconds = Convert.ToDouble(coordinate.Substring(7, 2)) /100 / 3600;
            return degrees + minutes + seconds + decimalSeconds;
        }
    }
}
