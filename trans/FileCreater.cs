using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace trans
{
    class FileCreater
    {
       public FileCreater(string script_file_name)
        {
            //string full_path=Path.Combine(save_path,script_file_name);

            File.Create(script_file_name);                                
        }
     //  public 

    }
}
