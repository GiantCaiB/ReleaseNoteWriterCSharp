using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNoteWriter
{
    class Question
    {
        public Question(string desc)
        {
            Desc = desc;
        }
        public Question(string code, string desc)
        {
            Code = code;
            Desc = desc;
        }
        public string Code { get; }
        public string Desc { get; }
    }
}
