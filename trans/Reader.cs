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
                        System.Diagnostics.Trace.WriteLine(standarize(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                        ReadAndReplace(
                          //output[0],
                          //output[1],
                          reader.GetValue(0).ToString(),
                          standarize(reader.GetValue(0).ToString(),reader.GetValue(1).ToString()),
                          target_path
                          //true
                          );
                        //System.Diagnostics.Trace.WriteLine(standarize(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                    }
                }
            } while (reader.NextResult());

            stream.Close();
            //return output;



        }
        private string standarize(string standard, string data)
        {
            string s = "";
            if (standard.Contains("\"") && data.Contains("\'"))
            {

                data.Replace("\'", "\"");
            }

            if (standard.Contains("\'") && data.Contains("\""))
            {

                data.Replace("\"", "\'");
            }
            s = data;
            return s;
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

        private void ReadAndReplace(string word, string replacement, string filePath)
        {

            var fileText = "";
            string con = "";
            // int row_count = 0;
           bool value_changed = false;
            //bool sr_closed=false;

            //using (var reader = new StreamReader(filePath))
            //    fileText = reader.ReadToEnd().Replace(word,  replacement );

            //using (var writer = new StreamWriter(filePath + (overrideFile ? "" : "out")))
            //    writer.Write(fileText);

            //using (var writer = new StreamWriter(filePath))
            //    writer.Write(fileText);

            //var reader2 = new StreamReader(filePath);
            // FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader For_count = new StreamReader(filePath);
            //while(!For_count.EndOfStream)
            //{
            //    For_count.ReadLine();
            //    row_count++;
            //}
            //System.Diagnostics.Trace.WriteLine(row_count);

            string text="";
            StreamReader sr = new StreamReader(filePath);
            while ((con = sr.ReadLine())!=null)
                {                   
                
                if (con.Contains(word) && value_changed == false)
                {
                    con = con.Replace(word, replacement);
                    value_changed = true;

                }
                text += con+"\r\n";
                
            }
            sr.Close();
            using (var writer = new StreamWriter(filePath))
                writer.Write(text);
            
        }
    }
}
