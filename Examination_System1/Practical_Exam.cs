using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System1
{
    internal class Practical_Exam : Quetsions, I_MCQ
    {
        public List<MCQ_Questions> mcq_Quetions = new List<MCQ_Questions>();
        public int Time { get; set; }
        int type;
        public string choice;
        int RA;
        public void Determine_Type_of_Question(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"What is the type of your {i + 1} question");
                Console.WriteLine("1-MCQ");
                type = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    MCQ_Questions mcq = new MCQ_Questions();
                    do
                    {
                       Console.WriteLine("Enter the number of choices");
                    } while (!int.TryParse(Console.ReadLine(), out mcq.numOfChoices));
                    Console.Write("Enter the Question: ");
                    mcq.Header = Console.ReadLine().ToString();
                    for (int k = 0; k < mcq.numOfChoices; k++)
                    {
                        Console.WriteLine($"Enter the {k + 1} choice: ");
                        choice = Console.ReadLine().ToString();
                        mcq.choices.Add(choice);
                    }
                    do
                    {
                       Console.Write("Which Choice is the Right enter it's number: ");
                    } while (!int.TryParse(Console.ReadLine(), out RA));
                    mcq.Right_Anwser = RA;
                    mcq_Quetions.Add(mcq);

                }

            }

        }



    }
}
