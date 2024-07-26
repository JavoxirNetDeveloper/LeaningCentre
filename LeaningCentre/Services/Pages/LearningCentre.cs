using System.Xml.Linq;

namespace LeaningCentre.Services
{
    public sealed partial class LearningCentre1
    {
        private static readonly LearningCentre1 _learningCentre = new LearningCentre1();

        private LearningCentre1()
        {
            LoadCourseFromJson();
            LoadMentorFromJson();
            LoadApplicationFromJson();
            LoadTextfromJson();
        }

        public static LearningCentre1 GetInstance
        {
            get
            {
                return _learningCentre;
            }
        }

        public static int ArrowIndex(List<string> buyruqlar, string name)
        {
            int selectIndex = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" +name);
                for (int i = 0; i < buyruqlar.Count; i++)
                {
                    if (i == selectIndex)
                    {
                       // Console.WriteLine($">>>> {buyruqlar[i]}");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    
                    Console.WriteLine($"{buyruqlar[i]}");
                    Console.ResetColor();
                }

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.UpArrow) selectIndex = (selectIndex - 1 + buyruqlar.Count) % buyruqlar.Count;
                else if (consoleKeyInfo.Key == ConsoleKey.DownArrow) selectIndex = (selectIndex + 1) % buyruqlar.Count;
                else if (consoleKeyInfo.Key == ConsoleKey.Enter) return selectIndex;
            }
        }

        public static List<string> buyruq1 = new List<string>()
         {
             "Admin",
             "User"
         };
        
        public static void Start()
        {
           int index = ArrowIndex(buyruq1, "");
            Console.Clear();

          ///  Console.WriteLine("Please enter option: ");


           

            //Console.Write("\nEnter option: ");
            //string choise = Console.ReadLine();

            switch (index)
            {
                case 0:
                    AdminPage();
                    break;
                case 1:
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

       
    }
}
