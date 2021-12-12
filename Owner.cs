using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columbus
{
    class Owner
    {
        private int _id;
        private string _name;
        private Coordinate _coordinate;
        private int _club;

        private double _distance;

        public Owner() { }

        public Owner(int id, string name, Coordinate coordinate, int club)
        {
            _id = id;
            _name = name;
            _coordinate = coordinate;
            _club = club;
        }

        public int ID { get => _id; }

        public string Name { get => _name; }

        public Coordinate Coordinate { get => _coordinate; }

        public int Club { get => _club; }

        public double Distance { get => _distance; }

        public void CalculateDistance(Coordinate location)
        {
            const double K1 = Math.PI / 180;
            const double F1 = 0.99664718933525;
            const double B1 = 6378137;
            const double E1 = 0.0067394967422767;

            double B2 = (location.X + _coordinate.X) / 2;
            double L1 = location.Y - _coordinate.Y;
            double N1 = E1 * Math.Pow(Math.Cos(B2 * K1), 2);
            double V1 = Math.Pow(1 + N1, 0.5);
            double V2 = B1 / V1;
            double L2 = L1 * V1;

            double W1 = Math.Atan(F1 * Math.Tan(location.X * K1));
            double W2 = Math.Atan(F1 * Math.Tan(_coordinate.X * K1));

            double S1 = Math.Sin(W1) * Math.Sin(W2) + Math.Cos(W1) * Math.Cos(W2) * Math.Cos(L2 * K1);
            _distance = Math.Round((Math.Atan(-S1 / Math.Sqrt(-S1 * S1 + 1)) + 2 * Math.Atan(1)) * V2, 3);
        }

        public int PigeonCount()
        {
            int pigeonCount = 0;

            foreach (Pigeon pigeon in Global.Race.Pigeons)
            {
                if (this == pigeon.Owner)
                {
                    pigeonCount++;
                }
            }

            return pigeonCount;
        }
    }
}
