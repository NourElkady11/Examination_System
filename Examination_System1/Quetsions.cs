using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System1
{
    internal abstract class Quetsions
    {
        public string Header { get; set; }
        public static int mark { get; set; }
        public static int NumOfQuestions { get; set; }
        public int Right_Anwser { set; get; }
        public int User_Anwser { set; get; }


    }
}
