using LeaningCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {

        public   string CoursesPath = GetCoursePath();
        public  List<Course> Courses;

        public List<Course> LoadCourseFromJson()
        {
            if (File.Exists(CoursesPath))
            {
                string json = string.Empty;
                using (StreamReader sr = new StreamReader(CoursesPath))
                {
                    json = sr.ReadToEnd();
                }
                Courses = JsonSerializer.Deserialize<List<Course>>(json);
            }
            else
            {
                Courses = new List<Course>();
            }
            return Courses;
        }
        public  void SaveCourseToJson()
        {
            string serialized = JsonSerializer.Serialize(Courses);
            using (StreamWriter sw = new StreamWriter(CoursesPath))
            {
                sw.WriteLine(serialized);
            }
        }
        public void AddCourse(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                int id = Courses.Count > 0 ? Courses.Max(s => s.Id) + 1 : 1;
                Courses.Add(new Course { Id = id, Name = name });
                SaveCourseToJson();
            }
            else
            {
                System.Console.WriteLine("Name cannot be empty");
            }
        }

        public  void UpdateCourse(int Cid, string name)
        {
            var course = Courses.FirstOrDefault(s => s.Id == Cid);
            if (course != null)
            {
                course.Name = name;
                Console.WriteLine("Successfully updated");
                SaveCourseToJson();
            }
            else
            {
                Console.WriteLine("Course not found");
            }
        }

        public  void DeleteCourse(int Cid)
        {
            var course = Courses.FirstOrDefault(s => s.Id == Cid);
            if (course != null)
            {
                Courses.Remove(course);
            }
            else
                Console.WriteLine("Course not found");
            SaveCourseToJson();
        }

        public  void GetListCourse()
        {
            if (Courses.Count > 0)
            {
                foreach (var course in Courses)
                {
                    Console.WriteLine(course.Id + " " + course.Name);
                }
            }
            else
                Console.WriteLine("Course list is empty");
            SaveCourseToJson();
        }

        public static string GetCoursePath()
        {
            string currentPath = Directory.GetCurrentDirectory();
            currentPath += "\\courses.json";
            return currentPath;
        }
    }
}
