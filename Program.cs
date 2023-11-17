using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Data;

namespace VendorApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        private Button btnUploadPDF;
        private TextBox txtFilePath;
        private SaveFileDialog saveFileDialog;

        public MainForm()
        {
            btnUploadPDF = new Button { Text = "Upload PDF" };
            btnUploadPDF.Click += BtnUploadPDF_Click;

            txtFilePath = new TextBox { Width = 400 };
            saveFileDialog = new SaveFileDialog { Filter = "PDF files (*.pdf)|*.pdf" };

            Controls.Add(btnUploadPDF);
            Controls.Add(txtFilePath);

            btnUploadPDF.Location = new Point(10, 10);
            txtFilePath.Location = new Point(10, 50);
        }

        private void BtnUploadPDF_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = saveFileDialog.FileName;
                SaveDocumentPathToDatabase(saveFileDialog.FileName);
            }
        }

        private void SaveDocumentPathToDatabase(string filePath)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VendorApplicationDB.mdf;Integrated Security=True";
            string query = "INSERT INTO Documents (DocumentName, DocumentPath) VALUES (@name, @path)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", Path.GetFileName(filePath));
                    cmd.Parameters.AddWithValue("@path", filePath);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
