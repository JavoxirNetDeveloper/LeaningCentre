using LeaningCentre.Services;

namespace LeaningCentre
{
    internal class Program
    {
        static void Main()
        {
            try 
            {
                LearningCentre1.Start();
            }
            catch (Exception ex) 
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
