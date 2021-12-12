using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Columbus
{
    class UDP
    {
        private string _path;
        private string[] _allLines;
        private List<Owner> _owners;

        public UDP(string path)
        {
            _path = path;

            if (_path != "")
                _allLines = System.IO.File.ReadAllLines(_path);
        }

        private string GetRaceInfo()
        {
            string id = _allLines[0].Substring(17, 2).Trim();
            string name = _allLines[0].Substring(19, 40).Trim();
            string code = _allLines[0].Substring(93, 8).Trim();

            return $"{id} {name}, ({code})";
        }

        private DateTime GetRaceStart()
        {
            int year = Convert.ToInt32($"20{_allLines[0].Substring(9, 2)}");
            int month = Convert.ToInt32(_allLines[0].Substring(7, 2));
            int day = Convert.ToInt32(_allLines[0].Substring(5, 2));
            int hour = Convert.ToInt32(_allLines[0].Substring(11, 2));
            int minute = Convert.ToInt32(_allLines[0].Substring(13, 2));
            int second = Convert.ToInt32(_allLines[0].Substring(15, 2));

            return new DateTime(year, month, day, hour, minute, second);
        }

        private Coordinate GetRaceCoordinate()
        {
            string xPos = _allLines[0].Substring(74, 9);
            string yPos = _allLines[0].Substring(84, 9);
            return new Coordinate(xPos, yPos);
        }

        private DateTime GetPigeonArrival(int i)
        {
            int year = Convert.ToInt32($"20{_allLines[0].Substring(9, 2)}");
            int month = Convert.ToInt32(_allLines[i].Substring(54, 2));
            int day = Convert.ToInt32(_allLines[i].Substring(52, 2));
            int hour = Convert.ToInt32(_allLines[i].Substring(56, 2));
            int minute = Convert.ToInt32(_allLines[i].Substring(58, 2));
            int second = Convert.ToInt32(_allLines[i].Substring(60, 2));

            return new DateTime(year, month, day, hour, minute, second);
        }

        private Sex GetPigeonSex(string indicator)
        {
            switch (indicator)
            {
                case "M": return Sex.MALE;
                case "V": return Sex.FEMALE;
                default: return Sex.UNKNOWN;
            }
        }

        private List<Pigeon> GetRacePigeons()
        {
            List<Pigeon> pigeons = new List<Pigeon>();

            for (int i = 0; i < _allLines.Length; i++)
            {
                if (_allLines[i].Substring(0, 3) == "407")
                {
                    string yearCountry = $"{_allLines[i].Substring(16, 2)}{_allLines[i].Substring(20, 2)}";
                    int ringNumber = Convert.ToInt32(_allLines[i].Substring(25, 7));

                    Owner owner = new Owner();
                    foreach (Owner testOwner in _owners)
                    {
                        int ownerId = Convert.ToInt32(_allLines[i].Substring(7, 8));
                        if (ownerId == testOwner.ID)
                        {
                            owner = testOwner;
                            break;
                        }
                    }

                    DateTime arrivalTime;
                    if (_allLines[i].Substring(48, 1) == "1")
                    {
                        arrivalTime = GetPigeonArrival(i);
                    } else
                    {
                        arrivalTime = new DateTime();
                    }
                    string chip = _allLines[i].Substring(109, 7);
                    int mark = Convert.ToInt32(_allLines[i].Substring(32, 3));
                    Sex sex = GetPigeonSex(_allLines[i].Substring(15, 1));

                    pigeons.Add(new Pigeon(yearCountry, ringNumber, owner, arrivalTime, chip, mark, sex));
                }
            }

            return pigeons;
        }

        public Race GetRace()
        {
            Race race = new Race();
            Global.Race = race;

            race.RaceID = GetRaceInfo();
            race.StartTime = GetRaceStart();
            race.Location = GetRaceCoordinate();
            race.Pigeons = GetRacePigeons();
            return race;
        }

        public List<Owner> GetOwners()
        {
            List<Owner> owners = new List<Owner>();

            for (int i = 0; i < _allLines.Length; i++)
            {
                if (_allLines[i].Substring(0, 3) == "107")
                {
                    int id = Convert.ToInt32(_allLines[i].Substring(7, 8));
                    string name = _allLines[i].Substring(50, 20).Trim();

                    string xPos = _allLines[i].Substring(30, 9);
                    string yPos = _allLines[i].Substring(40, 9);
                    Coordinate coordinate = new Coordinate(xPos, yPos);

                    int club = Convert.ToInt32(_allLines[i].Substring(3, 4));

                    Owner owner = new Owner(id, name, coordinate, club);
                    owner.CalculateDistance(GetRaceCoordinate());
                    owners.Add(owner);
                }
            }

            _owners = owners;
            return owners;
        }
    }
}
