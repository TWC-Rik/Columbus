using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Columbus
{
    class Race
    {
        private string _raceId;
        private DateTime _startTime;
        private Coordinate _location;
        private List<Pigeon> _pigeons;

        public Race() { }

        public Race(string raceId, DateTime startTime, Coordinate location, List<Pigeon> pigeons)
        {
            _raceId = raceId;
            _startTime = startTime;
            _location = location;
            _pigeons = pigeons;
        }

        public string RaceID 
        {
            get => _raceId;
            set => _raceId = value;
        }

        public DateTime StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        public Coordinate Location
        {
            get => _location;
            set => _location = value;
        }

        public List<Pigeon> Pigeons
        {
            get => _pigeons;
            set => _pigeons = value;
        }

        public void RankPigeons()
        {
            _pigeons = _pigeons.OrderByDescending(o => o.Speed).ToList();

            double prizeCount = Math.Ceiling(Convert.ToDouble(_pigeons.Count) / 3);
            double pointStep = 470.0 / (prizeCount - 1);
            for (int i = 0; i < prizeCount; i++)
            {
                _pigeons[i].Points = Convert.ToInt32(Math.Round(500.0 - pointStep * i));
            }

            for (int i = 0; i < _pigeons.Count; i++)
            {
                _pigeons[i].Position = i + 1;
            }
        }
    }
}
