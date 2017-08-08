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

                Excel_path.Text = excel_filename;


            }

        }

        private void Excel_path_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Target_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void Target_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_target_file = new OpenFileDialog();
            open_target_file.Multiselect = true;
            open_target_file.Title = "please choose the target file";
            //open_target_file.Filter = "(*.xlsx)|*.xlsx";
            if (open_target_file.ShowDialog() == DialogResult.OK)
            {

                target_filename = open_target_file.FileName;

                Target_path.Text = target_filename;
               // string filename = Path.GetFileName(target_path.Text);

            }


        }

        private void Transfer_Button_Click(object sender, EventArgs e)
        {
            if (Excel_path.Text != "" && Target_path.Text != "")
            {
                Reader read = new Reader(Excel_path.Text, Target_path.Text);
            }
            else
            {
                MessageBox.Show("please select the right source and target ");

            }

        }
        
          private void Trans_Non_Quo_Button_Click(object sender, EventArgs e)
        {
            if (Excel_path.Text != "" && Target_path.Text != "")
            {
                Reader read = new Reader(Excel_path.Text, Target_path.Text, Quotation_choose.Text);
            }

            else {
                MessageBox.Show("please select the right source and target ");
            }
        }

        private void Main_Trans_Load(object sender, EventArgs e)
        {

        }

        private void Quotation_choose_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Script_save_button_click(object sender, EventArgs e)
        {
            string script_file_folder = "";
            SaveFileDialog folder_choose = new SaveFileDialog();
            folder_choose.RestoreDirectory=true;
            folder_choose.Filter = "database script(*.sql)|*.sql";
            if (folder_choose.ShowDialog() == DialogResult.OK)
            {
                script_file_folder = folder_choose.FileName.ToString();

                Script_destination_text.Text = script_file_folder;
            }
           

        }

        private void Script_source_button_click(object sender, EventArgs e)
        {
            string script_source = "";
            OpenFileDialog source = new OpenFileDialog();
            source.Title ="please choose source file";
            if (source.ShowDialog() == DialogResult.OK)
            {
                script_source = source.FileName;

                Script_source_text.Text = script_source;
            }


        }

        private void Script_generate_button_Click(object sender, EventArgs e)
        {

            if (Script_source_text.Text != "" && Script_destination_text.Text != "")
            {
                //script source
                string script_source = Script_source_text.Text;
                //script destination
                string script_file = Script_destination_text.Text;
                FileCreater file = new FileCreater(script_file);

                Reader read = new Reader();

                read.ExcelReader(script_file, script_source);

            }
            else
            {

                MessageBox.Show("please select the right sourece and target file");


            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
