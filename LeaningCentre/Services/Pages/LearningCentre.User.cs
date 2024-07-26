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

            List<string> ApplicationCommand = new List<string>()
            {
                "1.Create application",
                "2.Application list",
                "3.Back"
            };
            
            while (true)
            {
                LearningCentre1 learningCentre1 = GetInstance;
                int indexUser = ArrowIndex(UserCommand, "User");


                switch (indexUser)
                {
                    case 0:
                        Console.Clear();
                        learningCentre1.GetListCourse();
                        Console.ReadKey();
                        //Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        learningCentre1.GetListMentor();
                        Console.ReadKey();
                        //Console.Clear();
                        //GetListMentor();
                        break;
                    case 2:
                        Console.Clear();
                        learningCentre1.AboutUs();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        while (true)
                        {
                            int indexApplications = ArrowIndex(ApplicationCommand, "User");
                       

                            switch (indexApplications)
                            {
                                case 0:
                                    Console.Clear();
                                    Console.Write("Enter your application: ");
                                    string title = Console.ReadLine();
                                    learningCentre1.AddAplication(title);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 1:
                                    Console.Clear();
                                    learningCentre1.GetListApplications();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    UserPage();
                                    break;
                            }
                        }
                        // learningCentre1.AddAplication(name,);
                    case 4:
                        Start();
                        break;
                }
            }
        }
    }
}
