using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columbus
{
    class Pigeon
    {
        private string _yearCountry;
        private int _ringNumber;
        private Owner _owner;
        private DateTime _arrivalTime;
        private string _chip;
        private int _mark;
        private Sex _sex;

        private double _speed;
        private int _points;
        private int _position;

        public Pigeon(string yearCountry, int ringNumber, Owner owner, DateTime arrivalTime, string chip, int mark, Sex sex)
        {
            _yearCountry = yearCountry;
            _ringNumber = ringNumber;
            _owner = owner;
            _arrivalTime = arrivalTime;
            _chip = chip;
            _mark = mark;
            _sex = sex;

            _speed = CalculateSpeed();
        }

        public string YearCountry { get => _yearCountry;  }

        public int RingNumber { get => _ringNumber; }

        public Owner Owner { get => _owner; }

        public DateTime ArrivalTime { get => _arrivalTime; }

        public string Chip { get => _chip; }

        public int Mark { get => _mark; }

        public Sex Sex { get => _sex; }

        public double Speed { get => _speed;  }

        public int Points
        {
            get => _points;
            set => _points = value;
        }

        public int Position
        {
            get => _position;
            set => _position = value;
        }

        private double CalculateSpeed()
        {
            if (_arrivalTime.Year > 1)
            {
                TimeSpan time = _arrivalTime - Global.Race.StartTime;
                return Owner.Distance / (time.TotalSeconds / 60);
            } else
            {
                return 0;
            }
        }
    }
}
