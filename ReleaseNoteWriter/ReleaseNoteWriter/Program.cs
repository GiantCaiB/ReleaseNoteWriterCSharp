using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReleaseNoteWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questions
            List<Question> questions = new List<Question>()
            {
                new Question(Const.CD_COM_NAME,Const.DES_COM_NAME),
                new Question(Const.CD_IMP_ENV,Const.DES_IMP_ENV),
                new Question(Const.CD_IMP_DLL,Const.DES_IMP_DLL),
                new Question(Const.CD_IMP_SQL,Const.DES_IMP_SQL),
                new Question(Const.CD_IMP_SCHEMA,Const.DES_IMP_SCHEMA),
                new Question(Const.CD_IMP_FLOW,Const.DES_IMP_FLOW)
            };
            if (!Directory.Exists(Const.DIR_PATH))
            {
                Directory.CreateDirectory(Const.DIR_PATH);
            }
            Note note = new Note(questions);
            System.IO.File.WriteAllText(Const.DIR_PATH + Const.FILE_NAME, note.Content);
            Console.WriteLine("Release Note can be found in {0}{1}", Const.DIR_PATH, Const.FILE_NAME);
            Process.Start(Const.DIR_PATH);
            Console.ReadKey();
        }
    }
}
