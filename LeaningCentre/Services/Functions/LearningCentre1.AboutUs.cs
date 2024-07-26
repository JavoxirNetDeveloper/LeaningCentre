using System.Globalization;
using System.Text.Json;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public string GetAboutUsPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\AboutUsText.Json";
            return currentPath;
        }

        public void LoadTextfromJson ()
        {
            if (File.Exists(GetAboutUsPath()))
            {
                string json = string.Empty;
                using (StreamReader sr = new StreamReader(GetAboutUsPath()))
                {
                    json = sr.ReadToEnd();
                }
                InfoAboutCentre = JsonSerializer.Deserialize<string>(json);
            }
            else
            {
                InfoAboutCentre = "";
            }
        }

        public void SaveTextToJson()
        {
            string searilized = JsonSerializer.Serialize<string>(InfoAboutCentre);
            using(StreamWriter sw = new StreamWriter(GetAboutUsPath()))
            {
               sw.WriteLine(searilized);
            }
        }
        string InfoAboutCentre =  "We are the best Learning centre";

        public  void AddInfoAboutCentre(string info) 
        {
             if (!string.IsNullOrEmpty(info)) 
             {
                InfoAboutCentre = InfoAboutCentre + " " + info;
             }
             System.Console.WriteLine("Successfully added");
            SaveTextToJson();
        }

        public  void UpdateInfoAboutCenttre(string UpdateInfo) 
        {
             if (!string.IsNullOrEmpty(UpdateInfo)) 
             {
                InfoAboutCentre = UpdateInfo;
             }
             System.Console.WriteLine("Successfully updated");
            SaveTextToJson();
        }

        public  void DeleteInfoAboutCenttre() 
        {
            InfoAboutCentre = "";
            System.Console.WriteLine("Successfully deleted");
            SaveTextToJson();
        }

        public  void AboutUs()
        {
            if (!string.IsNullOrEmpty(InfoAboutCentre)) 
            {
                Console.WriteLine(InfoAboutCentre);
            }
            else 
            {
                System.Console.WriteLine("No information yet");
            }
        }
    }
}