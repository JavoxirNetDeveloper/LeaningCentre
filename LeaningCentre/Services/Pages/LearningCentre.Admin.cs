namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void AdminPage()
        {
            List<string> Command2 = new List<string>()
            {
                "Courses",
                "Mentors",
                "About us",
                "Applications",
                "Back"
            };

                           
            List<string> CoursesCommand = new List<string>()
            {
                "1.Add new course",
                "2.Update course",
                "3.Delete course",
                "4.Course List",
                "5.Back"
            };

            List<string> MentorsCommand = new List<string>()
            {
                "1.Add new mentor",
                "2.Update mentor",
                "3.Delete mentor",
                "4.Mentor list",
                "5.Back"
            };

            List <string> AboutUsCommand = new List<string>() 
            {
                "About Us text",
                "Add info to About Us text",
                "Update About Us text",
                "Delete About Us text",
                "Back"
            };


            const string   password = "1234";
            Console.Write("Enter password: ");
            string ? password1 = Console.ReadLine();

            if (password==password1) 
            {
                LearningCentre1 learningCentre1 = GetInstance;
                bool exit1 = false;

                AdminPage:
                while (!exit1)
                {
                    int index = ArrowIndex(Command2, "Admin");

                    switch (index)
                    {
                        //course
                        case 0:    
                            while (true)
                            {
                                int index1 = ArrowIndex(CoursesCommand, "Admin");
                                switch (index1)
                                {
                                    case 0:
                                    Console.Clear();
                                    Console.Write("Enter Course name: ");
                                    string Cname = Console.ReadLine();
                                    learningCentre1.AddCourse(Cname);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                    case 1:
                                    Console.Clear();
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
                                    Console.Clear();
                                    learningCentre1.GetListCourse();
                                    Console.Write("Enter course id: ");
                                    int DcourseId = int.Parse(Console.ReadLine());
                                    learningCentre1.DeleteCourse(DcourseId);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    learningCentre1.GetListCourse();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    goto AdminPage;
                                }
                            }

                        //mentor
                        case 1:

                            while (true)
                            {
                                int indexMentor = ArrowIndex(MentorsCommand, "Admin");

                                switch (indexMentor)
                                {
                                    case 0:
                                    Console.Clear();
                                    Console.Write("Enter Mentor name: ");
                                    string Mname = Console.ReadLine();
                                    learningCentre1.AddMentor(Mname);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                    case 1:
                                    Console.Clear();
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
                                    Console.Clear();
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
                                    goto AdminPage;
                                }
                            }

                    /// about us
                    case 2:
                        while (true) 
                        {
                            int indexAboutUs = ArrowIndex(AboutUsCommand, "Admin");

                            switch (indexAboutUs) 
                            {
                                case 0:
                                Console.Clear();
                                learningCentre1.AboutUs();
                                Console.ReadKey();
                                break;

                                case 1:
                                System.Console.Write("Enter text you want to add: ");
                                string text = Console.ReadLine();
                                learningCentre1.AddInfoAboutCentre(text);
                                Console.ReadKey();
                                break;

                                case 2:
                                System.Console.WriteLine("Enter text you want to update");
                                string textUpdate = Console.ReadLine();
                                learningCentre1.UpdateInfoAboutCenttre(textUpdate);
                                Console.ReadKey();
                                break;

                                case 3:
                                learningCentre1.DeleteInfoAboutCenttre();
                                Console.ReadKey();
                                break;

                                case 4:
                                goto AdminPage;
                            }
                        }

                       
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
            else
            {
                System.Console.WriteLine("Incorrect password");
                Console.ReadKey();
                Start();
            }
        }
    }
}
