namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void UserPage()
        {
            List<string> UserCommand = new List<string>()
            {
                "Courses",
                "Mentors",
                "About us",
                "Applications",
                "Back"
            };
            bool exitUser = false;


            while (!exitUser)
            {
                LearningCentre1 learningCentre1 = GetInstance;
                int indexUser = ArrowIndex(UserCommand, "User");

                //Console.Clear();
                //Console.WriteLine("\t\t\t\t\t\t\t\tUSER");
                //Console.WriteLine("1.Courses");  //r
                //Console.WriteLine("2.Mentors"); //r
                //Console.WriteLine("3.About us"); //r
                //Console.WriteLine("4.Applications");  // crud
                //Console.WriteLine("5.Back");  // r

                //Console.Write("\nEnter option: ");
                //string option = Console.ReadLine();

                switch (indexUser)
                {
                    case 0:
                        learningCentre1.GetListCourse();
                        Console.ReadKey();
                        //Console.Clear();
                        break;
                    case 1:
                        learningCentre1.GetListMentor();
                        Console.ReadKey();
                        //Console.Clear();
                        //GetListMentor();
                        break;
                    case 2:
                        AboutUs();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        bool exit4 = false;
                        List<string> ApplicationCommand = new List<string>()
                        {
                            "1.Create application",
                            "2.Application list",
                            "3.Back"
                        };
                        while (!exit4)
                        {
                            int indexApplications = ArrowIndex(ApplicationCommand, "User");
                            //Console.Clear();
                            //Console.WriteLine("\t\t\t\t\t\t\t\tUSER");
                            //Console.WriteLine("1.Create application");
                            //Console.WriteLine("2.Application list");
                            //Console.WriteLine("3.Back");

                            //Console.Write("\nEnter option: ");
                            //string option1 = Console.ReadLine();

                            switch (indexApplications)
                            {
                                case 0:
                                    Console.Write("Enter your application: ");
                                    string title = Console.ReadLine();
                                    learningCentre1.AddAplication(title);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 1:
                                    learningCentre1.GetListApplications();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    exit4 = true;
                                    UserPage();
                                    break;
                            }
                        }

                        // learningCentre1.AddAplication(name,);
                        break;
                    case 4:
                        exitUser = true;
                        Start();
                        break;
                }
            }
        }
    }
}
