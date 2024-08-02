using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System1
{
    internal class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        int time = 0;
        public int start;
        int ans;
        int n;
        public Subject(int id , string name) 
        { 
            this.id = id;
            this.name = name;
        }

        public void Prepare_Exam()
        {
            do
            {
                Console.WriteLine("Please enter the type of the exam you want to create ?");
                Console.WriteLine("1-Final");
                Console.WriteLine("2-Practical");
            } while (!int.TryParse(Console.ReadLine(), out start));
            do
            {
               Console.WriteLine("Please enter the time in minutes ?");
            } while (!int.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.WriteLine("How many questions do you need?");
            } while (!int.TryParse(Console.ReadLine(), out n));
            Quetsions.NumOfQuestions = n;
            if (start == 1)
            {
                Final_Exam final_Exam = new Final_Exam();
                final_Exam.Determine_Type_of_Question(Quetsions.NumOfQuestions);
                Console.Clear();
                Console.WriteLine("Lest begin our exam");
                Console.WriteLine("===============================");
                Console.WriteLine(" ");
               
                for (int i = 0; i < final_Exam.mcq_Quetions.Count; i++)
                {
                    int k = 1;
                    Console.WriteLine($"{i + 1}-{final_Exam.mcq_Quetions[i].Header} ?");
                    foreach (var j in final_Exam.mcq_Quetions[i].choices)
                    {
                        Console.Write($"{k}-{j}");
                        k++;
                        Console.Write("        ");
                        
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------");
                    ans= int.Parse(Console.ReadLine());
                    final_Exam.mcq_Quetions[i].User_Anwser =  ans;
                    if (ans==final_Exam.mcq_Quetions[i].Right_Anwser)
                    {
                        Quetsions.mark++;
                    }
                }
                for (int i = 0; i < final_Exam.True_false_Questions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-{final_Exam.True_false_Questions[i].Header}(1/0)? ");
                    Console.WriteLine("------------------------------------------------");
                    ans = int.Parse(Console.ReadLine());
                    final_Exam.True_false_Questions[i].User_Anwser = ans;
                    if (ans==final_Exam.True_false_Questions[i].Right_Anwser)
                    {
                        Quetsions.mark++;
                    }
                }
                Console.WriteLine("=================================");
                for(int i = 0; i < final_Exam.mcq_Quetions.Count; i++)
                {
                    Console.WriteLine($"{final_Exam.mcq_Quetions[i].Header} ==>You choose the {final_Exam.mcq_Quetions[i].User_Anwser} choice ==> while the right anwser is {final_Exam.mcq_Quetions[i].Right_Anwser}");
                }
                for(int i = 0; i < final_Exam.True_false_Questions.Count; i++)
                {
                    Console.WriteLine($"{final_Exam.True_false_Questions[i].Header} ==> You choose {final_Exam.True_false_Questions[i].User_Anwser} ==> while the right anwser is {final_Exam.True_false_Questions[i].Right_Anwser}");
                }
                Console.WriteLine("=================================");
                Console.WriteLine($"Your grade is {Quetsions.mark}/{Quetsions.NumOfQuestions}");

            }
            else if (start == 2)
            {
               
                Practical_Exam practical_Exam = new Practical_Exam();
                practical_Exam.Determine_Type_of_Question(Quetsions.NumOfQuestions);
                Console.Clear();
                Console.WriteLine("Lest begin our exam");
                Console.WriteLine("===============================");
                Console.WriteLine(" ");
                //final
                for (int i = 0; i < practical_Exam.mcq_Quetions.Count; i++)
                {
                    int k = 1;
                    Console.WriteLine($"{i + 1}-{practical_Exam.mcq_Quetions[i].Header} ?");
                    foreach (var j in practical_Exam.mcq_Quetions[i].choices)
                    {
                        Console.Write($"{k}-{j}");
                        k++;
                        Console.Write("        ");

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("--------------------------------------------");
                    ans = int.Parse(Console.ReadLine());
                    practical_Exam.mcq_Quetions[i].User_Anwser = ans;
                    if (ans == practical_Exam.mcq_Quetions[i].Right_Anwser)
                    {
                        Quetsions.mark++;
                    }
                }
                Console.WriteLine("=================================");
                for (int i = 0; i < practical_Exam.mcq_Quetions.Count; i++)
                {
                    Console.WriteLine($" the Question: {practical_Exam.mcq_Quetions[i].Header} ==>You chose the {practical_Exam.mcq_Quetions[i].User_Anwser} choice==> while the right anwser is {practical_Exam.mcq_Quetions[i].Right_Anwser}" );
                }
                Console.WriteLine("=================================");
                Console.WriteLine($"Your grade is {Quetsions.mark}/{Quetsions.NumOfQuestions}");
            }
            else {Console.WriteLine("Wrong input please enter (1 OR 2) in the next time i s a");}

        }


    }
}
