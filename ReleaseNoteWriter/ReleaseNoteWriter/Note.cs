using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNoteWriter
{
    class Note
    {
        
        string content_title = "COMPANY ID: ";
        string content_impact = "\nImpact Assessment\n=================\n";
        string content_install = "\n\nInstall Instructions\n====================\n"
                               + "Select the target environment.\n" 
                               + "Backup the files.\n" 
                               + "Deploy the files from the release folder to the target environment.\n";
        string content_rollback = "\n\nRollback Instructions\n=====================\n" 
                                + "Select the target environment.\n" 
                                + "Restore backup of files from the backups folder to the target environment.\n";
        string content_testing = "\n\nTesting\n=======\n"
                               + "Testing occurred in test environment.\n"
                               + "Test plan available in the release folder.\n";
        string content;
        public Note(List<Question> questions)
        {
            List<string> answers = Input.KeepAsking(questions);
            for(int i=0; i<questions.Count;i++)
            {
                switch (questions[i].Code)
                {
                    case Const.CD_COM_NAME:
                        content_title += answers[i]+"\n";
                        break;
                    case Const.CD_IMP_DLL:
                        if (answers[i].Equals("Yes"))
                        {
                            content_impact += "DLL File.\n";
                        }
                        else
                            content_impact += "There is NO DLL involved.\n";
                        break;
                    case Const.CD_IMP_SQL:
                        if (answers[i].Equals("Yes"))
                        {
                            content_impact += "SQL updated.\n";
                            content_install += "Run the SQL scripts in the release folder.\n";
                            content_rollback += "Run the Rollback SQL scripts in the release folder.\n";
                        }
                        else
                            content_impact += "There is NO SQL involved.\n";
                        break;
                    case Const.CD_IMP_SCHEMA:
                        if (answers[i].Equals("Yes"))
                        {
                            content_impact += "Schema File.\n";
                        }
                        else
                            content_impact += "No schema changed.\n";
                        break;
                    case Const.CD_IMP_FLOW:
                        if (answers[i].Equals("Yes"))
                        {
                            content_impact += "Flow change.\n";
                            content_install += "Download flow in the target environment as backup.\n"
                                             + "Migrate the flow in the release folder to the target environment.\n"
                                             + "Refresh the flow.\n";
                            content_rollback += "Run the Rollback SQL scripts in the release folder.\n"
                                             +"Refresh the flow.\n";
                        }
                        else
                            content_impact += "No flow change.\n";
                        break;
                    default:
                        break;
                }

            }
            content = content_title + content_impact + content_install + content_rollback + content_testing;
        }
        public string Content
        {
            get
            {
                return content;
            }
        }
    }
}
