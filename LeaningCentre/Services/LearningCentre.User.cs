using LeaningCentre.Models;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void UserPage()
        {
           
            bool exitUser = false;
            while (!exitUser)
            {
                LearningCentre1 learningCentre1 = GetInstance;
                Console.Clear();
                Console.WriteLine("1.Courses");  //r
                Console.WriteLine("2.Mentors"); //r
                Console.WriteLine("3.About us"); //r
                Console.WriteLine("4.Applications");  // crud
                Console.WriteLine("5.Back");  // r
                Console.Write("\nEnter option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        learningCentre1.GetListCourse();
                        Console.ReadKey();
                        //Console.Clear();
                        break;
                    case "2":
                        learningCentre1.GetListMentor();
                        Console.ReadKey();
                        //Console.Clear();
                        //GetListMentor();
                        break;
                    case "3":
                        AboutUs();
                        break;
                    case "4":
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                       // learningCentre1.AddAplication(name,);
                        break;
                    case "5":
                        exitUser = true;
                        Start();
                        break;
                }
            }
        }
    }
}
