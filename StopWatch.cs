namespace Logial_Problem
{
    public class StopWatch
    {
        public static void Check()
        { 
            Console.WriteLine("Press Enter to Start.");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to Stop.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.Write("Elapsed Time = " + (Stop - Start));
        }
    }
}
