using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trans
{
    public partial class Main_Trans : Form
    {
        public static string excel_filename;
        public static string target_filename;
        public Main_Trans()
        {
            InitializeComponent();
        }

        private void Open_Excel(object sender, EventArgs e)
        {
            OpenFileDialog open_exce_file = new OpenFileDialog();
            open_exce_file.Multiselect = true;
            open_exce_file.Title = "please choose the excel file";
            open_exce_file.Filter = "(*.xlsx)|*.xlsx";
            if (open_exce_file.ShowDialog() == DialogResult.OK)
            {

                excel_filename = open_exce_file.FileName;

                excel_path.Text = excel_filename;


            }

        }

        private void excel_path_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void target_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void target_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_target_file = new OpenFileDialog();
            open_target_file.Multiselect = true;
            open_target_file.Title = "please choose the target file";
            //open_target_file.Filter = "(*.xlsx)|*.xlsx";
            if (open_target_file.ShowDialog() == DialogResult.OK)
            {

                target_filename = open_target_file.FileName;

                target_path.Text = target_filename;
               // string filename = Path.GetFileName(target_path.Text);

            }


        }

        private void Transfer_Button_Click(object sender, EventArgs e)
        {

            Reader read = new Reader(excel_path.Text,target_path.Text);
          /*  string [] output_result = new string[2];
            output_result = read.ExcelReader(excel_path.Text);
            read.ReadAndReplace(
                output_result[0],
                output_result[1],
                target_path.Text,                    
                true
                );
            */
          
        }
    }
}
