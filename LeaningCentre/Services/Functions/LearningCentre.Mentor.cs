using LeaningCentre.Models;
using System.Text.Json;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        //public LearningCentre1()
        //{
            
        //}
        string MentorsPath = GetMentorPath();
        public List<Mentor> Mentors;

        public void LoadMentorFromJson()
        {
            if (File.Exists(MentorsPath))
            {
                string json = string.Empty;
                using (StreamReader sr = new StreamReader(MentorsPath))
                {
                    json = sr.ReadToEnd();
                }
                Mentors = JsonSerializer.Deserialize<List<Mentor>>(json);
            }
            else
            {
                Mentors = new List<Mentor>();
            }
        }
        public void SaveMentorToJson()
        {
            string serialized = JsonSerializer.Serialize(Mentors);
            using (StreamWriter sw = new StreamWriter(MentorsPath))
            {
                sw.WriteLine(serialized);
            }
        }

        public  void AddMentor(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                int id = Mentors.Count > 0 ? Mentors.Max(s => s.Id) + 1 : 1;
                Mentors.Add(new Mentor { Id = id, Name = name });
                Console.WriteLine("Successfully added");
                SaveMentorToJson();
            }
            else
            {
                System.Console.WriteLine("Name cannot be empty");
            }
        }

        public  void UpdateMentor(int Cid, string name)
        {
            var mentor = Mentors.FirstOrDefault(s => s.Id == Cid);
            if (mentor != null)
            {
                mentor.Name = name;
                Console.WriteLine("Successfully updated");
                SaveMentorToJson();
            }
            else
            {
                Console.WriteLine("Mentor not found");
            }
        }

        public  void DeleteMentor(int Cid)
        {
            var mentor = Mentors.FirstOrDefault(s => s.Id == Cid);
            if (mentor != null)
            {
                Mentors.Remove(mentor);
                Console.WriteLine("Deleted succesfully");
            }
            else
                Console.WriteLine("Mentor not found");
            SaveMentorToJson();
        }

        public  void GetListMentor()
        {
            if (Mentors.Count > 0)
            {
                foreach (var mentor in Mentors)
                {
                    Console.WriteLine(mentor.Id + " " + mentor.Name);
                }
            }
            else
                Console.WriteLine("Mentor list is empty");
        }

        public static string GetMentorPath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\mentors.json";
            return currentPath;
        }
    }
}
