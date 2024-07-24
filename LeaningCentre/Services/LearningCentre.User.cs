using LeaningCentre.Models;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void UserPage()
        {
            LearningCentre1 learningCentre1 = GetInstance;
            Console.Clear();
            Console.WriteLine("1.Courses");  //r
            Console.WriteLine("2.Mentors"); //r
            Console.WriteLine("3.About us"); //r
            Console.WriteLine("4.Applications");  // crud
            Console.WriteLine("5.Back");  // r

           

            bool exitUser = false;
            while (!exitUser)
            {
                Console.Write("Enter option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        learningCentre1.GetListCourse();
                        break;
                    case "2":
                        learningCentre1.GetListMentor();
                        //GetListMentor();
                        break;
                    case "3":
                        AboutUs();
                        break;
                    case "4":

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
