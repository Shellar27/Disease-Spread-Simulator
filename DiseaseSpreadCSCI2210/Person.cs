using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseSpreadCSCI2210
{
    internal class Person
    {
        public string Id { get; set; }
        public int TravelStartTime { get; set; }
        public int TravelEndTime { get; set; }
        public bool IsInfected { get; set; }
        public int InfectionCount { get; set; }
        public int InfectionSpreadCount { get; set; }
        public bool IsDead { get; set; }
        public bool IsQuarantined { get; set; }
        public double QuarantineChance { get; set; }

        public Person(string id, int travelStartTime, int travelEndTime, double quarantineMean, double quarantineStdDev, Random random)
        {
            Id = Guid.NewGuid().ToString();
            TravelStartTime = new Random().Next(travelStartTime);
            TravelEndTime = TravelStartTime + 15;
            IsInfected = false;
            InfectionCount = 0;
            InfectionSpreadCount = 0;
            IsDead = false;
            IsQuarantined = false;
            QuarantineChance = random.NextDouble();
        }

    }
}
