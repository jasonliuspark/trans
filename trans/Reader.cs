using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.IO;



namespace trans
{
    public class Reader
    {
        public Reader(string excel_path)

        {
            var stream = File.Open(excel_path,FileMode.Open,FileAccess.Read) ;
            var reader = ExcelReaderFactory.CreateReader(stream);
            var reader.AsDataSet();

            //result.Tables.
            


        }


    }
}
