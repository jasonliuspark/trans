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

        public Reader(string excel_path, string target_path)
        {
            string[] output = new string[2];
            var stream = File.Open(excel_path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);

            do
            {
                while (reader.Read())
                {
                     
                    
                    if (reader.GetValue(0) != null && reader.GetValue(1) != null)
                    {
                        ReadAndReplace(
                          //output[0],
                          //output[1],
                           reader.GetValue(0).ToString(),
                           reader.GetValue(1).ToString(),
                          target_path,
                          true
                          );
                    }
                }
            } while (reader.NextResult());

            //return output;



        }
        private string [] ExcelReader(string excel_path)

        {
            string[] output =new string [2]; 
            var stream = File.Open(excel_path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            
            var output_test = reader.Read();
            
            output[0] = reader.GetValue(0).ToString();
            output[1] = reader.GetValue(1).ToString();

            System.Diagnostics.Trace.WriteLine(reader.GetValue(0));
            System.Diagnostics.Trace.WriteLine(reader.GetValue(1));
           
            return output;
        }

        /*public void ReadTargetFile(string target_path)

        {

            var stream2 = File.Open(target_path, FileMode.Open, FileAccess.ReadWrite);

        } */

        private void ReadAndReplace(string word, string replacement, string filePath, bool overrideFile)
        {

            var fileText = "";

            using (var reader = new StreamReader(filePath))
                fileText = reader.ReadToEnd().Replace(word,  replacement );

            using (var writer = new StreamWriter(filePath + (overrideFile ? "" : "out")))
                writer.Write(fileText);

        }
    }
}
