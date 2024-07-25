namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void AdminPage()
        {
            LearningCentre1 learningCentre1 = GetInstance;
            bool exit1 = false;

            List<string> buyruq2 = new List<string>()
            {
                "Courses",
                "Mentors",
                "About us",
                "Applications",
                "Back"
            };

            while (!exit1)
            {
                //Console.Clear();
                //Console.WriteLine("\t\t\t\t\t\tADMIN");
                //Console.WriteLine("1.Courses");  //crud
                //Console.WriteLine("2.Mentors"); //crud
                //Console.WriteLine("3.About us"); //c
                //Console.WriteLine("4.Applications");  // r
                //Console.WriteLine("5.Back");  // r

                //Console.Write("\nEnter an option: ");
                //string choise = Console.ReadLine();
                int index = ArrowIndex(buyruq2, "Admin");

                switch (index)
                {
                    //course
                    case 0:    /// course

                        bool exit2 = false;
                        List<string> CoursesCommand = new List<string>()
                        {
                            "1.Add new course",
                            "2.Update course",
                            "3.Delete course",
                            "4.Course List",
                            "5.Back"
                        };

                        while (!exit2)
                        {
                            //Console.Clear();
                            //Console.WriteLine("\t\t\t\t\t\t\tADMIN");
                            //Console.WriteLine("1.Add new course");
                            //Console.WriteLine("2.Update course");
                            //Console.WriteLine("3.Delette course");
                            //Console.WriteLine("4.Course List");
                            //Console.WriteLine("5.Back");

                            //Console.Write("\nEnter option: ");
                            //string optionCourse = (Console.ReadLine());

                             int index1 = ArrowIndex(CoursesCommand, "Admin");

                            switch (index1)
                            {
                                case 0:
                                    Console.Write("Enter Course name: ");
                                    string Cname = Console.ReadLine();
                                    learningCentre1.AddCourse(Cname);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 1:
                                    learningCentre1.GetListCourse();
                                    Console.Write("Enter course id: ");
                                    int UcourseId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new course name: ");
                                    string NewCourseName = Console.ReadLine();
                                    learningCentre1.UpdateCourse(UcourseId, NewCourseName);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    learningCentre1.GetListCourse();
                                    Console.Write("Enter course id: ");
                                    int DcourseId = int.Parse(Console.ReadLine());
                                    learningCentre1.DeleteCourse(DcourseId);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    learningCentre1.GetListCourse();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    exit2 = true;
                                    AdminPage();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option , try again");
                                    break;
                            }
                        }
                        break;

                    //mentor
                    case 1:

                        bool exit3 = false;
                        List<string> MentorsCommand = new List<string>()
                        {
                            "1.Add new mentor",
                            "2.Update mentor",
                            "3.Delete mentor",
                            "4.Mentor list",
                            "5.Back"
                        };

                        while (!exit3)
                        {
                            //Console.Clear();
                            //Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tADMIN");
                            //Console.WriteLine("1.Add new mentor");
                            //Console.WriteLine("2.Update mentor");
                            //Console.WriteLine("3.Delete mentor");
                            //Console.WriteLine("4.Mentor List");
                            //Console.WriteLine("5.Back");

                            //Console.Write("\nEnter option: ");
                            //string optionMentor = (Console.ReadLine());

                        int indexMentor = ArrowIndex(MentorsCommand, "Admin");

                            switch (indexMentor)
                            {
                                case 0:
                                    Console.Write("Enter Mentor name: ");
                                    string Mname = Console.ReadLine();
                                    learningCentre1.AddMentor(Mname);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 1:
                                    learningCentre1.GetListMentor();
                                    Console.Write("Enter Mentor id: ");
                                    int UMentorId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new Mentor name");
                                    string NewmentorName = Console.ReadLine();
                                    learningCentre1.UpdateMentor(UMentorId, NewmentorName);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    learningCentre1.GetListMentor();
                                    Console.Write("Enter Mentor id: ");
                                    int DMentorId = int.Parse(Console.ReadLine());
                                    learningCentre1.DeleteMentor(DMentorId);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    learningCentre1.GetListMentor();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    exit3 = true;
                                    AdminPage();
                                    break;
                                default:
                                    Console.WriteLine("Invalid option , try again");
                                    break;
                            }
                        }
                        break;

                    /// about us
                    case 2:
                        AboutUs();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        learningCentre1.GetListApplications();
                        Console.ReadKey();
                        break;
                    case 4:
                        exit1 = true;
                        Start();
                        break;
                }
            }
        }
    }
}
