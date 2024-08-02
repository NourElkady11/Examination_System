using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System1
{
    internal class Final_Exam
    {

        public List<MCQ_Questions> mcq_Quetions = new List<MCQ_Questions>();
        public List<True_False_Questions> True_false_Questions = new List<True_False_Questions>();
        public int Time { get; set; }
        int type;
        int RA;
        int TF_RA;
        public string choice;
        public void Determine_Type_of_Question(int n)
        {
            for (int i = 0; i < n; i++)
            {
                do
                {

                    Console.WriteLine($"What is the type of your {i + 1} question");
                    Console.WriteLine("1-MCQ");
                    Console.WriteLine("2-True and false");
                } while (!int.TryParse(Console.ReadLine(), out type));
                if(type == 1)
                {
                    MCQ_Questions mcq = new MCQ_Questions();
                    do
                    {
                        Console.WriteLine("Enter the number of choices");
                    } while (!int.TryParse(Console.ReadLine(), out mcq.numOfChoices));
                    //mcq.numOfChoices = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Question: ");
                    mcq.Header = Console.ReadLine().ToString();
                    for (int k = 0; k < mcq.numOfChoices; k++)
                    {
                        Console.WriteLine($"Enter the {k+1} choice: ");
                        choice = Console.ReadLine().ToString();
                        mcq.choices.Add(choice);
                        
                    }
                   
                    do
                    {
                        Console.Write("Which Choice is the Right enter it's number: ");
                    } while (!int.TryParse(Console.ReadLine(), out RA));
                    mcq.Right_Anwser=RA;
                    mcq_Quetions.Add(mcq);




                }
                if (type == 2) 
                { 
                    True_False_Questions t_OR_F = new True_False_Questions();
                    Console.Write("Enter the Question: ");
                    t_OR_F.Header = Console.ReadLine();
                    do
                    {
                        Console.Write("Enter the Right anwser (1/0): ");
                    } while (!int.TryParse(Console.ReadLine(), out TF_RA));
                    t_OR_F.Right_Anwser = TF_RA;
                    True_false_Questions.Add(t_OR_F);



                }
            }
            
        }

            
       
    }
}