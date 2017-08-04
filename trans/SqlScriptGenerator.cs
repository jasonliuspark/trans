using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trans
{
    class SqlScriptGenerator
    {
        public SqlScriptGenerator()
        {



        }
        public string ScriptGenerator( string [] input_source )

        {
            string sqlscript = "";
            // hard coded db name
            
            string db = "miPlatform_Domain.dbo.";
            string table_name = input_source[2];
            //hard coded syntax
            string command = "update ";
            string syntax = " set " + input_source[3] + " = \'" + input_source[1] + "\'" + " where " + input_source[3] + " = \'" + input_source[0]+"\'";
            sqlscript =command + db + table_name + syntax + "\r\n";
            return sqlscript;
        }


    }
}
