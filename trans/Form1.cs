using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trans
{
    public partial class Form1 : Form
    {
        static string excel_filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Excel(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;
            openfile.Title = "please choose the excel file";
            openfile.Filter = "(*.xls)|*.xls";
            if (openfile.ShowDialog() == DialogResult.OK)
            {

                excel_filename = openfile.FileName;
      
                

            }

        }
    }
}
