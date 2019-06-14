using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNoteWriter
{

    enum BoolOpt
    {
        Yes= 1,
        Y= 1,
        yes= 1,
        y= 1,
        No= 0,
        N= 0,
        no= 0,
        n= 0
    }
    static class Input
    {
        static string Ask(Question question)
        {
            Console.Write(question.Desc);
            string user_input = Console.ReadLine();
            if(question.Code == Const.CD_COM_NAME)
            {
                return user_input;
            }
            if (Enum.IsDefined(typeof(BoolOpt), user_input))
            {
                return Enum.Parse(typeof(BoolOpt), user_input).ToString();
            }
            return Const.ERROR;
        }
        public static List<string> KeepAsking(List<Question> questions)
        {
            List<string> results = new List<string>();
            for(int i=0; i< questions.Count;i++)
            {
                string result = Ask(questions[i]);
                while (result == Const.ERROR && questions[i].Code!=Const.CD_COM_NAME)
                {
                    Console.WriteLine("Invalid Input!");
                    result = Ask(questions[i]);
                }
                Console.WriteLine();
                results.Add(result);
            }
            return results;
        }
    }
}
