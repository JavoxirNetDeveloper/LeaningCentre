using LeaningCentre.Models;
using System.Text.Json;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        private static readonly LearningCentre1 _learningCentre = new LearningCentre1();

        private LearningCentre1()
        {
            LoadCourseFromJson();
            LoadMentorFromJson();
        }
        
        public static LearningCentre1 GetInstance
        {
           get
            {
                return _learningCentre;
            } 
        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Please enter option: ");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.User");

            Console.Write("\nEnter option: ");
            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    AdminPage();
                    break;
                case "2":
                    UserPage();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    Console.ReadKey();
                    Console.Clear();
                    Start();
                    break;
            }
        }

        public static void AboutUs()
        {
            Console.WriteLine("We are the best Learning centre");
        }
    }
}
