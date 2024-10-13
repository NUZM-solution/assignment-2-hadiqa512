using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Assignment2_datagrid_
{
    public partial class HadiqaTulZahra : Form
    {
        DataTable dt = new DataTable();
        PrintDocument printDocument1 = new PrintDocument(); // Declare PrintDocument globally
        public HadiqaTulZahra()
        {
            InitializeComponent();
            InitializeDataTable();
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
        }
        private void InitializeDataTable()
        {
            dt.Columns.Add("Course_Code", typeof(string));
            dt.Columns.Add("Course_Title", typeof(string));
            dt.Columns.Add("Obtained_Marks", typeof(int));
            dt.Columns.Add("Grade", typeof(string));
            dt.Columns.Add("Status", typeof(string));
        }

        private void AddNewRow()
        {
            DataRow row = dt.NewRow();
            row["Course_Code"] = txt_CC.Text;  
            row["Course_Title"] = txt_CT.Text;  
            row["Obtained_Marks"] = Convert.ToInt32(txt_OM.Text);                          // Date
            row["Grade"] = txt_G.Text;  
            row["Status"] = txt_S.Text;         

            dt.Rows.Add(row); 
            dataGridView1.DataSource = dt; 
        }
        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            AddNewRow();
        }
        private void btn_Print_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print(); // Start printing process
            }
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up fonts and positioning
            Font printFont = new Font("Arial", 12);
            int rowHeight = 30;
            int startX = 10;
            int startY = 10;
            int cellWidth = 150;

            // Loop through the DataGridView columns and print headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, printFont, Brushes.Black, startX + (i * cellWidth), startY);
            }

            // Loop through the DataGridView rows and print each cell value
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                startY += rowHeight;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[j].Value.ToString(), printFont, Brushes.Black, startX + (j * cellWidth), startY);
                }
            }
        }
        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
