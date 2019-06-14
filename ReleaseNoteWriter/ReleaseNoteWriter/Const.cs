using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNoteWriter
{
    static class Const
    {
        // Store Path and File Name
        public const string DIR_PATH = @"C:\Users\Public\ReleaseNoteWriter";
        public const string FILE_NAME = @"\ReleaseNote.txt";
        // Questions Code and Description
        public const string CD_COM_NAME = "COM_NAME";
        public const string DES_COM_NAME = "Enter the company ID:";
        public const string CD_IMP_ENV = "IMP_ENV";
        public const string DES_IMP_ENV = "Down time of environments?(Yes/No)";
        public const string CD_IMP_DLL = "IMP_DLL";
        public const string DES_IMP_DLL = "DLL update?(Yes/No)";
        public const string CD_IMP_SQL = "IMP_SQL";
        public const string DES_IMP_SQL = "SQL update?(Yes/No)";
        public const string CD_IMP_SCHEMA = "IMP_SCHEMA";
        public const string DES_IMP_SCHEMA = "Schema update?(Yes/No)";
        public const string CD_IMP_FLOW = "IMP_FLOW";
        public const string DES_IMP_FLOW = "Flow changed?(Yes/No)";
        // Other Constants
        public const string ERROR = "ERROR";
    }
}
