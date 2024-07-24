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
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        bool exit4 = false;
                        while (!exit4)
                        {
                            Console.Clear();
                            Console.WriteLine("1.Create application");
                            Console.WriteLine("2.Application list");
                            Console.WriteLine("3.Back");

                            Console.Write("\nEnter option: ");
                            string option1 = Console.ReadLine();

                            switch(option1)
                            {
                                case "1":
                                    Console.Write("Enter your application: ");
                                    string title = Console.ReadLine();
                                    learningCentre1.AddAplication(title);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    learningCentre1.GetListApplications();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    exit4 = true;
                                    UserPage();
                                    break;
                            }
                        }
                       
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
