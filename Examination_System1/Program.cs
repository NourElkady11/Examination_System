using System.Diagnostics;

namespace Examination_System1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Subject s=new Subject(10,"c#");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            s.Prepare_Exam();
            Console.WriteLine($"You have Consumed {stopwatch.Elapsed} in that exam");
           
        }
    }
}
