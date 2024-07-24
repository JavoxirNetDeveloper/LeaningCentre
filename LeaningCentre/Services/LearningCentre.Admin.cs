using LeaningCentre.Models;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        public static void AdminPage()
        {

            LearningCentre1 learningCentre1 = GetInstance;

            bool exit1 = false;

            while (!exit1)
            {
                Console.Clear();
                Console.WriteLine("1.Courses");  //crud
                Console.WriteLine("2.Mentors"); //crud
                Console.WriteLine("3.About us"); //c
                Console.WriteLine("4.Applications");  // r
                Console.WriteLine("5.Back");  // r

                Console.Write("\nEnter an option: ");
                string choise = Console.ReadLine();

                switch (choise)
                {
                    //course
                    case "1":    /// course

                        bool exit2 = false;

                        while (!exit2)
                        {
                            Console.Clear();

                            Console.WriteLine("1.Add new course");
                            Console.WriteLine("2.Update course");
                            Console.WriteLine("3.Delette course");
                            Console.WriteLine("4.Course List");
                            Console.WriteLine("5.Back");

                            Console.Write("\nEnter option: ");
                            string optionCourse = (Console.ReadLine());

                            switch (optionCourse)
                            {
                                case "1":
                                    Console.Write("Enter Course name: ");
                                    string Cname = Console.ReadLine();
                                    learningCentre1.AddCourse(Cname);
                                    Console.WriteLine("Successfully added");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Write("Enter course id: ");
                                    int UcourseId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new course name");
                                    string NewCourseName = Console.ReadLine();
                                    learningCentre1.UpdateCourse(UcourseId, NewCourseName);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Write("Enter course id: ");
                                    int DcourseId = int.Parse(Console.ReadLine());
                                    learningCentre1.DeleteCourse(DcourseId);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    learningCentre1.GetListCourse();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
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
                    case "2":

                        bool exit3 = false;

                        while (!exit3)
                        {
                            Console.Clear();
                            Console.WriteLine("1.Add new mentor");
                            Console.WriteLine("2.Update mentor");
                            Console.WriteLine("3.Delete mentor");
                            Console.WriteLine("4.Mentor List");
                            Console.WriteLine("5.Back");

                            Console.Write("\nEnter option: ");
                            string optionMentor = (Console.ReadLine());

                            switch (optionMentor)
                            {
                                case "1":
                                    Console.Write("Enter Mentor name: ");
                                    string Mname = Console.ReadLine();
                                    learningCentre1.AddMentor(Mname);
                                    Console.WriteLine("Successfully added");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    learningCentre1.GetListMentor();
                                    Console.Write("Enter Mentor id: ");
                                    int UMentorId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new Mentor name");
                                    string NewmentorName = Console.ReadLine();
                                    learningCentre1.UpdateMentor(UMentorId, NewmentorName);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    learningCentre1.GetListMentor();
                                    Console.Write("Enter Mentor id: ");
                                    int DMentorId = int.Parse(Console.ReadLine());
                                    learningCentre1.DeleteMentor(DMentorId);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    learningCentre1.GetListMentor();
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
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
                    case "3":
                        AboutUs();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        learningCentre1.GetListApplications();
                        Console.ReadKey();
                        break;
                    case "5":
                        exit1 = true;
                        Start();
                        break;
                }
            }
        }
    }
}
