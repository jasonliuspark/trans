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

       public Reader()

        {



        }
        public Reader(string excel_path, string target_path)
        {
           // string[] output = new string[2];
            var stream = File.Open(excel_path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);      
            do
            {
                while (reader.Read())
                {
                     
                    
                    if (reader.GetValue(0) != null && reader.GetValue(1) != null)
                    {
                       string old_value = reader.GetValue(0).ToString();
                       string new_value = standarize_pattern( reader.GetValue(1).ToString());
                       // System.Diagnostics.Trace.WriteLine(standarize(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                        ReadAndReplace(
                         //output[0],
                         //output[1],
                         old_value,
                       standarize( old_value, new_value),
                       //  standarize(old_value,new_value),
                        // reader.GetValue(0).ToString(),
                         //reader.GetValue(1).ToString(),
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
        public Reader(string excel_path, string target_path,string type)
        {

            var stream = File.Open(excel_path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            do
            {
                while (reader.Read())
                {


                    if (reader.GetValue(0) != null && reader.GetValue(1) != null)
                    {
                        string old_value = non_quo_standerize( type,reader.GetValue(0).ToString());
                        string new_value = non_quo_standerize( type,reader.GetValue(1).ToString());
                        // System.Diagnostics.Trace.WriteLine(standarize(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                        ReadAndReplace(
                         //output[0],
                         //output[1],
                         old_value,
                         new_value,
                          //  standarize(old_value,new_value),
                          // reader.GetValue(0).ToString(),
                          //reader.GetValue(1).ToString(),
                          target_path
                          //true
                          );
                        //System.Diagnostics.Trace.WriteLine(standarize(reader.GetValue(0).ToString(), reader.GetValue(1).ToString()));
                    }
                }
            } while (reader.NextResult());

            stream.Close();


        }
        private string standarize_pattern(string quo)
        {
            string buffer = quo.Trim();

            if (buffer!=""&&buffer.Substring(0, 1) != "\'")
            //string buffer = quo.Trim();
            {
                if (buffer.Contains("\'"))
                { buffer = buffer.Insert(0, " \'"); }
                buffer = buffer.Insert(0," ");
            }
            else
            {
                buffer = buffer.Insert(0, " ");
            }

            return buffer;
        }
        private string standarize(string standard, string data)
        {
            string s = data;
            if (standard.Contains("\"") && data.Contains("\'"))
            {

               s= data.Replace("\'", "\"");
            }

            if (standard.Contains("\'") && data.Contains("\""))
            {
               
               s= data.Replace("\"", "\'");
            }
            
            return s;
        }
        /// <summary>
        /// quotation standarize
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>

        private string non_quo_standerize(string type, string data)

        {
            switch (type)
            {
                case "\'":
                    {   
                        data = data.Trim();
                        int index = data.Count();
                        data = data.Insert(0,"\'");
                        data = data.Insert(index+1, "\'");
                        break;
                    }  
                case "\"":
                    {
                        data = data.Trim();
                        int index = data.Count();
                        data = data.Insert(0,"\"");
                        data = data.Insert(index+1,"\"");
                        break;
                    } 
            }
            return data;

        }

        /// <summary>
        /// script writer
        /// </summary>
        /// <param name="script_file"></param>
        /// <param name="excel_path"></param>
        public void ExcelReader(string script_file,string excel_path)

        {
            
             
            var stream = File.Open(excel_path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var script_generater = new SqlScriptGenerator();
            do
            {
                while (reader.Read())
                {
                    string[] output =new string [4];
                    string sheet_name = reader.Name;
                    string sql_script = "";
                    string[] sArray = sheet_name.Split('.');
                    // get original string and translated source
                    output[0] = reader.GetValue(0).ToString();
                    output[1] = reader.GetValue(1).ToString();
                    //split sheet name to table name and column name
                    output[2] = sArray[0];
                    if (sArray[1] == "Descriptio")
                    { sArray[1] = sArray[1] + "n"; }
                    output[3] = sArray[1];
                    System.Diagnostics.Trace.WriteLine(sArray[0]);
                    System.Diagnostics.Trace.WriteLine(sArray[1]);
                    SqlScriptGenerator sq_gen = new SqlScriptGenerator();
                    sql_script=sq_gen.ScriptGenerator(output);
                    TextWriter tw = new StreamWriter(script_file,true);
                    tw.WriteLine(sql_script);
                    tw.Close();

                }
            } while (reader.NextResult());

            stream.Close();
        }

        

        private void ReadAndReplace(string word, string replacement, string filePath)
        {

            var fileText = "";
            string con = "";
            // int row_count = 0;
            //bool value_changed = false;
            //bool sr_closed=false;
            //int w_count = word.Count();
            //using (var reader = new StreamReader(filePath))
             //fileText = reader.ReadToEnd().Replace(word, replacement);

            //using (var writer = new StreamWriter(filePath + (overrideFile ? "" : "out")))
               // writer.Write(fileText);

           // using (var writer = new StreamWriter(filePath))
               // writer.Write(fileText);

            //var reader2 = new StreamReader(filePath);
            // FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //StreamReader For_count = new StreamReader(filePath);
            //while(!For_count.EndOfStream)
            //{
            //    For_count.ReadLine();
            //    row_count++;
            //}
            //System.Diagnostics.Trace.WriteLine(row_count);

            //string text="";
            int w_count = word.Count();
           // int r_count = replacement.Count();
            StreamReader sr = new StreamReader(filePath);
            //while ((con = sr.ReadLine())!=null)
            //{                   
                con = sr.ReadToEnd();
                if (con.Contains(word))
                {
                   int con_index= con.IndexOf(word);
            //        con = con.Replace(word, replacement);
                    con = con.Remove(con_index,w_count);
                    con = con.Insert(con_index,replacement);
                    //value_changed = true;

               }
                
                
            //}
            sr.Close();
            using (var writer = new StreamWriter(filePath))
                writer.Write(con);
            
        }
    }
}
