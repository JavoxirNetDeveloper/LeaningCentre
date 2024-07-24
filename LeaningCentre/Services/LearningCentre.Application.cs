using LeaningCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeaningCentre.Services
{
    public partial class LearningCentre1
    {
        string ApplicationPath = GetApplicationPath();
        List<Application1> Applications;
        public void LoadApplicationFromJson()
        {
            if (File.Exists(ApplicationPath))
            {
                string json = string.Empty;
                using (StreamReader sr = new StreamReader(ApplicationPath))
                {
                    json = sr.ReadToEnd();
                }
                Applications = JsonSerializer.Deserialize<List<Application1>>(json);
            }
            else
            {
                Mentors = new List<Mentor>();
            }
        }
        public void SaveApplicationToJson()
        {
            string serialized = JsonSerializer.Serialize(Applications);
            using (StreamWriter sw = new StreamWriter(ApplicationPath))
            {
                sw.WriteLine(serialized);
            }
        }


        public void AddAplication(string name, Course course)
        {
            int id = Applications.Count > 0 ? Applications.Max(s => s.Id) + 1 : 1;
           // if (!IsNullOrEmpty(name))
        }

        public static string GetApplicationPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\applications.json";
            return currentPath;
        }
    }
}
