using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DiseaseSpreadCSCI2210
{
    internal class Configuration
    {
        public double MeanPopulationSize { get; set; }
        public double StdDevPopulationSize { get; set; }
        public double DiseaseSpreadChance { get; set; }
        public double DiseaseFatalityChance { get; set; }
        public int DiseaseDurationHours { get; set; }
        public int QuarantineDurationHours { get; set; }
        public double MeanQuarantineChance { get; set; }
        public double StdDevQuarantineChance { get; set; }
        public int SimulationDurationHours { get; set; }
        public double TravelChancePerHour { get; set; }

        
        private void LoadConfiguration(string filePath)
        {
            try
            {
                // Read file contents and parse JSON to populate properties
                string json = File.ReadAllText(filePath);
                var configData = JsonSerializer.Deserialize<Configuration>(json);

                if (configData != null)
                {
                    MeanPopulationSize = configData.MeanPopulationSize;
                    StdDevPopulationSize = configData.StdDevPopulationSize;
                    DiseaseSpreadChance = configData.DiseaseSpreadChance;
                    DiseaseFatalityChance = configData.DiseaseFatalityChance;
                    DiseaseDurationHours = configData.DiseaseDurationHours;
                    QuarantineDurationHours = configData.QuarantineDurationHours;
                    MeanQuarantineChance = configData.MeanQuarantineChance;
                    StdDevQuarantineChance = configData.StdDevQuarantineChance;
                    SimulationDurationHours = configData.SimulationDurationHours;
                    TravelChancePerHour = configData.TravelChancePerHour;
                }
                else
                {
                    Console.WriteLine("Error: Configuration file is empty or invalid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading configuration file: {ex.Message}");
            }
        }

        public Configuration(string filePath)
        {
            LoadConfiguration(filePath);
        }

    }
}
